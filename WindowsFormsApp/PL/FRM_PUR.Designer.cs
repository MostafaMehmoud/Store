namespace WindowsFormsApp.PL
{
    partial class FRM_PUR
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPur_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Supp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Buy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Sell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Tbuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Tsell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TRev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pn_pur = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pn_pur.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(WindowsFormsApp.TB_PUR);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1011, 544);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_2);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPur_Name,
            this.colPur_Type,
            this.colPur_Cat,
            this.colPur_Supp,
            this.colPur_Det,
            this.colPur_Buy,
            this.colPur_Sell,
            this.colPur_Qt,
            this.colPur_Tbuy,
            this.colPur_Tsell,
            this.colPur_TRev});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPur_Name
            // 
            this.colPur_Name.Caption = "اسم الوحدة";
            this.colPur_Name.FieldName = "Pur_Name";
            this.colPur_Name.MinWidth = 25;
            this.colPur_Name.Name = "colPur_Name";
            this.colPur_Name.Visible = true;
            this.colPur_Name.VisibleIndex = 0;
            this.colPur_Name.Width = 94;
            // 
            // colPur_Type
            // 
            this.colPur_Type.Caption = "نوع المشتري";
            this.colPur_Type.FieldName = "Pur_Type";
            this.colPur_Type.MinWidth = 25;
            this.colPur_Type.Name = "colPur_Type";
            this.colPur_Type.Visible = true;
            this.colPur_Type.VisibleIndex = 1;
            this.colPur_Type.Width = 94;
            // 
            // colPur_Cat
            // 
            this.colPur_Cat.Caption = "الصنف";
            this.colPur_Cat.FieldName = "Pur_Cat";
            this.colPur_Cat.MinWidth = 25;
            this.colPur_Cat.Name = "colPur_Cat";
            this.colPur_Cat.Visible = true;
            this.colPur_Cat.VisibleIndex = 2;
            this.colPur_Cat.Width = 94;
            // 
            // colPur_Supp
            // 
            this.colPur_Supp.Caption = "المورد";
            this.colPur_Supp.FieldName = "Pur_Supp";
            this.colPur_Supp.MinWidth = 25;
            this.colPur_Supp.Name = "colPur_Supp";
            this.colPur_Supp.Visible = true;
            this.colPur_Supp.VisibleIndex = 3;
            this.colPur_Supp.Width = 94;
            // 
            // colPur_Det
            // 
            this.colPur_Det.Caption = "تفاصيل";
            this.colPur_Det.FieldName = "Pur_Det";
            this.colPur_Det.MinWidth = 25;
            this.colPur_Det.Name = "colPur_Det";
            this.colPur_Det.Visible = true;
            this.colPur_Det.VisibleIndex = 4;
            this.colPur_Det.Width = 94;
            // 
            // colPur_Buy
            // 
            this.colPur_Buy.Caption = "سعر الشراء";
            this.colPur_Buy.FieldName = "Pur_Buy";
            this.colPur_Buy.MinWidth = 25;
            this.colPur_Buy.Name = "colPur_Buy";
            this.colPur_Buy.Visible = true;
            this.colPur_Buy.VisibleIndex = 5;
            this.colPur_Buy.Width = 94;
            // 
            // colPur_Sell
            // 
            this.colPur_Sell.Caption = "سعر البيع";
            this.colPur_Sell.FieldName = "Pur_Sell";
            this.colPur_Sell.MinWidth = 25;
            this.colPur_Sell.Name = "colPur_Sell";
            this.colPur_Sell.Visible = true;
            this.colPur_Sell.VisibleIndex = 6;
            this.colPur_Sell.Width = 94;
            // 
            // colPur_Qt
            // 
            this.colPur_Qt.Caption = "الكمية";
            this.colPur_Qt.FieldName = "Pur_Qt";
            this.colPur_Qt.MinWidth = 25;
            this.colPur_Qt.Name = "colPur_Qt";
            this.colPur_Qt.Visible = true;
            this.colPur_Qt.VisibleIndex = 7;
            this.colPur_Qt.Width = 94;
            // 
            // colPur_Tbuy
            // 
            this.colPur_Tbuy.Caption = "ثمن الشراء الكلي";
            this.colPur_Tbuy.FieldName = "Pur_Tbuy";
            this.colPur_Tbuy.MinWidth = 25;
            this.colPur_Tbuy.Name = "colPur_Tbuy";
            this.colPur_Tbuy.Visible = true;
            this.colPur_Tbuy.VisibleIndex = 8;
            this.colPur_Tbuy.Width = 94;
            // 
            // colPur_Tsell
            // 
            this.colPur_Tsell.Caption = "ثمن البيع الكلي";
            this.colPur_Tsell.FieldName = "Pur_Tsell";
            this.colPur_Tsell.MinWidth = 25;
            this.colPur_Tsell.Name = "colPur_Tsell";
            this.colPur_Tsell.Visible = true;
            this.colPur_Tsell.VisibleIndex = 9;
            this.colPur_Tsell.Width = 94;
            // 
            // colPur_TRev
            // 
            this.colPur_TRev.Caption = "الارباح";
            this.colPur_TRev.FieldName = "Pur_TRev";
            this.colPur_TRev.MinWidth = 25;
            this.colPur_TRev.Name = "colPur_TRev";
            this.colPur_TRev.Visible = true;
            this.colPur_TRev.VisibleIndex = 10;
            this.colPur_TRev.Width = 94;
            // 
            // pn_pur
            // 
            this.pn_pur.Controls.Add(this.gridControl1);
            this.pn_pur.Controls.Add(this.panel2);
            this.pn_pur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_pur.Location = new System.Drawing.Point(0, 0);
            this.pn_pur.Name = "pn_pur";
            this.pn_pur.Size = new System.Drawing.Size(1011, 644);
            this.pn_pur.TabIndex = 3;
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
            // FRM_PUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 644);
            this.Controls.Add(this.pn_pur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PUR";
            this.Text = "FRM_CAT";
            this.Load += new System.EventHandler(this.FRM_CAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pn_pur.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pn_pur;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public System.Windows.Forms.TextBox edt_search;
        public System.Windows.Forms.Button btn_search;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Cat;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Supp;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Buy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Sell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Tbuy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Tsell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TRev;
    }
}