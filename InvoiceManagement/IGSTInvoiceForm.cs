using InvoiceManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class IGSTInvoiceForm : Form
    {
        Supplier supplier = new Supplier();
        Particulars particular = new Particulars();
        Invoice invoice = new Invoice();
        NumberToWordConverter numberToWordConverter = new NumberToWordConverter();
        private string connectionString;
        private int ctr = 0;
        private double SumAmount = 0;
        private AutoCompleteStringCollection autoCompleteList = new AutoCompleteStringCollection();
        private int InvoiceIdToUpdate = 0;



        public IGSTInvoiceForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            this.lb_GSTNumber.Text = ConfigurationManager.AppSettings["lb_GSTNumber"];
            this.lb_Signature.Text = ConfigurationManager.AppSettings["lb_Signature"];
            txt_InvoiceNumber.Text = lastInvoiceNumber();
            txtInvoiceDate.Hide();
            InvoicedataGrid.RowHeadersVisible = false;
            this.InvoicedataGrid.Columns[0].Width = 40;
            this.InvoicedataGrid.Columns[1].Width = 220;
            this.InvoicedataGrid.Columns[2].Width = 60;
            this.InvoicedataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.InvoicedataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.InvoicedataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.totalAmount.TextAlign = HorizontalAlignment.Right;
            //this.SGST.TextAlign = HorizontalAlignment.Right;
            this.CGST.TextAlign = HorizontalAlignment.Right;
            this.netTotal.TextAlign = HorizontalAlignment.Right;
            var ListNames = GetSupplier();
            autoCompleteList.AddRange(ListNames);
            supName.AutoCompleteCustomSource = autoCompleteList;
            supName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            supName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            supName.KeyDown += supName_KeyDown;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpdate.Hide();



        }

        private void supName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.Name = (sender as TextBox).Text;
            }
        }

        private void supName_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(supName.Text, supName.Font);
            supName.Width = size.Width;
            supName.Height = size.Height;
            string SuppName = supName.Text;
            string GSTIN = string.Empty;
            GSTIN = GetGSTIN(SuppName);
            if (!string.IsNullOrEmpty(GSTIN))
            {
                supGSTIN.Text = GSTIN;
            }
            else
            {
                supGSTIN.Text = string.Empty;
            }





        }
        private string GetGSTIN(string suppName)
        {
            string GSTIN = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT  top 1 * FROM Supplier where Name='{suppName}' ", con);
                var queryReader = cmd.ExecuteReader();
                while (queryReader.Read())
                {
                    supplier.Id = Convert.ToInt16(queryReader["Id"].ToString());
                    supplier.InvoiceNumber = queryReader["InvoiceNumber"].ToString();
                    supplier.InvoiceDate = queryReader["InvoiceDate"].ToString();
                    supplier.Name = queryReader["Name"].ToString();
                    supplier.Address = queryReader["Address"].ToString();
                    supplier.GSTIN = queryReader["GSTIN"].ToString();
                    supplier.SupplySite = queryReader["SupplySite"].ToString();
                    GSTIN = supplier.GSTIN;
                }
            }
            return GSTIN;
        }
        private string[] GetSupplier()
        {
            Supplier supplier = new Supplier();
            List<string> supplierName = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier", con);
                var queryReader = cmd.ExecuteReader();
                while (queryReader.Read())
                {
                    supplier.Id = Convert.ToInt16(queryReader["Id"].ToString());
                    supplier.InvoiceNumber = queryReader["InvoiceNumber"].ToString();
                    supplier.InvoiceDate = queryReader["InvoiceDate"].ToString();
                    supplier.Name = queryReader["Name"].ToString();
                    supplier.Address = queryReader["Address"].ToString();
                    supplier.GSTIN = queryReader["GSTIN"].ToString();
                    supplier.SupplySite = queryReader["SupplySite"].ToString();
                    supplierName.Add(supplier.Name);

                }
            }
            return supplierName.ToArray();
        }
        private int MaxId()
        {
            int Id = 0;
            string result = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Supplier", con);
                cmd.CommandType = CommandType.Text;
                var queryresult = cmd.ExecuteScalar();
                result = queryresult.ToString();
                Id = !string.IsNullOrEmpty(result) ? Convert.ToInt32(result) : Id;
                con.Close();
                return Id + 1;
            }
        }

        private int MaxParticularsId()
        {
            int Id = 0;
            string result = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Particular", con);
                cmd.CommandType = CommandType.Text;
                var queryresult = cmd.ExecuteScalar();
                result = queryresult != null ? queryresult.ToString() : string.Empty;
                Id = !string.IsNullOrEmpty(result) ? Convert.ToInt32(result) : Id;
                con.Close();
                return Id + 1;
            }
        }

        private int MaxInvoiceID()
        {
            int Id = 0;
            string result = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Invoice", con);
                cmd.CommandType = CommandType.Text;
                var queryresult = cmd.ExecuteScalar();
                result = queryresult != null ? queryresult.ToString() : string.Empty;
                Id = !string.IsNullOrEmpty(result) ? Convert.ToInt32(result) : Id;
                con.Close();
                return Id + 1;
            }
        }
        bool IsAnyNullOrEmpty(object myObject)
        {
            foreach (PropertyInfo pi in myObject.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(myObject);
                    if (string.IsNullOrEmpty(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Success = 0;
            try
            {
                supplier.Id = MaxId();
                supplier.InvoiceNumber = txt_InvoiceNumber.Text;
                supplier.InvoiceDate = InvoiceDate.Text;
                supplier.Name = supName.Text;
                supplier.Address = supAddress.Text;
                supplier.GSTIN = supGSTIN.Text;
                supplier.SupplySite = supSupplySite.Text;
                if (!string.IsNullOrEmpty(supplier.Name))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        //supplier insert
                        SqlCommand cmd = new SqlCommand($"INSERT INTO Supplier (Id, InvoiceNumber, InvoiceDate, Name, Address, GSTIN, SupplySite) VALUES ({supplier.Id}, '{supplier.InvoiceNumber}','{supplier.InvoiceDate}', '{supplier.Name}','{supplier.Address}', '{supplier.GSTIN}','{supplier.SupplySite}')", con);
                        cmd.CommandType = CommandType.Text;
                        Success = cmd.ExecuteNonQuery();

                        if (Success > 0)
                        {

                            int Counter = 0;
                            //particulars insert
                            foreach (DataGridViewRow row in InvoicedataGrid.Rows)
                            {
                                if (InvoicedataGrid.Rows.Count != 1)
                                {
                                    Counter++;
                                    if (Counter != InvoicedataGrid.Rows.Count)
                                    {
                                        particular.Id = MaxParticularsId();
                                        particular.SupplierId = supplier.Id;
                                        particular.Item = Convert.ToInt16(row.Cells[0].Value.ToString());
                                        particular.Particular = row.Cells[1].Value.ToString();
                                        particular.HSN = row.Cells[2].Value.ToString();
                                        particular.Qty = row.Cells[3].Value.ToString();
                                        particular.Rate = Convert.ToDecimal(row.Cells[4].Value);
                                        particular.Amount = Convert.ToDecimal(row.Cells[5].Value);
                                        if (!IsAnyNullOrEmpty(particular))
                                        {

                                            SqlCommand cmd2 = new SqlCommand($"INSERT INTO Particular (Id, SupplierId, Item, Particulars, HSN, Qty, Rate, Amount) VALUES ({particular.Id},{particular.SupplierId}, '{particular.Item}','{particular.Particular}', '{particular.HSN}','{particular.Qty}', '{particular.Rate}','{particular.Amount}')", con);
                                            cmd2.CommandType = CommandType.Text;
                                            Success = cmd2.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            Success = 0;
                                            SqlCommand cmd4 = new SqlCommand($"delete from Supplier where Id={supplier.Id}", con);
                                            cmd4.CommandType = CommandType.Text;
                                            cmd4.ExecuteNonQuery();
                                            MessageBox.Show("Particular Table can not be empty, please enter a valid data");
                                        }
                                    }
                                }
                                else
                                {
                                    Success = 0;
                                    SqlCommand cmd5 = new SqlCommand($"delete from Supplier where Id={supplier.Id}", con);
                                    cmd5.CommandType = CommandType.Text;
                                    cmd5.ExecuteNonQuery();
                                    MessageBox.Show("Particular Table can not be empty, please enter a valid data");

                                }
                            }

                            //Invoice insert
                            if (Success > 0)
                            {

                                invoice.Id = MaxInvoiceID();
                                invoice.InvoiceId = supplier.Id;
                                invoice.SupplierId = particular.Id;
                                invoice.Amount = Convert.ToDecimal(totalAmount.Text.ToString());
                                invoice.CGST = Convert.ToDecimal(CGST.Text.ToString());
                                invoice.SGST = 0;
                                invoice.netAmount = Convert.ToDecimal(netTotal.Text.ToString());
                                invoice.amountInWord = txtAmount.Text.ToString();
                                if (!IsAnyNullOrEmpty(invoice))
                                {

                                    SqlCommand cmd3 = new SqlCommand($"INSERT INTO Invoice (Id, InvoiceId, SupplierId, Amount, CGST, SGST, netAmount,amountInWord) VALUES ({invoice.Id}, '{invoice.InvoiceId}','{invoice.SupplierId}', '{invoice.Amount}','{invoice.CGST}', '{invoice.SGST}','{invoice.netAmount}','{invoice.amountInWord}')", con);
                                    cmd3.CommandType = CommandType.Text;
                                    Success = cmd3.ExecuteNonQuery();
                                    if (Success > 0)
                                    {
                                        MessageBox.Show("Invoice saved Successfully", " New Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Hide();

                                        //InvoiceListForm invoiceListForm = new InvoiceListForm();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Date supplied.");

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Data Supplied, Please enter a valid Data");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Date supplied.");

                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Can not save empty value, please enter a valid Data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" sql Error Please enter a valid Data");

            }

        }

        private void InvoicedataGrid_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == 5 && e.RowIndex > -1)//particulars
            {
                DataGridViewRow row = InvoicedataGrid.Rows[e.RowIndex];
                try
                {
                    particular.Qty = Regex.Match(row.Cells[3].Value.ToString(), @"[0-9]+(\.[0-9]+)?").Value;//row.Cells[3].Value.ToString().Replace("m3"," ");
                    particular.Rate = Convert.ToDecimal(row.Cells[4].Value);
                    particular.Amount = Convert.ToDecimal(Convert.ToDecimal(particular.Qty) * particular.Rate);
                    InvoicedataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format("{0:0.00}", particular.Amount);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please enter a Valid Data");
                }

                foreach (DataGridViewRow cell in InvoicedataGrid.Rows)
                {
                    ctr++;
                    if (ctr != InvoicedataGrid.Rows.Count && !string.IsNullOrEmpty(cell.Cells[5].Value.ToString()))
                    {
                        SumAmount += Convert.ToDouble(cell.Cells[5].Value);

                    }
                    if (ctr == InvoicedataGrid.Rows.Count)
                    {
                        totalAmount.Text = Convert.ToDecimal(SumAmount.ToString()).ToString("0.##");
                        CGST.Text = Convert.ToDecimal((0.05 * SumAmount).ToString()).ToString(("0.##"));
                       // SGST.Text = Convert.ToDecimal((0.025 * SumAmount).ToString()).ToString(("0.##"));
                        netTotal.Text = Math.Round(Convert.ToDecimal(SumAmount + (0.05 * SumAmount))).ToString();
                        txtAmount.Text = numberToWordConverter.convertToWords(netTotal.Text) + "Only";
                        SumAmount = 0;
                    }

                }
                ctr = 0;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex > -1)//hsn cell
            {
                DataGridViewRow row = InvoicedataGrid.Rows[e.RowIndex];
                try
                {
                    particular.Particular = row.Cells[1].Value.ToString();
                    if (particular.Particular.Contains("sand"))
                    {
                        //2505
                        InvoicedataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "2505";

                    }
                    else//metal
                    {
                        //2516
                        InvoicedataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "2516";
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Please enter a valid data");
                }

            }
            else
            {
                //do nothing
            }


        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txtAmount.Text, txtAmount.Font);
            txtAmount.Width = size.Width;
            txtAmount.Height = size.Height;
        }

        private string lastInvoiceNumber()
        {
            string lastInvoiceNumber = string.Empty;
            int MaxID = MaxId();
            int number = 0;
            string newInvoiceNumber = string.Empty;
            string result = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"select InvoiceNumber from Supplier where Id={MaxID - 1}", con);
                cmd.CommandType = CommandType.Text;
                var queryresult = cmd.ExecuteScalar();
                result = queryresult != null ? queryresult.ToString() : string.Empty;
                lastInvoiceNumber = !string.IsNullOrEmpty(result) ? result : "00/22-23";
                con.Close();

            }
            if (!string.IsNullOrEmpty(lastInvoiceNumber))
            {
                string[] invoice = lastInvoiceNumber.Split('/');
                number = Convert.ToInt32(invoice[0]);
                number++;
                newInvoiceNumber = number.ToString() + "/" + invoice[1];
                lastInvoiceNumber = newInvoiceNumber;
            }

            return lastInvoiceNumber;
        }

        private void lbl_InvoiceNumber_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txt_InvoiceNumber.Text, txt_InvoiceNumber.Font);
            txt_InvoiceNumber.Width = size.Width;
            txt_InvoiceNumber.Height = size.Height;
        }



        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            string message = "Do you want to clear  the  Invoice records?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                supName.Text = "";
                supAddress.Text = "";
                CGST.Text = "";
                supGSTIN.Text = "";
                supSupplySite.Text = "";
                totalAmount.Text = "";
                txtAmount.Text = "";
                //SGST.Text = "";
                netTotal.Text = "";
                txtInvoiceDate.Text = "";
                InvoicedataGrid.Rows.Clear();
            }
            else
            {
                // Do something  
            }

        }

        public void UpdateInvoiceForm(int InvoiceId, DataGridViewRow Erow, bool modifyData)
        {
            //get data from sp
            //this.btnSave.Hide();
            // this.btnCancel.Hide();


            List<Particulars> particularsList = new List<Particulars>();
            bool flag = false;

            //get Value on forms
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INVOICEDATA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@INVOICEID", InvoiceId);
                var queryReader = cmd.ExecuteReader();
                while (queryReader.Read())
                {
                    txt_InvoiceNumber.Text = queryReader["InvoiceNumber"].ToString();
                    InvoiceDate.Text = queryReader["InvoiceDate"].ToString();
                    supName.Text = queryReader["Name"].ToString();
                    supAddress.Text = queryReader["Address"].ToString();
                    supGSTIN.Text = queryReader["GSTIN"].ToString();
                    supSupplySite.Text = queryReader["SupplySite"].ToString();
                    totalAmount.Text = queryReader["Amount"].ToString();
                    CGST.Text = queryReader["CGST"].ToString();
                   // SGST.Text = queryReader["SGST"].ToString();
                    netTotal.Text = queryReader["netAmount"].ToString();
                    txtAmount.Text = queryReader["AmountInword"].ToString();
                    txtInvoiceDate.Text = queryReader["InvoiceDate"].ToString();
                    flag = true;
                }
                if (flag)
                {
                    queryReader.Close();
                    SqlCommand cmd3 = new SqlCommand($"select  Item,Particulars,HSN,Qty,Rate,Amount from Particular  where SupplierId={InvoiceId} order by 1 desc", con);
                    cmd3.CommandType = CommandType.Text;
                    var queryReader2 = cmd3.ExecuteReader();

                    while (queryReader2.Read())
                    {
                        var Supp = new Particulars
                        {
                            Item = Convert.ToInt16(queryReader2["Item"]),
                            Particular = queryReader2["Particulars"].ToString(),
                            HSN = queryReader2["HSN"].ToString(),
                            Qty = queryReader2["Qty"].ToString(),
                            Rate = Convert.ToDecimal(queryReader2["Rate"]),
                            Amount = Convert.ToDecimal(queryReader2["Amount"])
                        };
                        particularsList.Add(Supp);



                    }
                    InvoicedataGrid.Rows.Add(particularsList.Count);
                    int ctr = particularsList.Count;

                    foreach (var i in particularsList)
                    {
                        InvoicedataGrid.Rows[ctr].Cells[0].Value = i.Item;
                        InvoicedataGrid.Rows[ctr].Cells[1].Value = i.Particular;
                        InvoicedataGrid.Rows[ctr].Cells[2].Value = i.HSN;
                        InvoicedataGrid.Rows[ctr].Cells[3].Value = string.Format("{0:0.00}", i.Qty);
                        InvoicedataGrid.Rows[ctr].Cells[4].Value = string.Format("{0:0.00}", i.Rate);
                        InvoicedataGrid.Rows[ctr].Cells[5].Value = string.Format("{0:0.00}", i.Amount);
                        ctr--;



                    }
                    removeEmptyRows();



                }
                con.Close();
            }

            //save modified Values
            if (modifyData)
            {
                // this.
                this.InvoiceDate.Text = txtInvoiceDate.Text;
                this.InvoiceDate.Show();
                // this.txtInvoiceDate.Show();
                InvoiceIdToUpdate = InvoiceId;
                this.button1.Enabled = false;
                this.btnSave.Hide();
                this.btnUpdate.Show();

            }
            else//just show the data
            {
                this.InvoiceDate.Hide();
                this.txtInvoiceDate.Show();
                this.btnSave.Enabled = false;
                this.btnUpdate.Hide();

            }



        }

        private void removeEmptyRows()
        {
            for (int i = InvoicedataGrid.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = InvoicedataGrid.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    InvoicedataGrid.Rows.RemoveAt(i);
                }
            }
        }
        Bitmap bitmap;

        private void button1_Click(object sender, EventArgs e)
        {
            this.btnClose.Hide();
            removeEmptyRows();
            //this.btnCancel.Hide();
            this.btnSave.Hide();
            this.button1.Hide();
            this.btnClose.Hide();
            this.InvoicedataGrid.ClearSelection();
            this.InvoicedataGrid.DefaultCellStyle.SelectionBackColor = this.InvoicedataGrid.DefaultCellStyle.BackColor;
            this.InvoicedataGrid.DefaultCellStyle.SelectionForeColor = this.InvoicedataGrid.DefaultCellStyle.ForeColor;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();


        }

        Bitmap Transparent2Color(Bitmap bmp1, Color target)
        {
            Bitmap bmp2 = new Bitmap(bmp1.Width, bmp1.Height);
            Rectangle rect = new Rectangle(Point.Empty, bmp1.Size);
            using (Graphics G = Graphics.FromImage(bmp2))
            {
                G.Clear(target);
                G.DrawImageUnscaledAndClipped(bmp1, rect);
            }
            return bmp2;
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            this.btnClose.Hide();
            bitmap = new Bitmap(new InvoiceFormCopy().Width, new InvoiceFormCopy().Height);
            bitmap = Transparent2Color(bitmap, Color.White);
            this.DrawToBitmap(bitmap, this.DisplayRectangle);
            e.Graphics.DrawImage(bitmap, 0, 0);
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
            this.btnClose.Show();




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Success = 0;

            try
            {
                //get Supplier Id
                supplier.Id = InvoiceIdToUpdate;
                supplier.InvoiceNumber = txt_InvoiceNumber.Text;
                supplier.InvoiceDate = InvoiceDate.Text;
                supplier.Name = supName.Text;
                supplier.Address = supAddress.Text;
                supplier.GSTIN = supGSTIN.Text;
                supplier.SupplySite = supSupplySite.Text;
                if (!string.IsNullOrEmpty(supplier.Name))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        //supplier insert
                        SqlCommand cmd = new SqlCommand($"update Supplier set InvoiceDate='{supplier.InvoiceDate}',Name='{supplier.Name}',Address='{supplier.Address}',GSTIN='{supplier.GSTIN}',SupplySite='{supplier.SupplySite}', InvoiceNumber='{supplier.InvoiceNumber}' where Id={supplier.Id}", con);
                        cmd.CommandType = CommandType.Text;
                        Success = cmd.ExecuteNonQuery();

                        if (Success > 0)
                        {

                            int Counter = 0;
                            //particulars update
                            foreach (DataGridViewRow row in InvoicedataGrid.Rows)
                            {
                                if (InvoicedataGrid.Rows.Count >= 1)
                                {
                                    Counter++;
                                    if (Counter != InvoicedataGrid.Rows.Count)
                                    {
                                        // particular.Id = MaxParticularsId();
                                        particular.SupplierId = supplier.Id;
                                        particular.Item = Convert.ToInt16(row.Cells[0].Value.ToString());
                                        particular.Particular = row.Cells[1].Value.ToString();
                                        particular.HSN = row.Cells[2].Value.ToString();
                                        particular.Qty = row.Cells[3].Value.ToString();
                                        particular.Rate = Convert.ToDecimal(row.Cells[4].Value);
                                        particular.Amount = Convert.ToDecimal(row.Cells[5].Value);
                                        if (!IsAnyNullOrEmpty(particular))
                                        {

                                            SqlCommand cmd2 = new SqlCommand($"update Particular set Particulars='{particular.Particular}',HSN='{particular.HSN}',Qty='{particular.Qty}',Rate={particular.Rate},Amount={particular.Amount} where SupplierId={particular.SupplierId} and Item={particular.Item}", con);
                                            cmd2.CommandType = CommandType.Text;
                                            Success = cmd2.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            Success = 0;

                                        }
                                    }
                                }
                                else
                                {
                                    Success = 0;


                                }
                            }

                            //Invoice insert
                            if (Success > 0)
                            {

                                //invoice.Id = MaxInvoiceID();
                                invoice.InvoiceId = supplier.Id;
                                invoice.SupplierId = particular.Id;
                                invoice.Amount = Convert.ToDecimal(totalAmount.Text.ToString());
                                invoice.CGST = Convert.ToDecimal(CGST.Text.ToString());
                                invoice.SGST = 0;
                                invoice.netAmount = Convert.ToDecimal(netTotal.Text.ToString());
                                invoice.amountInWord = txtAmount.Text.ToString();
                                if (!IsAnyNullOrEmpty(invoice.amountInWord))
                                {

                                    SqlCommand cmd3 = new SqlCommand($"update Invoice set Amount={invoice.Amount},CGST={invoice.CGST},SGST={invoice.SGST},netAmount={invoice.netAmount},AmountInword='{invoice.amountInWord}' where InvoiceId={invoice.InvoiceId}", con);
                                    cmd3.CommandType = CommandType.Text;
                                    Success = cmd3.ExecuteNonQuery();
                                    if (Success > 0)
                                    {
                                        MessageBox.Show("Invoice Updated Successfully", " Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Hide();


                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Date supplied.");

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Data Supplied, Please enter a valid Data");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Date supplied.");

                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Can not save empty value, please enter a valid Data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" sql Error Please enter a valid Data");

            }
        }
    }
}
