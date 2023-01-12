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
    public partial class AdmissionForm : sample2
    {
        public AdmissionForm()
        {
            InitializeComponent();
        }
        GetData gd = new GetData();
        loadcombo lc = new loadcombo();
        SaveClass sc = new SaveClass();
        PrintDoc printd = new PrintDoc();
        private void stnamerb_CheckedChanged(object sender, EventArgs e)
        {
           // gd.loadstudent(textBox1, stnamerb, sttidrb, stmobilerb);
            gd.loadstudent(textBox1, stnamerb, sttidrb, stmobilerb);
            lc.loadcb(cb1);
            Maincalss.ResetEnable(rp);
            textBox1.Focus();
        }

        private void sttidrb_CheckedChanged(object sender, EventArgs e)
        {
            gd.loadstudent(textBox1, stnamerb, sttidrb, stmobilerb);
            lc.loadcb(cb1);
            Maincalss.ResetEnable(rp);
            textBox1.Focus();
        }

        private void stmobilerb_CheckedChanged(object sender, EventArgs e)
        {
            gd.loadstudent(textBox1, stnamerb, sttidrb, stmobilerb);
            lc.loadcb(cb1);
            Maincalss.ResetEnable(rp);
            textBox1.Focus();
        }

        private void AdmissionForm_Activated(object sender, EventArgs e)
        {
           
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            stnamerb.Checked = true;
            gd.loadstudent(textBox1, stnamerb, sttidrb, stmobilerb);
           
            lc.loadcb(cb1);
            textBox1.Focus();
            Maincalss.Enable(panel3);
            Maincalss.Enable(lp);
            validfromdt.Value = DateTime.Today;
            validupto.Value = DateTime.Today;
            validfromdt.Enabled = true;
            validupto.Enabled = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                stpck.Image = null;
                namelbl.Text = "Name";
                sidlbl.Text = "Student ID";
                mobilelbl.Text = "Mobile";
                fnlbl.Text = "Father's Name";
                GlobClass.sid = 0;
            }
            else
            {
                if (stnamerb.Checked == true)
                {
                    gd.studentinfio(textBox1.Text.Trim(), namelbl, sidlbl, mobilelbl, fnlbl,stpck);
                }
                else if (sttidrb.Checked == true)
                {
                    gd.studentinfio1(textBox1.Text.Trim(), namelbl, sidlbl, mobilelbl, fnlbl, stpck);
                }
                else if (stmobilerb.Checked == true)
                {
                    gd.studentinfio2(textBox1.Text.Trim(), namelbl, sidlbl, mobilelbl, fnlbl, stpck);
                }


            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lc.selectplan(cb1, planamounttxt, Timing, durlbl);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                stpck.Image = null;
                namelbl.Text = "Name";
                sidlbl.Text = "Student ID";
                mobilelbl.Text = "Mobile";
                fnlbl.Text = "Father's Name";
                GlobClass.sid = 0;
            }
        }

        private void validupto_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = validupto.Value - validfromdt.Value;
            double t = ts.TotalDays;
            datelbl.Text = "Valid For : " + t.ToString("0") + " Days";

            DateTime dt1 = validfromdt.Value;
        }

        private void paidamounttxtx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paidamounttxtx.Text.Trim()))
            {
               
            }
            else
            {
                double dd = Convert.ToDouble(planamounttxt.Text) - Convert.ToDouble(paidamounttxtx.Text);
                unpaidamounttxt.Text = dd.ToString();
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (GlobClass.sid > 0 && GlobClass.pid > 0 && paidamounttxtx.Text != "" && unpaidamounttxt.Text != "")
            {
                sc.adm(GlobClass.sid, GlobClass.pid, validfromdt.Value.Date, validupto.Value.Date, Convert.ToDecimal(planamounttxt.Text), Convert.ToDecimal(paidamounttxtx.Text), Convert.ToDecimal(unpaidamounttxt.Text), cb1.Text, datelbl.Text, Timing.Text, Convert.ToDecimal(paidamounttxtx.Text));                
                clearcon();
                gd.getpriintid();
                GlobClass.checkprint = 1;
                printd.print4page();
                GlobClass.checkprint = 0;
            }
            else { Maincalss.ShowMasseg("All Fields are mandatory", "Error"); }
            
        }
        void clearcon()
        {            
            cb1.Text = "";
            validfromdt.Value = DateTime.Today;
            validupto.Value = DateTime.Today;
            //validfromdt.Enabled = false;
            //validupto.Enabled = false;           
            //stpck.Image = null;
            namelbl.Text = "Name";
            sidlbl.Text = "Student ID";
            mobilelbl.Text = "Mobile";
            fnlbl.Text = "Father's Name";
            GlobClass.sid = 0;
            GlobClass.pid = 0;
            datelbl.Text = "";
            Timing.Text = "Plan Time";
            durlbl.Text = "Plan Duration";
            unpaidamounttxt.Text = "0";
            textBox1.Focus();
            textBox1.Text = "";
            planamounttxt.Text = "";
            paidamounttxtx.Text = "";
        }

        private void planamounttxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(planamounttxt.Text.Trim()))
            {
               
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
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

        private void cb1_KeyDown(object sender, KeyEventArgs e)
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

        private void validfromdt_KeyDown(object sender, KeyEventArgs e)
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

        private void validupto_KeyDown(object sender, KeyEventArgs e)
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

        private void planamounttxt_KeyDown(object sender, KeyEventArgs e)
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

        private void paidamounttxtx_KeyDown(object sender, KeyEventArgs e)
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

        private void printseting_Click(object sender, EventArgs e)
        {
            printtype pt = new printtype();
            pt.ShowDialog();
        }

        private void cb1_Leave(object sender, EventArgs e)
        {
            validfromdt.Focus();
        }

        private void planamounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void paidamounttxtx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void paidamounttxtx_Leave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(paidamounttxtx.Text.Trim()) > Convert.ToInt32(planamounttxt.Text.Trim()))
            {
                MessageBox.Show("Plan Amount : "+planamounttxt.Text+"\n\n"+"Paid Amount : "+paidamounttxtx.Text+"\n\n"+"You can not pay more than plan amount...","Payment can't be exceed !!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                paidamounttxtx.Focus();
                paidamounttxtx.Text = "";
                unpaidamounttxt.Text = "0";
            }
        }

        private void AdmissionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
