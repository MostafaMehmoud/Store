using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.PL;

namespace WindowsFormsApp
{
    public partial class Main : Form
    {
        PL.FRm_HOME frm_home = new PL.FRm_HOME();
        PL.FRM_CAT frm_cat = new PL.FRM_CAT();
        PL.FRM_SUPP frm_SUPP = new PL.FRM_SUPP();
        PL.FRM_PUR FRM_PUR = new PL.FRM_PUR();
        PL.FRM_CUS frm_CUS = new PL.FRM_CUS();
        PL.FRM_SELL frm_SELL = new PL.FRM_SELL();
        PL.FRM_REPORT frm_report = new PL.FRM_REPORT();
        PL.FRM_USERS frm_users= new PL.FRM_USERS();
        PL.Designer designer = new PL.Designer();   

        TB_USERS tb_user = new TB_USERS();
        PL.setteing set = new PL.setteing();
        DB_SMPEntities db=new DB_SMPEntities();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pn_topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        //close app on click
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //min app
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //max app
        private void btn_max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState=FormWindowState.Normal;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        //collapse app
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if(pn_navbar.Width==250 )
            {
                pn_navbar.Width = 50;
                pn_titlenvar.Visible = false;
                pn_headernavbar.Height = 200;
            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenvar.Visible = true;
                pn_headernavbar.Height = 237;

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //button main الرئيسية

       

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
        //button main الرئيسية
        //load home page
        private void btn_main_Click(object sender, EventArgs e)
        {
            
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
            Ib_titlepage.Text = "الرئيسية";
            if (lb_roll.Text != "مدير")
            {
                btn_users.Enabled = false;
                btn_Report.Enabled = false;
            }
            else
            {
                btn_users.Enabled = true;
                btn_Report.Enabled = true;
            }
        }
        //load cat page
        private void btn_cat_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);
            Ib_titlepage.Text = "الاصناف";
            db = new DB_SMPEntities();
            frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_SUPP.pn_supp);
            db = new DB_SMPEntities();
            Ib_titlepage.Text = "الموردين";
        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_PUR_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(FRM_PUR.pn_pur);
            db = new DB_SMPEntities();
            Ib_titlepage.Text = "المشتريات";
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_CUS.pn_cus);
            db = new DB_SMPEntities();
            Ib_titlepage.Text = "العملاء";
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_SELL.pn_sell);
            db = new DB_SMPEntities();
            Ib_titlepage.Text = "المبيعات";
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.pn_report);
           
            Ib_titlepage.Text = "التقارير";
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_users.pn_user);

            Ib_titlepage.Text = "المستخدمين";
        }

        private void btn_setteing_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(set.pn_set);

            Ib_titlepage.Text = "الاعددات";
        }

        private void btn_loginout_Click(object sender, EventArgs e)
        {
            PL.SignIn sign= new PL.SignIn();
            tb_user = db.TB_USERS.Where(x => x.user_state=="True").FirstOrDefault();
            tb_user.user_state = "False";
            db.Entry(tb_user).State =System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            this.Enabled = false;
            sign.Show();
            this.Hide();
        }

        private void btn_developer_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(designer.pn_developer);

            Ib_titlepage.Text = "المصمم";
        }
    }
}
