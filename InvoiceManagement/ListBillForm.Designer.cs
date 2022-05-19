namespace InvoiceManagement
{
    partial class ListBillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBillForm));
            this.sumDataGrideView = new System.Windows.Forms.DataGridView();
            this.Particular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.txtnetTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.printBill = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataGrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // sumDataGrideView
            // 
            this.sumDataGrideView.AllowUserToOrderColumns = true;
            this.sumDataGrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sumDataGrideView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sumDataGrideView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sumDataGrideView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumDataGrideView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sumDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumDataGrideView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Particular,
            this.Volumn,
            this.Amount,
            this.Rate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sumDataGrideView.DefaultCellStyle = dataGridViewCellStyle3;
            this.sumDataGrideView.Location = new System.Drawing.Point(14, 3);
            this.sumDataGrideView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sumDataGrideView.Name = "sumDataGrideView";
            this.sumDataGrideView.ShowCellErrors = false;
            this.sumDataGrideView.ShowCellToolTips = false;
            this.sumDataGrideView.ShowEditingIcon = false;
            this.sumDataGrideView.ShowRowErrors = false;
            this.sumDataGrideView.Size = new System.Drawing.Size(646, 251);
            this.sumDataGrideView.TabIndex = 4;
            this.sumDataGrideView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sumDataGrideView_CellMouseClick);
            // 
            // Particular
            // 
            this.Particular.HeaderText = "Particular";
            this.Particular.Name = "Particular";
            // 
            // Volumn
            // 
            this.Volumn.HeaderText = "Total Mtr";
            this.Volumn.Name = "Volumn";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Rate";
            this.Amount.Name = "Amount";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Amount";
            this.Rate.Name = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "NetTotal";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(104, 269);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 26);
            this.txtTotal.TabIndex = 11;
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(104, 311);
            this.txtGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(148, 26);
            this.txtGST.TabIndex = 12;
            // 
            // txtnetTotal
            // 
            this.txtnetTotal.Location = new System.Drawing.Point(104, 352);
            this.txtnetTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnetTotal.Name = "txtnetTotal";
            this.txtnetTotal.Size = new System.Drawing.Size(148, 26);
            this.txtnetTotal.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "GST@5%";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(15, 274);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 20);
            this.Total.TabIndex = 14;
            this.Total.Text = "Total";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(862, 3);
            this.Generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(112, 35);
            this.Generate.TabIndex = 17;
            this.Generate.Text = "GenerateBill";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // printBill
            // 
            this.printBill.Location = new System.Drawing.Point(862, 63);
            this.printBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBill.Name = "printBill";
            this.printBill.Size = new System.Drawing.Size(112, 35);
            this.printBill.TabIndex = 18;
            this.printBill.Text = "Print";
            this.printBill.UseVisualStyleBackColor = true;
            this.printBill.Click += new System.EventHandler(this.printBill_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(406, 457);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(138, 51);
            this.btnclose.TabIndex = 19;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ListBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.printBill);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.txtnetTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.sumDataGrideView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListBillForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.sumDataGrideView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Particular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.TextBox txtnetTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Total;
        public System.Windows.Forms.DataGridView sumDataGrideView;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button printBill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnclose;
    }
}