using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class Login : Form
    {
        private string connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text;
            string password = txtPassword.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Users where UserName='" + email + "'  and Password='" + password + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {

                    CallLogin();
                }
                else
                {
                    MessageBox.Show("Incorrect username and/or password supplied.");
                }
                con.Close();
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the LMK Logistics Invoice Management Sudio?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void CallLogin()
        {
            this.Hide();
            InvoiceListForm invoiceListForm = new InvoiceListForm();
            invoiceListForm.Show();
            
        }

        void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prompt user to save his data
                if (MessageBox.Show("Are you sure to exit the LMK Logistics Invoice Management Sudio?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                // Autosave and clear up ressources
            }
        }

    }
}
