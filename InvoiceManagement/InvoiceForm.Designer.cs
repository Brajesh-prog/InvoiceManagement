using System;

namespace InvoiceManagement
{
	partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.lb_EnterprisesName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_Signature = new System.Windows.Forms.Label();
            this.lb_GSTNumber = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.supName = new System.Windows.Forms.TextBox();
            this.supAddress = new System.Windows.Forms.TextBox();
            this.supGSTIN = new System.Windows.Forms.TextBox();
            this.supSupplySite = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.InvoicedataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SGST = new System.Windows.Forms.TextBox();
            this.CGST = new System.Windows.Forms.TextBox();
            this.netTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txt_InvoiceNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicedataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_EnterprisesName
            // 
            this.lb_EnterprisesName.AutoSize = true;
            this.lb_EnterprisesName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EnterprisesName.Location = new System.Drawing.Point(418, 86);
            this.lb_EnterprisesName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EnterprisesName.Name = "lb_EnterprisesName";
            this.lb_EnterprisesName.Size = new System.Drawing.Size(516, 42);
            this.lb_EnterprisesName.TabIndex = 1;
            this.lb_EnterprisesName.Text = "BHAGIRATHI ENTERPRISES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colvale, Bardez-Goa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "BUILDING MATERIAL SUPPLIERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Invoice No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(944, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cell :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(987, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "9226313735";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(987, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "7768850012";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(579, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "TAX INVOICE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(854, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Invoice Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Supplied To,";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 242);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 282);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "GSTIN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 322);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Supply Site";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(75, 359);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "State: GOA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 359);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "State Code: 30";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(734, 793);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Total amount before Tax:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(734, 823);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = "Add CGST @ 2.5%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(734, 856);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "Add SGST @ 2.5%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(734, 891);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(168, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = "Total amount after Tax";
            // 
            // lb_Signature
            // 
            this.lb_Signature.AutoSize = true;
            this.lb_Signature.Location = new System.Drawing.Point(897, 929);
            this.lb_Signature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Signature.Name = "lb_Signature";
            this.lb_Signature.Size = new System.Drawing.Size(194, 20);
            this.lb_Signature.TabIndex = 27;
            this.lb_Signature.Text = "For Bhagirathi Enterprises";
            // 
            // lb_GSTNumber
            // 
            this.lb_GSTNumber.AutoSize = true;
            this.lb_GSTNumber.Location = new System.Drawing.Point(75, 882);
            this.lb_GSTNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_GSTNumber.Name = "lb_GSTNumber";
            this.lb_GSTNumber.Size = new System.Drawing.Size(220, 20);
            this.lb_GSTNumber.TabIndex = 28;
            this.lb_GSTNumber.Text = " GSTIN 30ACHPG1046M1ZY";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(182, 903);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(116, 20);
            this.label29.TabIndex = 31;
            this.label29.Text = "State Code: 30";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(79, 903);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 20);
            this.label30.TabIndex = 30;
            this.label30.Text = "State: GOA";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(80, 791);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 20);
            this.label28.TabIndex = 32;
            this.label28.Text = "Rupees:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(166, 202);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 20);
            this.label31.TabIndex = 34;
            this.label31.Text = ":";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(166, 242);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(16, 20);
            this.label32.TabIndex = 35;
            this.label32.Text = ":";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(166, 282);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(16, 20);
            this.label33.TabIndex = 36;
            this.label33.Text = ":";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(166, 322);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(16, 20);
            this.label34.TabIndex = 37;
            this.label34.Text = ":";
            // 
            // supName
            // 
            this.supName.Location = new System.Drawing.Point(184, 198);
            this.supName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.supName.Name = "supName";
            this.supName.Size = new System.Drawing.Size(223, 26);
            this.supName.TabIndex = 38;
            // 
            // supAddress
            // 
            this.supAddress.Location = new System.Drawing.Point(184, 238);
            this.supAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.supAddress.Name = "supAddress";
            this.supAddress.Size = new System.Drawing.Size(223, 26);
            this.supAddress.TabIndex = 39;
            // 
            // supGSTIN
            // 
            this.supGSTIN.Location = new System.Drawing.Point(184, 278);
            this.supGSTIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.supGSTIN.Name = "supGSTIN";
            this.supGSTIN.Size = new System.Drawing.Size(223, 26);
            this.supGSTIN.TabIndex = 40;
            // 
            // supSupplySite
            // 
            this.supSupplySite.Location = new System.Drawing.Point(184, 318);
            this.supSupplySite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.supSupplySite.Name = "supSupplySite";
            this.supSupplySite.Size = new System.Drawing.Size(223, 26);
            this.supSupplySite.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(512, 966);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(634, 966);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(166, 67);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(13, 20);
            this.label35.TabIndex = 45;
            this.label35.Text = ":";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InvoiceDate.Location = new System.Drawing.Point(969, 167);
            this.InvoiceDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(116, 26);
            this.InvoiceDate.TabIndex = 46;
            // 
            // InvoicedataGrid
            // 
            this.InvoicedataGrid.AccessibleName = "InvoicedataGrid";
            this.InvoicedataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoicedataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.InvoicedataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoicedataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoicedataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoicedataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem,
            this.ColumnParticulars,
            this.ColumnMSN,
            this.ColumnQty,
            this.ColumnRate,
            this.ColumnAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoicedataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.InvoicedataGrid.Location = new System.Drawing.Point(76, 388);
            this.InvoicedataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InvoicedataGrid.Name = "InvoicedataGrid";
            this.InvoicedataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InvoicedataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InvoicedataGrid.Size = new System.Drawing.Size(1008, 394);
            this.InvoicedataGrid.TabIndex = 47;
            this.InvoicedataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InvoicedataGrid_CellMouseClick);
            // 
            // ColumnItem
            // 
            this.ColumnItem.HeaderText = "Item";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnParticulars
            // 
            this.ColumnParticulars.HeaderText = "Particulars";
            this.ColumnParticulars.Name = "ColumnParticulars";
            this.ColumnParticulars.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnMSN
            // 
            this.ColumnMSN.HeaderText = "HSN";
            this.ColumnMSN.Name = "ColumnMSN";
            this.ColumnMSN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnQty
            // 
            this.ColumnQty.HeaderText = "Qty";
            this.ColumnQty.Name = "ColumnQty";
            this.ColumnQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnRate
            // 
            this.ColumnRate.HeaderText = "Rate";
            this.ColumnRate.Name = "ColumnRate";
            this.ColumnRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(915, 979);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Authorised Signatory";
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(986, 786);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(100, 26);
            this.totalAmount.TabIndex = 49;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(158, 789);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(326, 26);
            this.txtAmount.TabIndex = 51;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // SGST
            // 
            this.SGST.Location = new System.Drawing.Point(986, 850);
            this.SGST.Name = "SGST";
            this.SGST.Size = new System.Drawing.Size(100, 26);
            this.SGST.TabIndex = 52;
            // 
            // CGST
            // 
            this.CGST.Location = new System.Drawing.Point(986, 816);
            this.CGST.Name = "CGST";
            this.CGST.Size = new System.Drawing.Size(100, 26);
            this.CGST.TabIndex = 53;
            // 
            // netTotal
            // 
            this.netTotal.Location = new System.Drawing.Point(986, 883);
            this.netTotal.Name = "netTotal";
            this.netTotal.Size = new System.Drawing.Size(100, 26);
            this.netTotal.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 1007);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 55;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(969, 166);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(116, 26);
            this.txtInvoiceDate.TabIndex = 56;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(634, 1006);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 40);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txt_InvoiceNumber
            // 
            this.txt_InvoiceNumber.Location = new System.Drawing.Point(184, 63);
            this.txt_InvoiceNumber.Name = "txt_InvoiceNumber";
            this.txt_InvoiceNumber.Size = new System.Drawing.Size(223, 26);
            this.txt_InvoiceNumber.TabIndex = 58;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1451, 676);
            this.ControlBox = false;
            this.Controls.Add(this.txt_InvoiceNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.netTotal);
            this.Controls.Add(this.CGST);
            this.Controls.Add(this.SGST);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.InvoicedataGrid);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.supSupplySite);
            this.Controls.Add(this.supGSTIN);
            this.Controls.Add(this.supAddress);
            this.Controls.Add(this.supName);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lb_GSTNumber);
            this.Controls.Add(this.lb_Signature);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_EnterprisesName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.InvoicedataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lb_EnterprisesName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label lb_Signature;
		private System.Windows.Forms.Label lb_GSTNumber;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox supName;
		private System.Windows.Forms.TextBox supAddress;
		private System.Windows.Forms.TextBox supGSTIN;
		private System.Windows.Forms.TextBox supSupplySite;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.DateTimePicker InvoiceDate;
		private System.Windows.Forms.DataGridView InvoicedataGrid;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox SGST;
        private System.Windows.Forms.TextBox CGST;
        private System.Windows.Forms.TextBox netTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txt_InvoiceNumber;
    }
}