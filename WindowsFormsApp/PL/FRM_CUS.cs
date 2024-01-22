using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using WindowsFormsApp.EPL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp.PL
{
    public partial class FRM_CUS: Form
    {
        BL.Methods methods = new BL.Methods();
        DB_SMPEntities db = new DB_SMPEntities();
        TB_CUS TB_cus = new TB_CUS();
        public int id;
        public FRM_CUS()
        {
            InitializeComponent();

           
            WindowsFormsApp.DB_SMPEntities dbContext = new WindowsFormsApp.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_CUS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl.DataSource = dbContext.TB_CUS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void FRM_CAT_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FRM_CUS_ADD fRM_CUS_ADD = new FRM_CUS_ADD();
            fRM_CUS_ADD.id = 0;
            fRM_CUS_ADD.btn_add.Text = "اضافة";
            fRM_CUS_ADD.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Diolag diolag = new Diolag();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {
                    var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        TB_cus = db.TB_CUS.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(TB_cus).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_Caption.Text = "تمت عملية الحذف";
                        toast.Show();
                        Update_data();
                    }
                }
                catch
                {
                    
                }
            }
            else
            {
                diolag.txt_Caption.Text = "لا يوجد عنصر لحذف";
                diolag.Width = this.Width;
                diolag.Show();
            }



        }

        private void Update_data()
        {
            db = new DB_SMPEntities();
            gridControl.DataSource = db.TB_CUS.ToList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Diolag diolag = new Diolag();
            FRM_CUS_ADD fRM_CUS_ADD = new FRM_CUS_ADD();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            if(id > 0)
            {

                TB_cus = db.TB_CUS.Where(x => x.ID == id).FirstOrDefault();
                fRM_CUS_ADD.edt_name.Text = TB_cus.Cus_Name.ToString();
                fRM_CUS_ADD.edt_email.Text = TB_cus.Cus_Phone.ToString();
                fRM_CUS_ADD.edt_phone.Text = TB_cus.Cus_Email.ToString();
                methods.by = TB_cus.Cus_Image;
                fRM_CUS_ADD.pic_Cover.Image = Image.FromStream(methods.Convert_image());
                fRM_CUS_ADD.id = id;
                fRM_CUS_ADD.btn_add.Text = "تعديل";
                fRM_CUS_ADD.Show();
            }
            else
            {
                diolag.txt_Caption.Text = "لا يوجد عميل لتعديل";
                diolag.Width = this.Width;
                diolag.Show();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            gridControl.DataSource = db.TB_CUS.Where(x => x.Cus_Name.Contains(_search)).ToList();
        }
    }
}
