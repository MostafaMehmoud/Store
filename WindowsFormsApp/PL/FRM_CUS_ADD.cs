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
    public partial class FRM_CUS_ADD: Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_CUS tb_CUS = new TB_CUS();
        BL.Methods methods = new BL.Methods();
        FRM_CUS frm_CUS = new FRM_CUS();
        Toast toast = new Toast();
        Diolag diolag = new Diolag();
        public int id;
        
        public FRM_CUS_ADD()
        {
            InitializeComponent();
        }

        private void  btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                diolag.Width=this.Width;
                diolag.txt_Caption.Text = "اسم العميل مطلوب";
                diolag.Show();
            }
            else
            {
                if(id==0)
                {
                    pic_Cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Png);
                    tb_CUS.Cus_Name= edt_name.Text;
                    tb_CUS.Cus_Phone = edt_phone.Text;
                    tb_CUS.Cus_Email = edt_email.Text;
                    tb_CUS.Cus_Image = methods.Convert_byte();
                    db.TB_CUS.Add(tb_CUS);
                    db.SaveChanges();
                   toast.txt_Caption.Text = "تمت عملية لاضافة عميل";
                   toast.Show();
                    db = new DB_SMPEntities();
                    frm_CUS.gridControl.DataSource = db.TB_CUS.ToList();
                    this.Close();
                }
                else
                {
                    pic_Cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_CUS.ID = id;
                    tb_CUS.Cus_Name = edt_name.Text;
                    tb_CUS.Cus_Phone = edt_phone.Text;
                    tb_CUS.Cus_Email = edt_email.Text;
                    tb_CUS.ID = id;
                    tb_CUS.Cus_Image = methods.Convert_byte();
                    db.Entry(tb_CUS).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_Caption.Text = "تمت عملية التعديل بنجاح";
                  toast.Show();
                    db = new DB_SMPEntities();
                    frm_CUS.gridControl.DataSource = db.TB_CUS.ToList();
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
