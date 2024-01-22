namespace WindowsFormsApp.PL
{
    partial class setteing
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
            this.pn_set = new System.Windows.Forms.Panel();
            this.edt_svr = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_set
            // 
            this.pn_set.Controls.Add(this.edt_svr);
            this.pn_set.Controls.Add(this.save);
            this.pn_set.Controls.Add(this.label1);
            this.pn_set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_set.Location = new System.Drawing.Point(0, 0);
            this.pn_set.Name = "pn_set";
            this.pn_set.Size = new System.Drawing.Size(1011, 644);
            this.pn_set.TabIndex = 0;
            // 
            // edt_svr
            // 
            this.edt_svr.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_svr.Location = new System.Drawing.Point(109, 154);
            this.edt_svr.Multiline = true;
            this.edt_svr.Name = "edt_svr";
            this.edt_svr.Size = new System.Drawing.Size(558, 46);
            this.edt_svr.TabIndex = 8;
            this.edt_svr.Text = "DESKTOP-KADFQJ9\\SQL2022";
            // 
            // save
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(322, 401);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(293, 90);
            this.save.TabIndex = 7;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "السيرفر";
            // 
            // setteing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 644);
            this.Controls.Add(this.pn_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "setteing";
            this.Text = "FRM_CAT";
            this.pn_set.ResumeLayout(false);
            this.pn_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox edt_svr;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pn_set;
    }
}