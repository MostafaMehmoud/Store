using DevExpress.XtraBars.Docking.Paint;
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
    public partial class FRM_PUR_ADD: Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_PUR TB_pur=new TB_PUR();
        BL.Methods methods = new BL.Methods();
        public int id;
        double buy, sell, qt, tbuy, tsell, trev;
       
        
        TB_PUR TB_PUR = new TB_PUR();
        public FRM_PUR_ADD()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
          edt_cat.DataSource=db.TB_CAT.Select(x=>x.CAT_name).ToList();
            edt_supp.DataSource=db.TB_Supp.Select(x=>x.Supp_Name).ToList(); 
        }

        private void edt_cat_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void edt_sell_EditValueChanged(object sender, EventArgs e)
        {
            Pro_cal();
        }

        private void edt_buy_EditValueChanged(object sender, EventArgs e)
        {
            Pro_cal();
        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            Pro_cal();
        }

        private void btn_add_pur_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Diolag diolag = new Diolag();
            if (edt_Name.Text == "")
            {
                diolag.Width=this.Width;
                diolag.txt_Caption.Text = "اسم المشتري مطلوب";
                diolag.Show();
            }
            else
            {
                if (id == 0)
                {
                    TB_pur.Pur_Name = edt_Name.Text;
                    TB_pur.Pur_Type=edt_Name_cat.Text;
                    TB_pur.Pur_Cat = edt_cat.Text;
                    TB_pur.Pur_Supp = edt_supp.Text;
                    TB_pur.Pur_Det=edt_details.Text;
                    TB_pur.Pur_Buy=Convert.ToInt32(edt_buy.Value);
                    TB_pur.Pur_Sell=Convert.ToInt32(edt_sell.Value);
                    TB_pur.Pur_Qt=Convert.ToInt32(edt_qt.Value);
                    TB_pur.Pur_Tbuy = Convert.ToInt32(edt_tbuy.Text);
                    TB_pur.Pur_Tsell=Convert.ToInt32(edt_tsell.Text);
                    TB_pur.Pur_TRev = Convert.ToInt32(edt_trev.Text);
                    db.TB_PUR.Add(TB_pur);
                    db.SaveChanges();
                    toast.txt_Caption.Text = "تم اجراء العملية بنجاح";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    TB_pur.ID = id;
                    TB_pur.Pur_Name = edt_Name.Text;
                    TB_pur.Pur_Type = edt_Name_cat.Text;
                    TB_pur.Pur_Cat = edt_cat.Text;
                    TB_pur.Pur_Supp = edt_supp.Text;
                    TB_pur.Pur_Det = edt_details.Text;
                    TB_pur.Pur_Buy = Convert.ToInt32(edt_buy.Value);
                    TB_pur.Pur_Sell = Convert.ToInt32(edt_sell.Value);
                    TB_pur.Pur_Qt = Convert.ToInt32(edt_qt.Value);
                    TB_pur.Pur_Tbuy = Convert.ToInt32(edt_tbuy.Text);
                    TB_pur.Pur_Tsell = Convert.ToInt32(edt_tsell.Text);
                    TB_pur.Pur_TRev = Convert.ToInt32(edt_trev.Text);
                    db.Entry(TB_pur).State=System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_Caption.Text = "تم تعديل عملية الشراء";
                    toast.Show();
                    this.Close();

                }
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_CAT_ADD fRM_CAT_ADD = new FRM_CAT_ADD();
            fRM_CAT_ADD.id = 0;
            fRM_CAT_ADD.btn_add.Text = "اضافة";
            fRM_CAT_ADD.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_SUPP_ADD fRM_SUPP_ADD = new FRM_SUPP_ADD();
            fRM_SUPP_ADD.id = 0;
            fRM_SUPP_ADD.btn_add.Text = "المورد";
            fRM_SUPP_ADD.Show();
        }
        private void Pro_cal()
        {
            sell=Convert.ToDouble(edt_sell.Value);
            buy=Convert.ToDouble(edt_buy.Value);
            qt=Convert.ToDouble(edt_qt.Value);
            tsell = sell * qt;
            tbuy=buy*qt;
            trev=tbuy-tsell;
            edt_tsell.Text=tsell.ToString();
            edt_tbuy.Text=tbuy.ToString();
            edt_trev.Text=trev.ToString();
        }
    }
}
