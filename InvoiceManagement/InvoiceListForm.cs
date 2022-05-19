using InvoiceManagement.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class InvoiceListForm : Form
    {
        private string connectionString;
        public InvoiceListForm()
        {
            InitializeComponent();
            searchBox.Hide();
            btnGo.Hide();
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "REMOVE";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(deleteButton);


            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }
        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["dataGridViewDeleteButton"].Index)
            {
                string message = "Delete the Invoice?"+"\n"+ "You will not able to recover it";
                string title = "Delete Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //first remove from db 
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int SupplierId = Convert.ToInt16(row.Cells[1].Value.ToString());
                    int success = 0;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand($"delete from Invoice where InvoiceId={SupplierId}", con);
                        cmd.CommandType = CommandType.Text;
                        success = cmd.ExecuteNonQuery();
                        if (success > 0)
                        {
                            SqlCommand cmd1 = new SqlCommand($"delete  from Particular where SupplierId={SupplierId}", con);
                            cmd1.CommandType = CommandType.Text;
                            success = cmd1.ExecuteNonQuery();
                        }
                        if (success > 0)
                        {
                            SqlCommand cmd2 = new SqlCommand($"delete  from supplier where Id={SupplierId}", con);
                            cmd2.CommandType = CommandType.Text;
                            success = cmd2.ExecuteNonQuery();
                        }

                        con.Close();
                    }
                    if (success > 0)
                    {
                        //remove from UI
                        MessageBox.Show("Invoice is Deleted Sucessfully");
                        this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Can not remove empty rows");
                    }
                }
                else
                {
                    //do nothing
                }
                

            }
        }
        void InvoiceListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prompt user to save his data
                if (MessageBox.Show("Are you sure to exit the Invoice Management System?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }

            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                // Autosave and clear up ressources
            }
        }
        public void InvoiceListForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Fill(ds, "Supplier");
                dataGridView1.DataSource = ds.Tables["Supplier"].DefaultView;
                con.Close();
                this.dataGridView1.AllowUserToAddRows = false;
            }

            // SVFTable_dataGridView.DataSource = svftable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InvoiceFormCopy frmInvoiceForm = new InvoiceFormCopy();
            frmInvoiceForm.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = true;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select top 50  * from Supplier order by  1 desc", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Fill(ds, "Supplier");
                dataGridView1.DataSource = ds.Tables["Supplier"].DefaultView;
                con.Close();
            }
            this.dataGridView1.Show();
            this.searchBox.Hide();
            this.btnGo.Hide();
            this.dataGridView1.AllowUserToAddRows = false;



        }



        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            searchBox.Show();
            btnGo.Show();
            this.Show();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchtxt = searchBox.Text.ToString();
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"select top 50  * from Supplier where Name like '%{searchtxt}%' or InvoiceNumber like '%{searchtxt}%' or InvoiceDate like '%{searchtxt}%' or Address like '%{searchtxt}%'  or GSTIN like '%{searchtxt}%' or  SupplySite like '%{searchtxt}%' order by 1 desc", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Fill(ds, "Supplier");
                dataGridView1.DataSource = ds.Tables["Supplier"].DefaultView;
                con.Close();
            }
            this.searchBox.Hide();
            this.btnGo.Hide();
            this.dataGridView1.Show();
            this.dataGridView1.AllowUserToAddRows = false;


        }

        public bool CheckIGSTorSGST(int InvoiceId)
        {
            bool check = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"select SGST from Invoice where InvoiceId={InvoiceId}", con);
                cmd.CommandType = CommandType.Text;
                var result=cmd.ExecuteScalar();
                check =result.ToString()=="0.00"? true : false;
                con.Close();
            }
            return check;

        }

        private void dataGridView1_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            int InvoiceId = 0;
            if (e.RowIndex > -1 && e.ColumnIndex > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                InvoiceId = Convert.ToInt16(row.Cells[1].Value.ToString());
                //get IGST or sgst invoice
                if (CheckIGSTorSGST(InvoiceId))
                {
                    IGSTInvoiceForm iGSTInvoice = new IGSTInvoiceForm();
                    iGSTInvoice.UpdateInvoiceForm(InvoiceId);
                    iGSTInvoice.Show();
                }
                else
                {
                    InvoiceFormCopy invoiceFormCopy = new InvoiceFormCopy();
                    invoiceFormCopy.UpdateInvoiceForm(InvoiceId);
                    invoiceFormCopy.Show();
                    //InvoiceForm invoiceForm = new InvoiceForm();
                    //invoiceForm.UpdateInvoiceForm(InvoiceId);
                    //invoiceForm.Show();
                }
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleListForm simpleListForm = new SimpleListForm();
            simpleListForm.Show();
        }

        private void btnIGST_Click(object sender, EventArgs e)
        {
            IGSTInvoiceForm iGSTInvoice = new IGSTInvoiceForm();
            iGSTInvoice.Show();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    SimpleListForm lstbtn = new SimpleListForm(ListBillForm);
        //    lstbtn.Show();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    SimpleListForm simpleListForm = new SimpleListForm();
        //    simpleListForm.Show();

        //}
    }
}
