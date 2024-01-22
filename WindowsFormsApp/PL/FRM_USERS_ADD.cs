using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.EPL;

namespace WindowsFormsApp.PL
{
    public partial class FRM_USERS_ADD: Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_CUS tb_CUS = new TB_CUS();
        BL.Methods methods = new BL.Methods();
        FRM_USERS frm_users=new FRM_USERS();
        TB_USERS tb_users =new TB_USERS();
        Toast toast = new Toast();
        Diolag diolag = new Diolag();
        public int id;
        
        public FRM_USERS_ADD()
        {
            InitializeComponent();
        }

        private void  btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                diolag.Width=this.Width;
                diolag.txt_Caption.Text = "اسم المستخدم مطلوب";
                diolag.Show();
            }
            else
            {
                if(id==0)
                {
                    
                    tb_users.user_name= edt_name.Text;
                    tb_users.user_password = edt_password.Text;
                    tb_users.user_roll = edt_roll.Text;
                    tb_users.user_state = "false";
                    db.TB_USERS.Add(tb_users);
                    db.SaveChanges();
                   toast.txt_Caption.Text = "تمت اضافة مستخدم جديد";
                   toast.Show();
                    
                    this.Close();
                }
                else
                {
                    
                    tb_users.ID = id;
                    tb_users.user_name = edt_name.Text;
                    tb_users.user_password = edt_password.Text;
                    tb_users.user_roll = edt_roll.Text;
                    tb_users.user_state = "false";

                    db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_Caption.Text = "تم تعديل المستخدم";
                  toast.Show();
                   
                    this.Close();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_Cover_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FRM_USERS_ADD_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
