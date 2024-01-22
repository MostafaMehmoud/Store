namespace WindowsFormsApp.PL
{
    partial class FRM_CAT_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAT_ADD));
            this.Ib_titlepage = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_Cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Ib_titlepage
            // 
            this.Ib_titlepage.AutoSize = true;
            this.Ib_titlepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ib_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.Ib_titlepage.Location = new System.Drawing.Point(301, 109);
            this.Ib_titlepage.Name = "Ib_titlepage";
            this.Ib_titlepage.Size = new System.Drawing.Size(134, 38);
            this.Ib_titlepage.TabIndex = 18;
            this.Ib_titlepage.Text = "نوع الوحدة";
            // 
            // edt_name
            // 
            this.edt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(204, 181);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(319, 45);
            this.edt_name.TabIndex = 25;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_name.TextChanged += new System.EventHandler(this.edt_name_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add.Image = global::WindowsFormsApp.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Add_event_32;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(677, 534);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 67);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "اضافة";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_Cover
            // 
            this.pic_Cover.EditValue = ((object)(resources.GetObject("pic_Cover.EditValue")));
            this.pic_Cover.Location = new System.Drawing.Point(204, 249);
            this.pic_Cover.Name = "pic_Cover";
            this.pic_Cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_Cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_Cover.Size = new System.Drawing.Size(319, 289);
            this.pic_Cover.TabIndex = 26;
            // 
            // btn_close
            // 
            this.btn_close.Image = global::WindowsFormsApp.Properties.Resources.Hopstarter_Button_Button_Close_32;
            this.btn_close.Location = new System.Drawing.Point(738, 3);
            this.btn_close.MaximumSize = new System.Drawing.Size(50, 50);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 17;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FRM_CAT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_Cover);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.Ib_titlepage);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CAT_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label Ib_titlepage;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox edt_name;
        public DevExpress.XtraEditors.PictureEdit pic_Cover;
    }
}