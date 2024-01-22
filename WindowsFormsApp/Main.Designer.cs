namespace WindowsFormsApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_topbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolboxControl1 = new DevExpress.XtraToolbox.ToolboxControl();
            this.pn_headernavbar = new System.Windows.Forms.Panel();
            this.pn_titlenvar = new System.Windows.Forms.Panel();
            this.lb_roll = new System.Windows.Forms.Label();
            this.lb_mainusername = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_topbatmain = new System.Windows.Forms.Panel();
            this.Ib_titlepage = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_cont = new System.Windows.Forms.Panel();
            this.xpPageSelector1 = new DevExpress.Xpo.XPPageSelector(this.components);
            this.btn_loginout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_cat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.btn_PUR = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_setteing = new System.Windows.Forms.Button();
            this.btn_developer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_collapse = new System.Windows.Forms.Button();
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_headernavbar.SuspendLayout();
            this.pn_titlenvar.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pn_topbatmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_topbar.Controls.Add(this.btn_loginout);
            this.pn_topbar.Controls.Add(this.btn_min);
            this.pn_topbar.Controls.Add(this.label1);
            this.pn_topbar.Controls.Add(this.btn_max);
            this.pn_topbar.Controls.Add(this.btn_close);
            this.pn_topbar.Location = new System.Drawing.Point(12, 6);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(317, 64);
            this.pn_topbar.TabIndex = 0;
            this.pn_topbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_topbar_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(656, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "الرئيسية";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Controls.Add(this.pn_headernavbar);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_navbar.Location = new System.Drawing.Point(1011, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(269, 720);
            this.pn_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.toolboxControl1);
            this.flowLayoutPanel1.Controls.Add(this.btn_main);
            this.flowLayoutPanel1.Controls.Add(this.btn_cat);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.btn_supp);
            this.flowLayoutPanel1.Controls.Add(this.btn_PUR);
            this.flowLayoutPanel1.Controls.Add(this.btn_Customer);
            this.flowLayoutPanel1.Controls.Add(this.btn_sell);
            this.flowLayoutPanel1.Controls.Add(this.btn_Report);
            this.flowLayoutPanel1.Controls.Add(this.btn_users);
            this.flowLayoutPanel1.Controls.Add(this.btn_setteing);
            this.flowLayoutPanel1.Controls.Add(this.btn_developer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 480);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // toolboxControl1
            // 
            this.toolboxControl1.Location = new System.Drawing.Point(3, 3);
            this.toolboxControl1.Name = "toolboxControl1";
            this.toolboxControl1.Size = new System.Drawing.Size(250, 50);
            this.toolboxControl1.TabIndex = 11;
            this.toolboxControl1.Click += new System.EventHandler(this.toolboxControl1_Click);
            // 
            // pn_headernavbar
            // 
            this.pn_headernavbar.Controls.Add(this.pn_titlenvar);
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel2);
            this.pn_headernavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_headernavbar.Location = new System.Drawing.Point(0, 0);
            this.pn_headernavbar.Name = "pn_headernavbar";
            this.pn_headernavbar.Size = new System.Drawing.Size(269, 240);
            this.pn_headernavbar.TabIndex = 0;
            // 
            // pn_titlenvar
            // 
            this.pn_titlenvar.Controls.Add(this.pictureBox1);
            this.pn_titlenvar.Controls.Add(this.lb_roll);
            this.pn_titlenvar.Controls.Add(this.lb_mainusername);
            this.pn_titlenvar.Location = new System.Drawing.Point(6, 0);
            this.pn_titlenvar.Name = "pn_titlenvar";
            this.pn_titlenvar.Size = new System.Drawing.Size(200, 237);
            this.pn_titlenvar.TabIndex = 3;
            // 
            // lb_roll
            // 
            this.lb_roll.AutoSize = true;
            this.lb_roll.ForeColor = System.Drawing.Color.Ivory;
            this.lb_roll.Location = new System.Drawing.Point(22, 190);
            this.lb_roll.Name = "lb_roll";
            this.lb_roll.Size = new System.Drawing.Size(48, 29);
            this.lb_roll.TabIndex = 3;
            this.lb_roll.Text = "ادمن";
            // 
            // lb_mainusername
            // 
            this.lb_mainusername.AutoSize = true;
            this.lb_mainusername.ForeColor = System.Drawing.Color.Ivory;
            this.lb_mainusername.Location = new System.Drawing.Point(24, 150);
            this.lb_mainusername.Name = "lb_mainusername";
            this.lb_mainusername.Size = new System.Drawing.Size(131, 29);
            this.lb_mainusername.TabIndex = 2;
            this.lb_mainusername.Text = "مصطفي محمود";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_collapse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(227, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(42, 240);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // pn_topbatmain
            // 
            this.pn_topbatmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_topbatmain.Controls.Add(this.Ib_titlepage);
            this.pn_topbatmain.Controls.Add(this.pn_topbar);
            this.pn_topbatmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbatmain.Location = new System.Drawing.Point(0, 0);
            this.pn_topbatmain.Name = "pn_topbatmain";
            this.pn_topbatmain.Size = new System.Drawing.Size(1011, 76);
            this.pn_topbatmain.TabIndex = 2;
            this.pn_topbatmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Ib_titlepage
            // 
            this.Ib_titlepage.AutoSize = true;
            this.Ib_titlepage.ForeColor = System.Drawing.Color.Ivory;
            this.Ib_titlepage.Location = new System.Drawing.Point(541, 26);
            this.Ib_titlepage.Name = "Ib_titlepage";
            this.Ib_titlepage.Size = new System.Drawing.Size(75, 29);
            this.Ib_titlepage.TabIndex = 1;
            this.Ib_titlepage.Text = "الرئيسية";
            this.Ib_titlepage.Click += new System.EventHandler(this.label_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_topbatmain;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pn_cont
            // 
            this.pn_cont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_cont.Location = new System.Drawing.Point(0, 76);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1011, 644);
            this.pn_cont.TabIndex = 3;
            this.pn_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_cont_Paint);
            // 
            // btn_loginout
            // 
            this.btn_loginout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_loginout.ImageOptions.Image")));
            this.btn_loginout.Location = new System.Drawing.Point(256, 9);
            this.btn_loginout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loginout.Name = "btn_loginout";
            this.btn_loginout.Size = new System.Drawing.Size(42, 50);
            this.btn_loginout.TabIndex = 0;
            this.btn_loginout.Click += new System.EventHandler(this.btn_loginout_Click);
            // 
            // btn_min
            // 
            this.btn_min.Image = global::WindowsFormsApp.Properties.Resources.icons8_normal_screen_321;
            this.btn_min.Location = new System.Drawing.Point(89, 9);
            this.btn_min.MaximumSize = new System.Drawing.Size(50, 50);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(50, 50);
            this.btn_min.TabIndex = 17;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Image = global::WindowsFormsApp.Properties.Resources.icons8_full_screen_32;
            this.btn_max.Location = new System.Drawing.Point(175, 9);
            this.btn_max.MaximumSize = new System.Drawing.Size(50, 50);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(50, 50);
            this.btn_max.TabIndex = 18;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = global::WindowsFormsApp.Properties.Resources.Hopstarter_Button_Button_Close_32;
            this.btn_close.Location = new System.Drawing.Point(3, 9);
            this.btn_close.MaximumSize = new System.Drawing.Size(50, 50);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 16;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_main
            // 
            this.btn_main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_main.ForeColor = System.Drawing.Color.Gray;
            this.btn_main.Image = global::WindowsFormsApp.Properties.Resources.Fatcow_Farm_Fresh_Menu_item_32;
            this.btn_main.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_main.Location = new System.Drawing.Point(3, 59);
            this.btn_main.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(250, 35);
            this.btn_main.TabIndex = 10;
            this.btn_main.Text = "الرئيسية";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cat.ForeColor = System.Drawing.Color.Gray;
            this.btn_cat.Image = global::WindowsFormsApp.Properties.Resources.Fatcow_Farm_Fresh_Menu_item_32;
            this.btn_cat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_cat.Location = new System.Drawing.Point(3, 100);
            this.btn_cat.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(250, 35);
            this.btn_cat.TabIndex = 2;
            this.btn_cat.Text = "الاصناف";
            this.btn_cat.UseVisualStyleBackColor = true;
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Image = global::WindowsFormsApp.Properties.Resources.Graphicloads_100_Flat_Home_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(3, 141);
            this.button3.MaximumSize = new System.Drawing.Size(250, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 0);
            this.button3.TabIndex = 1;
            this.button3.Text = "الرئيسية";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_supp
            // 
            this.btn_supp.ForeColor = System.Drawing.Color.Gray;
            this.btn_supp.Image = global::WindowsFormsApp.Properties.Resources.Icons_Land_Vista_People_Groups_Meeting_Dark_32;
            this.btn_supp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_supp.Location = new System.Drawing.Point(3, 147);
            this.btn_supp.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(250, 35);
            this.btn_supp.TabIndex = 3;
            this.btn_supp.Text = "الموردين";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // btn_PUR
            // 
            this.btn_PUR.ForeColor = System.Drawing.Color.Gray;
            this.btn_PUR.Image = global::WindowsFormsApp.Properties.Resources.Icons8_Windows_8_Ecommerce_Return_Purchase_32;
            this.btn_PUR.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_PUR.Location = new System.Drawing.Point(3, 188);
            this.btn_PUR.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_PUR.Name = "btn_PUR";
            this.btn_PUR.Size = new System.Drawing.Size(250, 35);
            this.btn_PUR.TabIndex = 4;
            this.btn_PUR.Text = "الوحدات";
            this.btn_PUR.UseVisualStyleBackColor = true;
            this.btn_PUR.Click += new System.EventHandler(this.btn_PUR_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.ForeColor = System.Drawing.Color.Gray;
            this.btn_Customer.Image = global::WindowsFormsApp.Properties.Resources.Hopstarter_Soft_Scraps_User_Group_32;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Customer.Location = new System.Drawing.Point(3, 229);
            this.btn_Customer.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(250, 35);
            this.btn_Customer.TabIndex = 5;
            this.btn_Customer.Text = "العملاء";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.ForeColor = System.Drawing.Color.Gray;
            this.btn_sell.Image = global::WindowsFormsApp.Properties.Resources.Babasse_Bagg_And_Boxs_Corbeille_box_sale_v_32;
            this.btn_sell.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sell.Location = new System.Drawing.Point(3, 270);
            this.btn_sell.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(250, 35);
            this.btn_sell.TabIndex = 6;
            this.btn_sell.Text = "المبيعات";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.ForeColor = System.Drawing.Color.Gray;
            this.btn_Report.Image = global::WindowsFormsApp.Properties.Resources.Custom_Icon_Design_Pretty_Office_6_Custom_reports_32;
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Report.Location = new System.Drawing.Point(3, 311);
            this.btn_Report.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(250, 35);
            this.btn_Report.TabIndex = 7;
            this.btn_Report.Text = "التقارير";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_users
            // 
            this.btn_users.ForeColor = System.Drawing.Color.Gray;
            this.btn_users.Image = global::WindowsFormsApp.Properties.Resources.Icons_Land_Vista_People_Office_Customer_Male_Dark_32;
            this.btn_users.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_users.Location = new System.Drawing.Point(3, 352);
            this.btn_users.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(250, 35);
            this.btn_users.TabIndex = 8;
            this.btn_users.Text = "المستخدمين";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_setteing
            // 
            this.btn_setteing.ForeColor = System.Drawing.Color.Gray;
            this.btn_setteing.Image = global::WindowsFormsApp.Properties.Resources.Dtafalonso_Android_Lollipop_Settings_32;
            this.btn_setteing.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_setteing.Location = new System.Drawing.Point(3, 393);
            this.btn_setteing.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_setteing.Name = "btn_setteing";
            this.btn_setteing.Size = new System.Drawing.Size(250, 35);
            this.btn_setteing.TabIndex = 9;
            this.btn_setteing.Text = "الاعدادات";
            this.btn_setteing.UseVisualStyleBackColor = true;
            this.btn_setteing.Click += new System.EventHandler(this.btn_setteing_Click);
            // 
            // btn_developer
            // 
            this.btn_developer.ForeColor = System.Drawing.Color.Gray;
            this.btn_developer.Image = global::WindowsFormsApp.Properties.Resources.Dtafalonso_Android_Lollipop_Settings_32;
            this.btn_developer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_developer.Location = new System.Drawing.Point(3, 434);
            this.btn_developer.MaximumSize = new System.Drawing.Size(250, 250);
            this.btn_developer.Name = "btn_developer";
            this.btn_developer.Size = new System.Drawing.Size(250, 35);
            this.btn_developer.TabIndex = 12;
            this.btn_developer.Text = "عن المبرمج";
            this.btn_developer.UseVisualStyleBackColor = true;
            this.btn_developer.Click += new System.EventHandler(this.btn_developer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_collapse
            // 
            this.btn_collapse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_collapse.Image = global::WindowsFormsApp.Properties.Resources.Ionic_Ionicons_List_32;
            this.btn_collapse.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_collapse.Location = new System.Drawing.Point(3, 3);
            this.btn_collapse.MaximumSize = new System.Drawing.Size(50, 50);
            this.btn_collapse.Name = "btn_collapse";
            this.btn_collapse.Size = new System.Drawing.Size(34, 35);
            this.btn_collapse.TabIndex = 1;
            this.btn_collapse.UseVisualStyleBackColor = true;
            this.btn_collapse.Click += new System.EventHandler(this.btn_collapse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_topbatmain);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_headernavbar.ResumeLayout(false);
            this.pn_titlenvar.ResumeLayout(false);
            this.pn_titlenvar.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pn_topbatmain.ResumeLayout(false);
            this.pn_topbatmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topbar;
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_topbatmain;
        private System.Windows.Forms.Label Ib_titlepage;
        private System.Windows.Forms.Panel pn_headernavbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_cat;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Button btn_PUR;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_setteing;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_collapse;
        private System.Windows.Forms.Panel pn_titlenvar;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel pn_cont;
        private DevExpress.Xpo.XPPageSelector xpPageSelector1;
        private DevExpress.XtraToolbox.ToolboxControl toolboxControl1;
        public System.Windows.Forms.Label lb_roll;
        public System.Windows.Forms.Label lb_mainusername;
        public DevExpress.XtraEditors.SimpleButton btn_loginout;
        private System.Windows.Forms.Button btn_developer;
    }
}

