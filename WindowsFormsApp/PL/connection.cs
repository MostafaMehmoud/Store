using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.PL
{
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var mysever = "DESKTOP-KADFQJ9\\\\SQL2022";
            const string qu = "\"";
            var sv = edt_svr.Text;
            var connstr = @"metadata=res://*/SMPM.csdl|res://*/SMPM.ssdl|res://*/SMPM.msl;provider=System.Data.SqlClient;provider connection string="+qu+";data source="+sv+";initial catalog=DB_SMP;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework\";";
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
