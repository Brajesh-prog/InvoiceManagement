namespace InvoiceManagement
{
    partial class SimpleListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleListForm));
            this.textPlace = new System.Windows.Forms.TextBox();
            this.ListDataGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mtr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netVolume = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textPlace
            // 
            this.textPlace.Location = new System.Drawing.Point(496, 17);
            this.textPlace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(289, 26);
            this.textPlace.TabIndex = 0;
            this.textPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListDataGridView
            // 
            this.ListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Particulars,
            this.Mtr});
            this.ListDataGridView.Location = new System.Drawing.Point(186, 85);
            this.ListDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListDataGridView.Name = "ListDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListDataGridView.Size = new System.Drawing.Size(906, 649);
            this.ListDataGridView.TabIndex = 1;
            this.ListDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDataGridView_CellEnter);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            // 
            // Mtr
            // 
            this.Mtr.HeaderText = "Mtr";
            this.Mtr.Name = "Mtr";
            // 
            // netVolume
            // 
            this.netVolume.Location = new System.Drawing.Point(948, 8);
            this.netVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netVolume.Name = "netVolume";
            this.netVolume.Size = new System.Drawing.Size(136, 40);
            this.netVolume.TabIndex = 4;
            this.netVolume.Text = "GenerateBill";
            this.netVolume.UseVisualStyleBackColor = true;
            this.netVolume.Click += new System.EventHandler(this.netVolume_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(262, 14);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 35);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "PrintList";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1100, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SimpleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1263, 734);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.netVolume);
            this.Controls.Add(this.ListDataGridView);
            this.Controls.Add(this.textPlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SimpleListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mtr;
        private System.Windows.Forms.Button netVolume;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.TextBox textPlace;
        public System.Windows.Forms.DataGridView ListDataGridView;
        private System.Windows.Forms.Button btnClose;
    }
}