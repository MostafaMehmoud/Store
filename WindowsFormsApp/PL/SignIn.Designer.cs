namespace WindowsFormsApp.PL
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.edt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.Ib_titlepage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.pic_Cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_password
            // 
            this.edt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Location = new System.Drawing.Point(173, 388);
            this.edt_password.Name = "edt_password";
            this.edt_password.Size = new System.Drawing.Size(319, 45);
            this.edt_password.TabIndex = 33;
            this.edt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(559, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "رقم السر";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(173, 314);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(319, 45);
            this.username.TabIndex = 31;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ib_titlepage
            // 
            this.Ib_titlepage.AutoSize = true;
            this.Ib_titlepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ib_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.Ib_titlepage.Location = new System.Drawing.Point(512, 314);
            this.Ib_titlepage.Name = "Ib_titlepage";
            this.Ib_titlepage.Size = new System.Drawing.Size(161, 38);
            this.Ib_titlepage.TabIndex = 30;
            this.Ib_titlepage.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(176, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 70);
            this.label3.TabIndex = 35;
            this.label3.Text = "تسجيل الدخول";
            // 
            // btn_signin
            // 
            this.btn_signin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_signin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_signin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signin.Location = new System.Drawing.Point(55, 494);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(555, 67);
            this.btn_signin.TabIndex = 36;
            this.btn_signin.Text = "تسجيل الدحول";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // pic_Cover
            // 
            this.pic_Cover.EditValue = ((object)(resources.GetObject("pic_Cover.EditValue")));
            this.pic_Cover.Location = new System.Drawing.Point(224, 114);
            this.pic_Cover.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pic_Cover.Name = "pic_Cover";
            this.pic_Cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_Cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_Cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_Cover.Size = new System.Drawing.Size(217, 96);
            this.pic_Cover.TabIndex = 34;
            // 
            // btn_close
            // 
            this.btn_close.Image = global::WindowsFormsApp.Properties.Resources.Hopstarter_Button_Button_Close_32;
            this.btn_close.Location = new System.Drawing.Point(642, 7);
            this.btn_close.MaximumSize = new System.Drawing.Size(50, 50);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 37;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 573);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_Cover);
            this.Controls.Add(this.edt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Ib_titlepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox edt_password;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label Ib_titlepage;
        public DevExpress.XtraEditors.PictureEdit pic_Cover;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_close;
    }
}