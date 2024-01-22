namespace WindowsFormsApp.PL
{
    partial class FRM_PUR_ADD
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
            this.components = new System.ComponentModel.Container();
            this.Ib_titlepage = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edt_supp = new System.Windows.Forms.ComboBox();
            this.edt_cat = new System.Windows.Forms.ComboBox();
            this.edt_details = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_Name_cat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_Name = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.edt_sell = new DevExpress.XtraEditors.SpinEdit();
            this.edt_buy = new DevExpress.XtraEditors.SpinEdit();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.btn_add_pur = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.edt_trev = new System.Windows.Forms.TextBox();
            this.edt_tsell = new System.Windows.Forms.TextBox();
            this.edt_tbuy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xpPageSelector1 = new DevExpress.Xpo.XPPageSelector(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_sell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_buy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ib_titlepage
            // 
            this.Ib_titlepage.AutoSize = true;
            this.Ib_titlepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ib_titlepage.ForeColor = System.Drawing.Color.Black;
            this.Ib_titlepage.Location = new System.Drawing.Point(343, 2);
            this.Ib_titlepage.Name = "Ib_titlepage";
            this.Ib_titlepage.Size = new System.Drawing.Size(210, 32);
            this.Ib_titlepage.TabIndex = 18;
            this.Ib_titlepage.Text = "المعلومات الاساسية";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.linkLabel2);
            this.panelControl1.Controls.Add(this.linkLabel1);
            this.panelControl1.Controls.Add(this.edt_supp);
            this.panelControl1.Controls.Add(this.edt_cat);
            this.panelControl1.Controls.Add(this.edt_details);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.edt_Name_cat);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.edt_Name);
            this.panelControl1.Controls.Add(this.Ib_titlepage);
            this.panelControl1.Location = new System.Drawing.Point(737, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(559, 344);
            this.panelControl1.TabIndex = 32;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(212, 198);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(66, 24);
            this.linkLabel2.TabIndex = 46;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(215, 155);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 24);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edt_supp
            // 
            this.edt_supp.FormattingEnabled = true;
            this.edt_supp.Location = new System.Drawing.Point(19, 198);
            this.edt_supp.Name = "edt_supp";
            this.edt_supp.Size = new System.Drawing.Size(186, 24);
            this.edt_supp.TabIndex = 44;
            // 
            // edt_cat
            // 
            this.edt_cat.FormattingEnabled = true;
            this.edt_cat.Location = new System.Drawing.Point(15, 155);
            this.edt_cat.Name = "edt_cat";
            this.edt_cat.Size = new System.Drawing.Size(186, 24);
            this.edt_cat.TabIndex = 42;
            this.edt_cat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // edt_details
            // 
            this.edt_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_details.Location = new System.Drawing.Point(14, 234);
            this.edt_details.Multiline = true;
            this.edt_details.Name = "edt_details";
            this.edt_details.Size = new System.Drawing.Size(421, 90);
            this.edt_details.TabIndex = 34;
            this.edt_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(494, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "تفاصيل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(400, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "نوع الوحدات الموجودة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(501, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "المورد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(509, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "النوع";
            // 
            // edt_Name_cat
            // 
            this.edt_Name_cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_Name_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_Name_cat.Location = new System.Drawing.Point(15, 98);
            this.edt_Name_cat.Multiline = true;
            this.edt_Name_cat.Name = "edt_Name_cat";
            this.edt_Name_cat.Size = new System.Drawing.Size(187, 34);
            this.edt_Name_cat.TabIndex = 30;
            this.edt_Name_cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(480, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "اسم الوحدة";
            // 
            // edt_Name
            // 
            this.edt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_Name.Location = new System.Drawing.Point(14, 51);
            this.edt_Name.Multiline = true;
            this.edt_Name.Name = "edt_Name";
            this.edt_Name.Size = new System.Drawing.Size(187, 33);
            this.edt_Name.TabIndex = 26;
            this.edt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.edt_sell);
            this.panelControl2.Controls.Add(this.edt_buy);
            this.panelControl2.Controls.Add(this.edt_qt);
            this.panelControl2.Controls.Add(this.btn_add_pur);
            this.panelControl2.Controls.Add(this.label9);
            this.panelControl2.Controls.Add(this.label11);
            this.panelControl2.Controls.Add(this.label12);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Location = new System.Drawing.Point(739, 362);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(557, 288);
            this.panelControl2.TabIndex = 39;
            // 
            // edt_sell
            // 
            this.edt_sell.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_sell.Location = new System.Drawing.Point(18, 82);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_sell.Size = new System.Drawing.Size(187, 24);
            this.edt_sell.TabIndex = 48;
            this.edt_sell.EditValueChanged += new System.EventHandler(this.edt_sell_EditValueChanged);
            // 
            // edt_buy
            // 
            this.edt_buy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_buy.Location = new System.Drawing.Point(18, 123);
            this.edt_buy.Name = "edt_buy";
            this.edt_buy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_buy.Size = new System.Drawing.Size(187, 24);
            this.edt_buy.TabIndex = 47;
            this.edt_buy.EditValueChanged += new System.EventHandler(this.edt_buy_EditValueChanged);
            // 
            // edt_qt
            // 
            this.edt_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_qt.Location = new System.Drawing.Point(18, 167);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_qt.Size = new System.Drawing.Size(187, 24);
            this.edt_qt.TabIndex = 46;
            this.edt_qt.EditValueChanged += new System.EventHandler(this.edt_qt_EditValueChanged);
            // 
            // btn_add_pur
            // 
            this.btn_add_pur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add_pur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_pur.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add_pur.Image = global::WindowsFormsApp.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Add_event_32;
            this.btn_add_pur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_pur.Location = new System.Drawing.Point(440, 221);
            this.btn_add_pur.Name = "btn_add_pur";
            this.btn_add_pur.Size = new System.Drawing.Size(111, 67);
            this.btn_add_pur.TabIndex = 44;
            this.btn_add_pur.Text = "اضافة";
            this.btn_add_pur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_pur.UseVisualStyleBackColor = true;
            this.btn_add_pur.Click += new System.EventHandler(this.btn_add_pur_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(502, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "عدد الوحدات";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(429, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "سعر البيع (مفرد)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(415, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 25);
            this.label12.TabIndex = 37;
            this.label12.Text = "سعر الشراء (مفرد)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(394, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "البيع و الشراء";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.edt_trev);
            this.panelControl3.Controls.Add(this.edt_tsell);
            this.panelControl3.Controls.Add(this.edt_tbuy);
            this.panelControl3.Controls.Add(this.label10);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Location = new System.Drawing.Point(140, 110);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(548, 406);
            this.panelControl3.TabIndex = 40;
            // 
            // edt_trev
            // 
            this.edt_trev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.edt_trev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_trev.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_trev.ForeColor = System.Drawing.Color.IndianRed;
            this.edt_trev.Location = new System.Drawing.Point(216, 354);
            this.edt_trev.Name = "edt_trev";
            this.edt_trev.Size = new System.Drawing.Size(119, 33);
            this.edt_trev.TabIndex = 35;
            this.edt_trev.Text = "0";
            // 
            // edt_tsell
            // 
            this.edt_tsell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.edt_tsell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_tsell.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tsell.ForeColor = System.Drawing.Color.IndianRed;
            this.edt_tsell.Location = new System.Drawing.Point(212, 93);
            this.edt_tsell.Name = "edt_tsell";
            this.edt_tsell.Size = new System.Drawing.Size(126, 33);
            this.edt_tsell.TabIndex = 34;
            this.edt_tsell.Text = "0";
            // 
            // edt_tbuy
            // 
            this.edt_tbuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.edt_tbuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_tbuy.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tbuy.ForeColor = System.Drawing.Color.IndianRed;
            this.edt_tbuy.Location = new System.Drawing.Point(206, 229);
            this.edt_tbuy.Name = "edt_tbuy";
            this.edt_tbuy.Size = new System.Drawing.Size(139, 33);
            this.edt_tbuy.TabIndex = 33;
            this.edt_tbuy.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(167, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 46);
            this.label10.TabIndex = 32;
            this.label10.Text = "الارباح (الكلية)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(115, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 46);
            this.label2.TabIndex = 31;
            this.label2.Text = "المبيعات (السعر الكلي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(102, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "المشتريات (السعر الكلي)";
            // 
            // FRM_PUR_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 744);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRM_PUR_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_PUR_ADD_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_sell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_buy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Ib_titlepage;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox edt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox edt_Name_cat;
        public System.Windows.Forms.TextBox edt_details;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label9;
        //public System.Windows.Forms.TextBox qt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.Xpo.XPPageSelector xpPageSelector1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox edt_trev;
        public System.Windows.Forms.TextBox edt_tsell;
        public System.Windows.Forms.TextBox edt_tbuy;
        public System.Windows.Forms.ComboBox edt_supp;
        public System.Windows.Forms.ComboBox edt_cat;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
        public DevExpress.XtraEditors.SpinEdit edt_sell;
        public DevExpress.XtraEditors.SpinEdit edt_buy;
        public System.Windows.Forms.Button btn_add_pur;
    }
}