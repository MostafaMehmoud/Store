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
    public partial class FRM_CAT_ADD : Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_CAT TB_CAT = new TB_CAT();
        BL.Methods methods = new BL.Methods();
        Toast toast = new Toast();
        Diolag diolag = new Diolag();
        public int id;
        FRM_CAT FRM_CAT = new FRM_CAT();
        public FRM_CAT_ADD()
        {
            InitializeComponent();
        }

        private void  btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                diolag.Width=this.Width;
                diolag.txt_Caption.Text = "اسم الصنف مطلوب";
                diolag.Show();
            }
            else
            {
                if(id==0)
                {
                    pic_Cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Jpeg);
                    TB_CAT.CAT_name = edt_name.Text;
                    TB_CAT.CAT_cover = methods.Convert_byte();
                    db.TB_CAT.Add(TB_CAT);
                    db.SaveChanges();
                   toast.txt_Caption.Text = "تم اضافة صنف جديد";
                   toast.Show();
                    db = new DB_SMPEntities();
                    FRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();
                }
                else
                {
                    pic_Cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    TB_CAT.CAT_name = edt_name.Text;
                    TB_CAT.ID = id; 
                    TB_CAT.CAT_cover = methods.Convert_byte();
                    db.Entry(TB_CAT).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_Caption.Text = "تم تعديل صنف جديد";
                  toast.Show();
                    db = new DB_SMPEntities();
                    FRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
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
    }
}
