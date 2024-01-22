using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.EPL;

namespace WindowsFormsApp.PL
{
    public partial class SignIn : Form
    {
        DB_SMPEntities db =new DB_SMPEntities();
        TB_USERS tb_user= new TB_USERS();
        Main main=new Main();
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            Toast toast=new Toast();
            Diolag diolag = new Diolag();
            if (username.Text == "" || edt_password.Text == "")
            {
                diolag.Width=this.Width;
                diolag.txt_Caption.Text = "رقم السر و اسم المستخدم مطلوب";
                diolag.Show();
            }
            else
            {
                tb_user=db.TB_USERS.Where(x=>x.user_name==username.Text && x.user_password==edt_password.Text).FirstOrDefault();
                if(tb_user != null)
                {
                    tb_user.user_state = "True";
                    db.Entry(tb_user).State=System.Data.Entity.EntityState.Modified;
                    main.lb_mainusername.Text = tb_user.user_name;
                    main.lb_roll.Text = tb_user.user_roll;
                    main.Enabled = true;
                    db.SaveChanges();
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("login faild");
                }
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
