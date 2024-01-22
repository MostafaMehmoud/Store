using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
namespace WindowsFormsApp.PL
{
    public partial class FRM_satrt : SplashScreen
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_USERS tb_user = new TB_USERS();
        PL.SignIn signIn = new PL.SignIn();
        Main main = new Main();
        public FRM_satrt()
        {
            InitializeComponent();
            //this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_user = db.TB_USERS.Where(x => x.user_state == "True").FirstOrDefault();
            if (tb_user != null)
            {
                main.lb_mainusername.Text = tb_user.user_name;
                main.lb_roll.Text = tb_user.user_roll;
                main.Show();
            }
            else
            {
                signIn.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        //private async void FRM_satrt_Load(object sender, EventArgs e)

        //{
        //    var state = await Task.Run(() =>  check());
        //    if (state == true)
        //    {
        //        Main main = new Main();
        //        main.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("خطا في الاتصال");
        //    }
        //}
        //private bool check()
        //{
        //    try
        //    {
        //        DB_SMPEntities db=new DB_SMPEntities();
        //        var list=db.TB_USERS.ToList();
        //        if(list != null)
        //        {
        //            return true;
        //        }else { return false; }

        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}