using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.PL
{
    public partial class FRm_HOME : Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        public FRm_HOME()
        {
            InitializeComponent();
            List<TB_CAT> NumberOfCat = db.TB_CAT.ToList();
            lb_number_Cat.Text=NumberOfCat.Count.ToString();
            List<TB_Supp> NumberOfSupp = db.TB_Supp.ToList();
            lb_NUmber_Supp.Text=NumberOfSupp.Count.ToString();
            List<TB_CUS> NumberOfCus = db.TB_CUS.ToList();
            lb_Number_Cus.Text=NumberOfCus.Count.ToString();    
            List<TB_PUR> NumberOfPur = db.TB_PUR.ToList();
            lb_Number_Pur.Text=NumberOfPur.Count.ToString();
            List<TB_Sell> NumberOfSell = db.TB_Sell.ToList();
            lb_Number_Sell.Text=NumberOfSell.Count.ToString();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CAT_ADD fRM_CAT_ADD = new FRM_CAT_ADD();
            fRM_CAT_ADD.id = 0;
            fRM_CAT_ADD.btn_add.Text = "اضافة";
            fRM_CAT_ADD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_SUPP_ADD fRM_SUPP_ADD = new FRM_SUPP_ADD();
            fRM_SUPP_ADD.id = 0;
            fRM_SUPP_ADD.btn_add.Text = "المورد";
            fRM_SUPP_ADD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_PUR_ADD fRM_PUR_ADD = new FRM_PUR_ADD();
            fRM_PUR_ADD.id = 0;

            fRM_PUR_ADD.btn_add_pur.Text = "اضافة";
            fRM_PUR_ADD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_CUS_ADD fRM_CUS_ADD = new FRM_CUS_ADD();
            fRM_CUS_ADD.id = 0;
            fRM_CUS_ADD.btn_add.Text = "اضافة";
            fRM_CUS_ADD.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_SELL_ADD frm_SELL_ADD = new FRM_SELL_ADD();
            frm_SELL_ADD.id = 0;

            frm_SELL_ADD.btn_add_pur.Text = "اضافة";
            frm_SELL_ADD.Show();
        }
    }
}
