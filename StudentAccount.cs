using PLMS.All_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMS
{
    public partial class StudentAccount : sample
    {
        public StudentAccount()
        {
            InitializeComponent();
        }
        GetData gd = new GetData();
        
        private void checkbtn_Click(object sender, EventArgs e)
        {
            gd.loadstudent(srtxt, snrdbtn, sidrbtn, smrbbtn);
            srtxt.Enabled = true;
            srtxt.Focus();
            sidrbtn.Checked = true;
        }

        private void srtxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
            catch
            {
            }
        }

        private void srtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(srtxt.Text.Trim()))
            {
                clearcon();
                GlobClass.sid = 0;
                Maincalss.CDGVR(paiddgv);
                Maincalss.CDGVR(dgvsinfo);
                planamountlbl.Text = "0.00";tpamlbl.Text = "0.00";tuamlbl.Text = "0.00";
            }
        }
        void cellcolorcountexpire()
        {
            if (dgvsinfo.Rows.Count > 0)
            {
                for (int i = 0; i < dgvsinfo.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dgvsinfo.Rows[i].Cells[2].Value) < DateTime.Today.Date)
                    {
                        dgvsinfo.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void srtxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(srtxt.Text.Trim()))
            {
                clearcon();
                GlobClass.sid = 0;
                
            }
            else
            {
                if (sidrbtn.Checked == true)
                {
                    gd.studentIDinfiobyname(srtxt.Text.Trim());
                    gd.getall(sidlbl, nlbl, molbl, adlbl, pnlbl, durlbl, expirdtlbl, remlbl, fnlbl,studentpic);
                   // changecloleor();
                    checkexpire();
                    gd.getstaccount(dgvsinfo, d1, d2, d3, d4, d5, d6,d7);
                    dgvsinfo.ClearSelection();
                    gd.getsumst(tpamlbl, tuamlbl, planamountlbl);
                    cellcolorcount();
                    cellcolorcountexpire();
                }
                else if (snrdbtn.Checked == true)
                {
                    gd.studentinfiobyid(srtxt.Text.Trim());
                    gd.getall(sidlbl, nlbl, molbl, adlbl, pnlbl, durlbl, expirdtlbl, remlbl, fnlbl, studentpic);
                    //changecloleor();
                    checkexpire();
                    gd.getstaccount(dgvsinfo, d1, d2, d3, d4, d5, d6,d7);
                    dgvsinfo.ClearSelection();
                    gd.getsumst(tpamlbl, tuamlbl, planamountlbl);
                    cellcolorcount();
                    cellcolorcountexpire();
                }
                else if (smrbbtn.Checked == true)
                {
                    gd.studentIDinfiobymobile(srtxt.Text.Trim());
                    gd.getall(sidlbl, nlbl, molbl, adlbl, pnlbl, durlbl, expirdtlbl, remlbl, fnlbl, studentpic);
                   // changecloleor();
                    checkexpire();
                    gd.getstaccount(dgvsinfo, d1, d2, d3, d4, d5, d6,d7);
                    dgvsinfo.ClearSelection();
                    gd.getsumst(tpamlbl, tuamlbl,planamountlbl);
                    cellcolorcount();
                    cellcolorcountexpire();
                }
                
            }
        }
        void cellcolorcount()
        {
            if(dgvsinfo.Rows.Count>0)
            {
                for (int i = 0; i < dgvsinfo.Rows.Count; i++)
                {
                    int sum = Convert.ToInt32(dgvsinfo.Rows[i].Cells[5].Value);
                    if (sum > 0)
                    {
                        dgvsinfo.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                    }
                }
            }
        }
        void changecloleor()
        {
            try
            {

                if (Convert.ToInt32(remlbl.Text) == 0)
                {
                    remlbl.Text = "Full Paid";
                    remlbl.BackColor = Color.ForestGreen;
                    remlbl.ForeColor = Color.White;
                    remlbl.Visible = true;
                    
                }
                else if (Convert.ToInt32(remlbl.Text) > 0)
                {
                    remlbl.Text = "Unpaid Amount : " + remlbl.Text.ToString();
                    remlbl.BackColor = Color.IndianRed;
                    remlbl.ForeColor = Color.White;
                    remlbl.Visible = true;
                }

                else if (remlbl.Text == "")
                {

                }
            }
            catch (Exception)
            {

            }

        }
        void checkexpire()
        {
            try
            {
                TimeSpan ts = Convert.ToDateTime(expirdtlbl.Text) - DateTime.Today;
                double t = ts.TotalDays;
                if (t > 7)
                {
                    timeleftlbl.Text = "Remaining Time is : " + t.ToString("0") + " Days";
                    timeleftlbl.BackColor = Color.ForestGreen;
                    timeleftlbl.ForeColor = Color.White;
                    timeleftlbl.Visible = true;
                    expirdtlbl.Text = "Expire On : " + expirdtlbl.Text.ToString();
                }
                else if (t < 7 && t >= 0)
                {
                    timeleftlbl.Text = "Remaining Time is : " + t.ToString("0") + " Days";
                    timeleftlbl.BackColor = Color.IndianRed;
                    timeleftlbl.ForeColor = Color.White;
                    timeleftlbl.Visible = true;
                    expirdtlbl.Text = "Expire On : " + expirdtlbl.Text.ToString();
                }
                else if (t < 0)
                {
                    timeleftlbl.Text = "Plan has been expired !!! ";
                    timeleftlbl.BackColor = Color.IndianRed;
                    timeleftlbl.ForeColor = Color.White;
                    timeleftlbl.Visible = true;
                    expirdtlbl.Text = "Expire On : " + expirdtlbl.Text.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
        void clearcon()
        {
            studentpic.Image = null;
            sidlbl.Text = "";
            nlbl.Text = "";
            molbl.Text = "";
            fnlbl.Text = "";
            adlbl.Text = "";
            pnlbl.Text = "";
            durlbl.Text = "";
            expirdtlbl.Text = "";
            remlbl.Text = "";
            timeleftlbl.Text = "";
            remlbl.Visible = false;
            timeleftlbl.Visible=false;
        }

        private void snrdbtn_CheckedChanged(object sender, EventArgs e)
        {
            srtxt.Text = "";
            gd.loadstudent(srtxt, snrdbtn, sidrbtn, smrbbtn);
            srtxt.Focus();
            Maincalss.CDGVR(paiddgv);
            Maincalss.CDGVR(dgvsinfo);
            planamountlbl.Text = "0.00"; tpamlbl.Text = "0.00"; tuamlbl.Text = "0.00";
            trstablelayout.Visible = false;
            printbtn.Visible = false;
        }

        private void sidrbtn_CheckedChanged(object sender, EventArgs e)
        {
            srtxt.Text = "";
            gd.loadstudent(srtxt, snrdbtn, sidrbtn, smrbbtn);
            srtxt.Focus();
            Maincalss.CDGVR(paiddgv);
            Maincalss.CDGVR(dgvsinfo);
            planamountlbl.Text = "0.00"; tpamlbl.Text = "0.00"; tuamlbl.Text = "0.00";
            trstablelayout.Visible = false;
            printbtn.Visible = false;
        }

        private void smrbbtn_CheckedChanged(object sender, EventArgs e)
        {
            srtxt.Text = "";
            gd.loadstudent(srtxt, snrdbtn, sidrbtn, smrbbtn);
            srtxt.Focus();
            Maincalss.CDGVR(paiddgv);
            Maincalss.CDGVR(dgvsinfo);
            planamountlbl.Text = "0.00"; tpamlbl.Text = "0.00"; tuamlbl.Text = "0.00";
            trstablelayout.Visible = false;
            printbtn.Visible = false;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Menuboard dsb = new Menuboard();
            Maincalss.showwindow(dsb, MDI.ActiveForm);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            clearcon();
        }

        private void paytxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
            catch
            {
            }
        }
        int p2, pamnt;
        int adid2;
        private void dgvsinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsinfo.Rows.Count > 0)
            {
                try
                {                   
                   int sum = Convert.ToInt32(dgvsinfo.SelectedRows[0].Cells[5].Value);
                   if (sum > 0)
                   {
                        trstablelayout.Visible = true;
                        GlobClass.adid = Convert.ToInt32(dgvsinfo.SelectedRows[0].Cells[0].Value);
                        trsidlbl.Text = GlobClass.adid.ToString();
                        planamtlbl.Text= dgvsinfo.SelectedRows[0].Cells[3].Value.ToString();
                        balancelbl.Text = dgvsinfo.SelectedRows[0].Cells[4].Value.ToString();
                        unitupamlbl.Text = dgvsinfo.SelectedRows[0].Cells[5].Value.ToString();
                        pamnt = Convert.ToInt32(dgvsinfo.SelectedRows[0].Cells["d5"].Value.ToString());
                        p2= Convert.ToInt32(dgvsinfo.SelectedRows[0].Cells[5].Value.ToString());
                        paytxt.Focus();
                        //balancelbl.Text = "0";
                        paytxt.Text = "";
                    }
                    else
                    {
                        trstablelayout.Visible = false;
                        
                    }
                    adid2 = Convert.ToInt32(dgvsinfo.SelectedRows[0].Cells[0].Value);
                    GlobClass.idforprint= Convert.ToInt32(dgvsinfo.SelectedRows[0].Cells[0].Value);
                    gd.getpaidamnt(adid2,paiddgv, dg2, dg1);
                    paiddgv.ClearSelection();
                    plantypelbl.Text = dgvsinfo.SelectedRows[0].Cells[1].Value.ToString();
                    printbtn.Visible = true;
                }
                catch (Exception)
                {

                }
            }
        }
        double p1,p3,p4;

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (GlobClass.idforprint > 0)
            {
                GetData gd = new GetData();
                gd.getpriintid();
                PrintDoc printd = new PrintDoc();
                GlobClass.checkprint = 0;
                printd.print4page();
                GlobClass.checkprint = 1;
                GlobClass.idforprint = 0;                
                printbtn.Visible = false;
            }
        }

        private void paytxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paytxt.Text.Trim()))
            {
                p1 = 0;
            }
            else
            {
                p1 = Convert.ToDouble(paytxt.Text);               
                p3 = p2 - p1;                
                p4 = pamnt + p1;               
            }
            
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(paytxt.Text) <= Convert.ToInt32(unitupamlbl.Text))
            {
                if (GlobClass.adid > 0)
                {
                    Updatedata ud = new Updatedata();
                    SaveClass sc = new SaveClass();
                    ud.updatepayment(GlobClass.adid, p3,p4);
                    sc.savepaid(Convert.ToDecimal(paytxt.Text), GlobClass.adid);
                    gd.getstaccount(dgvsinfo, d1, d2, d3, d4, d5, d6,d7);
                    dgvsinfo.ClearSelection();
                    gd.getsumst(tpamlbl, tuamlbl, planamountlbl);
                    cellcolorcount();
                    trstablelayout.Visible = false;
                    balancelbl.Text = "0";
                    paytxt.Text = "";
                    gd.getpaidamnt(GlobClass.adid, paiddgv, dg2, dg1);
                    paiddgv.ClearSelection();
                    printbtn.Visible = false;
                }
                
            }
            else
            {
                MessageBox.Show("Unpaid Amount = "+ Convert.ToInt32(unitupamlbl.Text)+"\n\nPay Amount = "+ Convert.ToInt32(paytxt.Text) + "\n\n\nYou can not pay more than UNPAID AMOUNT","Exceeding payment",MessageBoxButtons.OK,MessageBoxIcon.Information);
                paytxt.Text = unitupamlbl.Text;
                paytxt.Focus();
                paytxt.SelectAll();
            }
        }
        
    }
}
