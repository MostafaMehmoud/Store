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
    public partial class FRM_SUPP_ADD: Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Supp TB_SUPP = new TB_Supp();
        BL.Methods methods = new BL.Methods();
        Toast toast = new Toast();
        Diolag diolag = new Diolag();
        public int id;
        FRM_CAT FRM_CAT = new FRM_CAT();
        public FRM_SUPP_ADD()
        {
            InitializeComponent();
        }

        private void  btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                diolag.Width=this.Width;
                diolag.txt_Caption.Text = "بيانات المورد مطلوبة";
                diolag.Show();
            }
            else
            {
                if(id==0)
                {
                    pic_Cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Png);
                    TB_SUPP.Supp_Name= edt_name.Text;
                    TB_SUPP.Supp_Phone = edt_phone.Text;
                    TB_SUPP.Supp_Email = edt_email.Text;
                    TB_SUPP.Supp_Image = methods.Convert_byte();
                    db.TB_Supp.Add(TB_SUPP);
                    db.SaveChanges();
                   toast.txt_Caption.Text = "تم اضافة مورد جديد";
                   toast.Show();
                    db = new DB_SMPEntities();
                    FRM_CAT.gridControl1.DataSource = db.TB_Supp.ToList();
                    this.Close();
                }
                else
                {
                    pic_Cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    TB_SUPP.ID = id;
                    TB_SUPP.Supp_Name = edt_name.Text;
                    TB_SUPP.Supp_Phone = edt_phone.Text;
                    TB_SUPP.Supp_Email = edt_email.Text;
                    TB_SUPP.ID = id; 
                    TB_SUPP.Supp_Image = methods.Convert_byte();
                    db.Entry(TB_SUPP).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_Caption.Text = "تم التعديل بيانات المورد";
                  toast.Show();
                    db = new DB_SMPEntities();
                    FRM_CAT.gridControl1.DataSource = db.TB_Supp.ToList();
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
    }
}
