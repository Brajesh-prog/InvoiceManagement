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
    public partial class ListBillForm : Form
    {
        private SimpleListForm f2;
        public ListBillForm(SimpleListForm simpleListForm)
        {
            InitializeComponent();
            this.f2 = simpleListForm;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            int ctr = 0;
            bool sucess = false;
            List<SumList> lstSum = new List<SumList>();
            List<string> UniqPart = new List<string>();

            foreach (DataGridViewRow row in f2.ListDataGridView.Rows)
            {
                ctr++;
                SumList sumList = new SumList();
                if (ctr != f2.ListDataGridView.Rows.Count)
                {
                    try
                    {
                        sumList.Particular = f2.ListDataGridView.Rows[ctr - 1].Cells[1].Value.ToString();
                        string totalVolumn = f2.ListDataGridView.Rows[ctr - 1].Cells[2].Value.ToString();
                        sumList.Sum = Convert.ToDecimal(totalVolumn.Split('=')[1].Replace("m3", ""));
                        lstSum.Add(sumList);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Enter Valid Amount");

                    }

                }
                sucess = true;


            }

            var UniqueList = lstSum.GroupBy(x => x.Particular).Select(u => u.First()).ToList();

            foreach (var lst in UniqueList)
            {
                lstSum.Remove(lst);
            }
            int rowId = 0;
            if (UniqueList != null && UniqueList.Count > 0 && sucess)
            {
                foreach (var unique in UniqueList)
                {

                    sumDataGrideView.Rows[rowId].Cells[0].Value = unique.Particular.ToString();
                    if (lstSum.Count > 0)
                    {
                        foreach (var sum in lstSum)
                        {
                            if (unique.Particular == sum.Particular)
                            {
                                unique.Sum = unique.Sum + sum.Sum;
                                sumDataGrideView.Rows[rowId].Cells[1].Value = unique.Sum.ToString()+" m3";

                            }
                            else
                            {
                                sumDataGrideView.Rows[rowId].Cells[1].Value = unique.Sum.ToString()+" m3";

                            }
                        }
                    }
                    else
                    {
                        sumDataGrideView.Rows[rowId].Cells[1].Value = unique.Sum.ToString()+" m3";

                    }
                    rowId = sumDataGrideView.Rows.Add();

                }

                removeEmptyRows();
                sucess = true;
            }
            if (sucess)
            {
                this.Generate.Hide();
               // sumDataGrideView.AllowUserToAddRows = false;

            }
            else
            {
                //netVolume.Show();

            }
        }
        private void removeEmptyRows()
        {
            for (int i = sumDataGrideView.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = sumDataGrideView.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    sumDataGrideView.Rows.RemoveAt(i);
                }
            }
        }
        private void sumDataGrideView_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            int ctr = 0;
            double SumAmount = 0;
            if (e.ColumnIndex == 3 & e.RowIndex > -1)
            {
                DataGridViewRow row = sumDataGrideView.Rows[e.RowIndex];
                var amount = Convert.ToDouble(row.Cells[1].Value.ToString().Replace(" m3"," ").Trim()) * Convert.ToDouble(row.Cells[2].Value);
                sumDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = amount.ToString();

                foreach (DataGridViewRow cell in sumDataGrideView.Rows)
                {
                    ctr++;
                    if (cell.Cells[3].Value != null)
                    {
                        if (ctr != sumDataGrideView.Rows.Count && !string.IsNullOrEmpty(cell.Cells[3].Value.ToString()))
                        {
                            SumAmount += Convert.ToDouble(cell.Cells[3].Value);

                        }
                    }
                    if (ctr == sumDataGrideView.Rows.Count)
                    {
                        txtTotal.Text = SumAmount.ToString();
                        txtGST.Text = (0.05 * SumAmount).ToString();
                        txtnetTotal.Text = (SumAmount + (0.025 * SumAmount)).ToString();
                        SumAmount = 0;
                    }

                }
                ctr = 0;
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
        private void printBill_Click(object sender, EventArgs e)
        {
            this.sumDataGrideView.AllowUserToAddRows = false;
            this.Generate.Hide();
            this.printBill.Hide();
            this.btnclose.Hide();
            this.sumDataGrideView.DefaultCellStyle.SelectionBackColor = this.sumDataGrideView.DefaultCellStyle.BackColor;
            this.sumDataGrideView.DefaultCellStyle.SelectionForeColor = this.sumDataGrideView.DefaultCellStyle.ForeColor;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap;
            bitmap = new Bitmap(f2.Height, f2.Width, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            bitmap = Transparent2Color(bitmap, Color.White);
            this.DrawToBitmap(bitmap, this.DisplayRectangle);
            e.Graphics.DrawImage(bitmap, 0, 0);
            this.btnclose.Show();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
