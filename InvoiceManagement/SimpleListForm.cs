using InvoiceManagement.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class SimpleListForm : Form
    {
        private ListBillForm form1;

        public SimpleListForm()
        {
            InitializeComponent();

        }
        public SimpleListForm(ListBillForm billForm)
        {
            InitializeComponent();
            if (billForm != null)
            {
                this.form1 = billForm;
            }

        }
        



        private void ListDataGridView_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
          
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                DataGridViewRow row = ListDataGridView.Rows[e.RowIndex];
                var a = Convert.ToDecimal(row.Cells[2].Value);
                ListDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            }
        }
        int Counter = 0;
        double Sum = 0;
        private void ListDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex >= 1)
            {

                foreach (DataGridViewRow row in ListDataGridView.Rows)
                {
                    Counter++;
                    Sum = 0;
                    if (Counter != ListDataGridView.Rows.Count)
                    {
                        DataGridViewRow r = ListDataGridView.Rows[ListDataGridView.Rows.Count - 2];
                        if (!string.IsNullOrEmpty(r.Cells[2].Value.ToString()) && !(r.Cells[2].Value.ToString().Contains("m3")))
                        {
                            string mtr = r.Cells[2].Value.ToString();
                            string[] mtrs = mtr.Split('+');
                            string mtrUnit = string.Empty;
                            for (int i = 0; i < mtrs.Length; i++)
                            {
                                try
                                {
                                    Sum = Sum + Convert.ToDouble(mtrs[i]);


                                    if (mtrs.Length == 1)
                                    {
                                        mtrUnit = mtrUnit + mtrs[i] + "m3";

                                    }
                                    else
                                    {
                                        mtrUnit = mtrUnit + mtrs[i] + "m3+";

                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Please Enter a Valid Number");
                                }

                                
                            }
                            ListDataGridView.Rows[e.RowIndex - 1].Cells[2].Value = mtrUnit + "=" + Sum + "m3";
                            break;
                        }
                    }
                }


            }
        }

        private void netVolume_Click(object sender, EventArgs e)
        {
            this.ListDataGridView.AllowUserToAddRows = true;
            ListBillForm billForm = new ListBillForm(this);
            billForm.Show();
            
          
        }

        private void removeEmptyRows()
        {
            for (int i = ListDataGridView.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = ListDataGridView.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    ListDataGridView.Rows.RemoveAt(i);
                }
            }
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

        Bitmap bitmap;
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            this.btnClose.Hide();
            this.ListDataGridView.DefaultCellStyle.SelectionBackColor = this.ListDataGridView.DefaultCellStyle.BackColor;
            this.ListDataGridView.DefaultCellStyle.SelectionForeColor = this.ListDataGridView.DefaultCellStyle.ForeColor;
            this.ListDataGridView.AllowUserToAddRows = false;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();


        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            int height = ListDataGridView.Height + 1000;
            ListDataGridView.Height = ListDataGridView.RowCount * ListDataGridView.RowTemplate.Height * 2;
            bitmap = new Bitmap(ListDataGridView.Width, ListDataGridView.Height);
            bitmap=Transparent2Color(bitmap, Color.White);
            ListDataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, ListDataGridView.Width, ListDataGridView.Height));
            ListDataGridView.Height = height;
            //Draw Header
            e.Graphics.DrawString(textPlace.Text.ToUpper(),
                new Font(ListDataGridView.Font, FontStyle.Bold),
                Brushes.Black, e.MarginBounds.Top+300,
                e.MarginBounds.Top - e.Graphics.MeasureString(textPlace.Text.ToUpper(),
                new Font(ListDataGridView.Font, FontStyle.Bold),
                e.MarginBounds.Top).Height - 1);
            e.Graphics.DrawImage(bitmap, 100, 100);
            this.btnClose.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
