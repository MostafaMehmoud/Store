namespace WindowsFormsApp.PL
{
    partial class FRM_SELL
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
            this.pn_sell = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSell_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Tprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Sell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pn_sell.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_sell
            // 
            this.pn_sell.Controls.Add(this.gridControl1);
            this.pn_sell.Controls.Add(this.panel2);
            this.pn_sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_sell.Location = new System.Drawing.Point(0, 0);
            this.pn_sell.Name = "pn_sell";
            this.pn_sell.Size = new System.Drawing.Size(1011, 644);
            this.pn_sell.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.edt_search);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 100);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // edt_search
            // 
            this.edt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_search.Location = new System.Drawing.Point(633, 25);
            this.edt_search.Name = "edt_search";
            this.edt_search.Size = new System.Drawing.Size(319, 45);
            this.edt_search.TabIndex = 24;
            this.edt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_search.Image = global::WindowsFormsApp.Properties.Resources.Gakuseisean_Ivista_2_Start_Menu_Search_32;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(948, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(53, 45);
            this.btn_search.TabIndex = 23;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_update.Image = global::WindowsFormsApp.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_undo_32;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(423, 16);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(117, 67);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "تحديث";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_delete.Image = global::WindowsFormsApp.Properties.Resources.Iconsmind_Outline_Close_32;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(299, 16);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 67);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.Enabled = false;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_edit.Image = global::WindowsFormsApp.Properties.Resources.Designcontest_Vintage_Pencil_32;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(181, 16);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 67);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add.Image = global::WindowsFormsApp.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Add_event_32;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(64, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 67);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "اضافة";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(WindowsFormsApp.TB_Sell);
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1008, 552);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSell_Name,
            this.colSell_Cus,
            this.colSell_Price,
            this.colSell_Qt,
            this.colSell_Tprice,
            this.colDate_Sell});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSell_Name
            // 
            this.colSell_Name.Caption = "اسم الوحدة";
            this.colSell_Name.FieldName = "Sell_Name";
            this.colSell_Name.MinWidth = 25;
            this.colSell_Name.Name = "colSell_Name";
            this.colSell_Name.Visible = true;
            this.colSell_Name.VisibleIndex = 0;
            this.colSell_Name.Width = 94;
            // 
            // colSell_Cus
            // 
            this.colSell_Cus.Caption = "اسم العميل";
            this.colSell_Cus.FieldName = "Sell_Cus";
            this.colSell_Cus.MinWidth = 25;
            this.colSell_Cus.Name = "colSell_Cus";
            this.colSell_Cus.Visible = true;
            this.colSell_Cus.VisibleIndex = 1;
            this.colSell_Cus.Width = 94;
            // 
            // colSell_Price
            // 
            this.colSell_Price.Caption = "سعر الوحدة";
            this.colSell_Price.FieldName = "Sell_Price";
            this.colSell_Price.MinWidth = 25;
            this.colSell_Price.Name = "colSell_Price";
            this.colSell_Price.Visible = true;
            this.colSell_Price.VisibleIndex = 2;
            this.colSell_Price.Width = 94;
            // 
            // colSell_Qt
            // 
            this.colSell_Qt.Caption = "عدد الوحدات";
            this.colSell_Qt.FieldName = "Sell_Qt";
            this.colSell_Qt.MinWidth = 25;
            this.colSell_Qt.Name = "colSell_Qt";
            this.colSell_Qt.Visible = true;
            this.colSell_Qt.VisibleIndex = 3;
            this.colSell_Qt.Width = 94;
            // 
            // colSell_Tprice
            // 
            this.colSell_Tprice.Caption = "السعرالكلي لوحدات";
            this.colSell_Tprice.FieldName = "Sell_Tprice";
            this.colSell_Tprice.MinWidth = 25;
            this.colSell_Tprice.Name = "colSell_Tprice";
            this.colSell_Tprice.Visible = true;
            this.colSell_Tprice.VisibleIndex = 4;
            this.colSell_Tprice.Width = 94;
            // 
            // colDate_Sell
            // 
            this.colDate_Sell.Caption = "تاريخ البيع";
            this.colDate_Sell.FieldName = "Date_Sell";
            this.colDate_Sell.MinWidth = 25;
            this.colDate_Sell.Name = "colDate_Sell";
            this.colDate_Sell.Visible = true;
            this.colDate_Sell.VisibleIndex = 5;
            this.colDate_Sell.Width = 94;
            // 
            // FRM_SELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 644);
            this.Controls.Add(this.pn_sell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SELL";
            this.Text = "FRM_CAT";
            this.Load += new System.EventHandler(this.FRM_CAT_Load);
            this.pn_sell.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pn_sell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox edt_search;
        public System.Windows.Forms.Button btn_search;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Cus;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Tprice;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Sell;
    }
}