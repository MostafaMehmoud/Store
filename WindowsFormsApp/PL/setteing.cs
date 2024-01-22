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
using System.Configuration;

namespace WindowsFormsApp.PL
{
    public partial class setteing : Form
    {
        BL.Methods methods = new BL.Methods();
        DB_SMPEntities db=new DB_SMPEntities();
        TB_CAT TB_CAT = new TB_CAT();
        int id;
        public setteing()
        {
            InitializeComponent();
           
        }

       

        private void save_Click_1(object sender, EventArgs e)
        {
            var mysever = "DESKTOP-KADFQJ9\\\\SQL2022";
            const string qu = "\"";
            var sv = edt_svr.Text;
            var connstr = @"metadata=res://*/SMPM.csdl|res://*/SMPM.ssdl|res://*/SMPM.msl;provider=System.Data.SqlClient;provider connection string=" + qu + ";data source=" + sv + ";initial catalog=DB_SMP;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework\";";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString = connstr;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var strl = config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString;
            MessageBox.Show(strl);
            Application.Restart();
        }
    }
}
