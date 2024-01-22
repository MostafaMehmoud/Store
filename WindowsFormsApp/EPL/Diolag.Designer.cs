namespace WindowsFormsApp.EPL
{
    partial class Diolag
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
            this.txt_Caption = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_Caption
            // 
            this.txt_Caption.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Caption.ForeColor = System.Drawing.Color.Gray;
            this.txt_Caption.Location = new System.Drawing.Point(0, 0);
            this.txt_Caption.Name = "txt_Caption";
            this.txt_Caption.Size = new System.Drawing.Size(801, 135);
            this.txt_Caption.TabIndex = 20;
            this.txt_Caption.Text = "الرسالة";
            this.txt_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Caption.Click += new System.EventHandler(this.txt_Caption_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Diolag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 135);
            this.Controls.Add(this.txt_Caption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diolag";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diolag";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label txt_Caption;
        private System.Windows.Forms.Timer timer1;
    }
}