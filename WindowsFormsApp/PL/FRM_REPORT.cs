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
using DevExpress.XtraReports.UI;

namespace WindowsFormsApp.PL
{
    public partial class FRM_REPORT: Form
    {
        BL.Methods methods = new BL.Methods();
        DB_SMPEntities db=new DB_SMPEntities();
        TB_CAT TB_CAT = new TB_CAT();
        int id;
        public FRM_REPORT()
        {
            InitializeComponent();
           
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

        private void btn_sell_Click(object sender, EventArgs e)
        {
            PL.XtraReport1 report = new PL.XtraReport1();
            //  report.ShowDesigner();
            report.ShowPreview();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PL.reportCustomers reportCustomers = new PL.reportCustomers();
            reportCustomers.ShowPreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.XtraReport2 report = new PL.XtraReport2();   
            report.ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.XtraReportcategory xtraReportcategory = new PL.XtraReportcategory();
            xtraReportcategory.ShowPreview();
        }
    }
}
