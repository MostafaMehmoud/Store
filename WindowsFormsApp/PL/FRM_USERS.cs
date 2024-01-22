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
    public partial class FRM_USERS: Form
    {
        BL.Methods methods = new BL.Methods();
        DB_SMPEntities db = new DB_SMPEntities();
        TB_USERS tb_USERS= new TB_USERS();
        public int id;
        public FRM_USERS()
        {
            InitializeComponent();

          
            WindowsFormsApp.DB_SMPEntities dbContext = new WindowsFormsApp.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_USERS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_USERS.Local.ToBindingList();
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
            FRM_USERS_ADD fRM_USERS_ADD = new FRM_USERS_ADD();
            fRM_USERS_ADD.id = 0;
            
            fRM_USERS_ADD.btn_add.Text = "اضافة";
            fRM_USERS_ADD.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Diolag diolag = new Diolag();
           id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {
                    var rs = MessageBox.Show("عملية حذف", "تم حذف المستخدم", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        tb_USERS = db.TB_USERS.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_USERS).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_Caption.Text = "تم حذف المستخدم";
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
                diolag.txt_Caption.Text = "لا يوجد مستخدم لحذفه";
                diolag.Width = this.Width;
                diolag.Show();
            }



        }

        private void Update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_USERS.ToList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Diolag diolag = new Diolag();
            FRM_USERS_ADD frm_user_add= new FRM_USERS_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {

                tb_USERS = db.TB_USERS.Where(x => x.ID == id).FirstOrDefault();
                frm_user_add.edt_name.Text = tb_USERS.user_name;
                frm_user_add.edt_password.Text=tb_USERS.user_password;
                frm_user_add.edt_roll.Text= tb_USERS.user_roll;
                frm_user_add.btn_add.Text = "تعديل";
                frm_user_add.id = id;
                frm_user_add.Show();
            }
            else
            {
                diolag.txt_Caption.Text = "لا يوجد مستخدم لتعديل";
                diolag.Width = this.Width;
                diolag.Show();
            }
        }

            private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            gridControl1.DataSource = db.TB_USERS.Where(x => x.user_name.Contains(_search)).ToList();
        }
    }
}
