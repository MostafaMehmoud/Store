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
    public partial class FRM_SELL_ADD: Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_PUR TB_pur=new TB_PUR();
        TB_Sell TB_sell=new TB_Sell();  
        TB_CAT tb_CAT=new TB_CAT();
        BL.Methods methods = new BL.Methods();
        public int id;
        double qtp,qtn,qtr;
       
        
        TB_PUR TB_PUR = new TB_PUR();
        public FRM_SELL_ADD()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
          var rs1=db.TB_PUR.Select(x=>x.Pur_Name).ToList();
          var rs2=db.TB_Supp.Select(x=>x.Supp_Name).ToList(); 
            edt_Name.DataSource = rs1;
            edt_cus.DataSource = rs2;
            AutoCompleteStringCollection ACSC1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2 = new AutoCompleteStringCollection();
            ACSC1.AddRange(rs1.ToArray());
            ACSC2.AddRange(rs2.ToArray());
            edt_Name.AutoCompleteCustomSource = ACSC1;
            edt_cus.AutoCompleteCustomSource = ACSC2;
            
        }

        private void edt_cat_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void edt_sell_EditValueChanged(object sender, EventArgs e)
        {
          //  Pro_cal();
        }

        private void edt_buy_EditValueChanged(object sender, EventArgs e)
        {
           // Pro_cal();
        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
           // Pro_cal();
        }

        private void btn_add_pur_Click(object sender, EventArgs e)
        {
           
            TB_PUR tb_Pur=new TB_PUR(); 
            Toast toast = new Toast();
            Diolag diolag = new Diolag();
            qtp = Convert.ToDouble(txt_QT.Text);
            qtr=Convert.ToDouble(edt_qt.Text);
            qtn = qtp - qtr;
            if (edt_Name.Text == "")
            {
                diolag.Width=this.Width;
                diolag.txt_Caption.Text = "اسم الوحدة مطلوبة";
                diolag.Show();
            }
            else
            {
                if (id == 0)
                {
                    if (qtn >= 0)
                    {
                        TB_sell.Sell_Name = edt_Name.Text;
                        TB_sell.Sell_Cus=edt_cus.Text;
                        TB_sell.Sell_Price =Convert.ToDouble(edt_sell.Text);
                        TB_sell.Sell_Qt=Convert.ToDouble(edt_qt.Value);
                        TB_sell.Sell_Tprice = (Convert.ToDouble(edt_sell.Text)) * (Convert.ToDouble(edt_qt.Value));
                        TB_sell.Date_Sell=DateTime.Now;
                        db.TB_Sell.Add(TB_sell);
                        TB_pur.Pur_Qt = qtr;
                        db.Entry(TB_pur).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt_Caption.Text = "تمت عملية البيع";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        messageqt.Visible = true;
                    }
                    //TB_pur.Pur_Name = edt_Name.Text;
                    //TB_pur.Pur_Type=edt_Name_cat.Text;
                    //TB_pur.Pur_Cat = edt_Name.Text;
                    //TB_pur.Pur_Supp = edt_cus.Text;
                    //TB_pur.Pur_Det=edt_details.Text;
                    //TB_pur.Pur_Buy=Convert.ToInt32(edt_buy.Value);
                    //TB_pur.Pur_Sell=Convert.ToInt32(edt_sell.Value);
                    //TB_pur.Pur_Qt=Convert.ToInt32(edt_qt.Value);
                    //TB_pur.Pur_Tbuy = Convert.ToInt32(edt_tsell.Text);
                    //TB_pur.Pur_Tsell=Convert.ToInt32(edt_tbuy.Text);
                    //TB_pur.Pur_TRev = Convert.ToInt32(edt_tcount.Text);
                    //db.TB_PUR.Add(TB_pur);
                    //db.SaveChanges();
                    //toast.txt_Caption.Text = "?? ????? ??????? ?????";
                    //toast.Show();
                    //this.Close();
                }
                else
                {
                    //TB_pur.ID = id;
                    //TB_pur.Pur_Name = edt_Name.Text;
                    //TB_pur.Pur_Type = edt_Name_cat.Text;
                    //TB_pur.Pur_Cat = edt_Name.Text;
                    //TB_pur.Pur_Supp = edt_cus.Text;
                    //TB_pur.Pur_Det = edt_details.Text;
                    //TB_pur.Pur_Buy = Convert.ToInt32(edt_buy.Value);
                    //TB_pur.Pur_Sell = Convert.ToInt32(edt_sell.Value);
                    //TB_pur.Pur_Qt = Convert.ToInt32(edt_qt.Value);
                    //TB_pur.Pur_Tbuy = Convert.ToInt32(edt_tsell.Text);
                    //TB_pur.Pur_Tsell = Convert.ToInt32(edt_tbuy.Text);
                    //TB_pur.Pur_TRev = Convert.ToInt32(edt_tcount.Text);
                    //db.Entry(TB_pur).State=System.Data.Entity.EntityState.Modified;
                    //db.SaveChanges();
                    //toast.txt_Caption.Text = "?? ????? ????? ??????";
                    //toast.Show();
                    //this.Close();

                }
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_pur = db.TB_PUR.Where(x => x.Pur_Name == edt_Name.Text).FirstOrDefault();
            txt_Buy.Text = TB_pur.Pur_Sell.ToString();
            txt_sell.Text = TB_pur.Pur_Buy.ToString();
            txt_QT.Text = TB_pur.Pur_Qt.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_CAT_ADD fRM_CAT_ADD = new FRM_CAT_ADD();
            fRM_CAT_ADD.id = 0;
            fRM_CAT_ADD.btn_add.Text = "اضافة";
            fRM_CAT_ADD.Show();
        }

        private void edt_cus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_SUPP_ADD fRM_SUPP_ADD = new FRM_SUPP_ADD();
            fRM_SUPP_ADD.id = 0;
            fRM_SUPP_ADD.btn_add.Text = "اضافة";
            fRM_SUPP_ADD.Show();
        }
        private void Pro_cal()
        {
            //sell=Convert.ToDouble(edt_sell.Value);
            //buy=Convert.ToDouble(edt_buy.Value);
            //qt=Convert.ToDouble(edt_qt.Value);
            //tsell = sell * qt;
            //tbuy=buy*qt;
            //trev=tbuy-tsell;
            //edt_tbuy.Text=tsell.ToString();
            //edt_tsell.Text=tbuy.ToString();
            //edt_tcount.Text=trev.ToString();
        }
    }
}
