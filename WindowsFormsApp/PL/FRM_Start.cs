using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Web.UI.WebControls;
using DevExpress.XtraEditors;  // Make sure to include the LINQ namespace if it's not there

namespace WindowsFormsApp.PL
{
    public partial class FRM_Start : SplashScreen
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_USERS tb_user=new TB_USERS();
        PL.SignIn signIn = new PL.SignIn();
        Main main=new Main();
        public FRM_Start()
        {
            WindowsFormsSettings.LoadApplicationSettings();
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
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
    }
}