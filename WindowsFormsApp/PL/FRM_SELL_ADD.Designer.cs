namespace WindowsFormsApp.PL
{
    partial class FRM_SELL_ADD
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
            this.edt_cus = new System.Windows.Forms.ComboBox();
            this.edt_Name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.edt_sell = new System.Windows.Forms.TextBox();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.btn_add_pur = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_QT = new System.Windows.Forms.TextBox();
            this.txt_Buy = new System.Windows.Forms.TextBox();
            this.txt_sell = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xpPageSelector1 = new DevExpress.Xpo.XPPageSelector(this.components);
            this.messageqt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
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
            this.Ib_titlepage.Location = new System.Drawing.Point(344, 2);
            this.Ib_titlepage.Name = "Ib_titlepage";
            this.Ib_titlepage.Size = new System.Drawing.Size(210, 32);
            this.Ib_titlepage.TabIndex = 18;
            this.Ib_titlepage.Text = "المعلومات الاساسية";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.linkLabel2);
            this.panelControl1.Controls.Add(this.edt_cus);
            this.panelControl1.Controls.Add(this.edt_Name);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.Ib_titlepage);
            this.panelControl1.Location = new System.Drawing.Point(737, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(559, 224);
            this.panelControl1.TabIndex = 32;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(213, 136);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(66, 24);
            this.linkLabel2.TabIndex = 46;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // edt_cus
            // 
            this.edt_cus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_cus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_cus.FormattingEnabled = true;
            this.edt_cus.Location = new System.Drawing.Point(21, 135);
            this.edt_cus.Name = "edt_cus";
            this.edt_cus.Size = new System.Drawing.Size(186, 24);
            this.edt_cus.TabIndex = 44;
            this.edt_cus.SelectedIndexChanged += new System.EventHandler(this.edt_cus_SelectedIndexChanged);
            // 
            // edt_Name
            // 
            this.edt_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_Name.FormattingEnabled = true;
            this.edt_Name.Location = new System.Drawing.Point(21, 69);
            this.edt_Name.Name = "edt_Name";
            this.edt_Name.Size = new System.Drawing.Size(186, 24);
            this.edt_Name.TabIndex = 42;
            this.edt_Name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(477, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "اسم الوحدة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(473, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "اسم العميل";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.edt_sell);
            this.panelControl2.Controls.Add(this.edt_qt);
            this.panelControl2.Controls.Add(this.btn_add_pur);
            this.panelControl2.Controls.Add(this.label11);
            this.panelControl2.Controls.Add(this.label12);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Location = new System.Drawing.Point(739, 293);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(557, 288);
            this.panelControl2.TabIndex = 39;
            // 
            // edt_sell
            // 
            this.edt_sell.Location = new System.Drawing.Point(18, 81);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(186, 23);
            this.edt_sell.TabIndex = 47;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(454, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "عدد الوحدات";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(475, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 37;
            this.label12.Text = "سعر البيع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(216, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "البيـــــــــــــــــــــــــــــــــــــــع";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.txt_QT);
            this.panelControl3.Controls.Add(this.txt_Buy);
            this.panelControl3.Controls.Add(this.txt_sell);
            this.panelControl3.Controls.Add(this.label10);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Location = new System.Drawing.Point(110, 106);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(548, 475);
            this.panelControl3.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(132, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 57);
            this.label3.TabIndex = 36;
            this.label3.Text = "تفاصيل المادة";
            // 
            // txt_QT
            // 
            this.txt_QT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txt_QT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_QT.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QT.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_QT.Location = new System.Drawing.Point(217, 423);
            this.txt_QT.Name = "txt_QT";
            this.txt_QT.Size = new System.Drawing.Size(119, 33);
            this.txt_QT.TabIndex = 35;
            this.txt_QT.Text = "0";
            // 
            // txt_Buy
            // 
            this.txt_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txt_Buy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buy.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buy.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_Buy.Location = new System.Drawing.Point(213, 159);
            this.txt_Buy.Name = "txt_Buy";
            this.txt_Buy.Size = new System.Drawing.Size(126, 33);
            this.txt_Buy.TabIndex = 34;
            this.txt_Buy.Text = "0";
            // 
            // txt_sell
            // 
            this.txt_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txt_sell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sell.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sell.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_sell.Location = new System.Drawing.Point(207, 298);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(139, 33);
            this.txt_sell.TabIndex = 33;
            this.txt_sell.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(229, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 46);
            this.label10.TabIndex = 32;
            this.label10.Text = "الكمية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(203, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 46);
            this.label2.TabIndex = 31;
            this.label2.Text = "سعر البيع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(188, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "سعر الشراء";
            // 
            // messageqt
            // 
            this.messageqt.AutoSize = true;
            this.messageqt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageqt.ForeColor = System.Drawing.Color.Red;
            this.messageqt.Location = new System.Drawing.Point(591, 584);
            this.messageqt.Name = "messageqt";
            this.messageqt.Size = new System.Drawing.Size(230, 46);
            this.messageqt.TabIndex = 41;
            this.messageqt.Text = "الكمية غير كافية";
            this.messageqt.Visible = false;
            // 
            // FRM_SELL_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 744);
            this.Controls.Add(this.messageqt);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRM_SELL_ADD";
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
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Ib_titlepage;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
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
        public System.Windows.Forms.TextBox txt_QT;
        public System.Windows.Forms.TextBox txt_Buy;
        public System.Windows.Forms.TextBox txt_sell;
        public System.Windows.Forms.ComboBox edt_cus;
        public System.Windows.Forms.ComboBox edt_Name;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
        public System.Windows.Forms.Button btn_add_pur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageqt;
        public System.Windows.Forms.TextBox edt_sell;
    }
}