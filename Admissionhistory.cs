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
    public partial class Admissionhistory : sample2
    {
        public Admissionhistory()
        {
            InitializeComponent();
        }
        GetData gd = new GetData();

        private void frbtn_Click(object sender, EventArgs e)
        {
            tadlbl.Text = "We are processing...........    Please Wait...";
            gd.getadhistory(amdgv, d1, d2,d4, d3, d5, d6, d7, d8, d9, d10, d11,d12);
           // gd.getsumamount(paidlbl, unpailbl);
            amdgv.ClearSelection();
            stntxt.Text = "";
            button3.Visible = false;
            cellcolorcount();
            tadlbl.Text = "Total Admission  :   " + amdgv.Rows.Count.ToString("D");
        }

        private void saerchtxt_Click(object sender, EventArgs e)
        {
            gd.loadstudentbyname(stntxt);
            stntxt.Enabled = true;
            stntxt.Focus();
            button3.Visible = false;
            amdgv.ClearSelection();
        }

        private void stntxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Admissionhistory_Load(object sender, EventArgs e)
        {
            stntxt.Focus();
        }

        private void Admissionhistory_Activated(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GlobClass.idforprint > 0)
            {
                gd.getpriintid();
                PrintDoc printd = new PrintDoc();
                GlobClass.checkprint = 0;
                printd.print4page();
                GlobClass.checkprint = 1;
                GlobClass.idforprint = 0;
                amdgv.ClearSelection();
            }
        }

        private void amdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (amdgv.Rows.Count > 0)
                {
                    GlobClass.idforprint = Convert.ToInt32(amdgv.SelectedRows[0].Cells[0].Value);
                    button3.Visible = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void stntxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(stntxt.Text.Trim()))
            {

            }
            else
            {
                gd.studentinfiobyid(stntxt.Text);
                gd.getadhistorybyname(amdgv, d1, d2, d4, d3, d5, d6, d7, d8, d9, d10, d11,d12);
                amdgv.ClearSelection();
                //paidlbl.Text = "";
                //unpailbl.Text = "";
                cellcolorcount();
                tadlbl.Text = "Total Admission of "+stntxt.Text+"   :   " + amdgv.Rows.Count.ToString("D");

            }
           
        }

        private void printseting_Click(object sender, EventArgs e)
        {
            printtype pt = new printtype();
            pt.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seardatebtn_Click(object sender, EventArgs e)
        {
            tadlbl.Text = "We are processing...........    Please Wait...";
            gd.getadhistorybydate(amdgv, d1, d2, d4, d3, d5, d6, d7, d8, d9, d10, d11, d12, dtp1.Value.ToString("yyyy-MM-dd"), dtp2.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            amdgv.ClearSelection();
            paidlbl.Text = "";
            unpailbl.Text = "";
            cellcolorcount();
            tadlbl.Text = "Total Admission Between  "+dtp1.Value.ToShortDateString() +"  And  "+dtp2.Value.ToShortDateString()+"  :   " + amdgv.Rows.Count.ToString("D");
        }
        void cellcolorcount()
        {
            if (amdgv.Rows.Count > 0)
            {
                for (int i = 0; i < amdgv.Rows.Count; i++)
                {                    
                    if (Convert.ToDateTime(amdgv.Rows[i].Cells[7].Value) < DateTime.Today.Date)
                    {
                        amdgv.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

       

        private void l20adbtn_Click(object sender, EventArgs e)
        {
            tadlbl.Text = "We are processing...........    Please Wait...";
            gd.getadhistoryby20(amdgv, d1, d2, d4, d3, d5, d6, d7, d8, d9, d10, d11, d12);
            // gd.getsumamount(paidlbl, unpailbl);
            amdgv.ClearSelection();
            stntxt.Text = "";
            button3.Visible = false;
            cellcolorcount();
            tadlbl.Text = "Last 20 Admission  :   " + amdgv.Rows.Count.ToString("D");
        }

        private void rumadbtn_Click(object sender, EventArgs e)
        {
            tadlbl.Text = "We are processing...........    Please Wait...";
            gd.runingadsion(amdgv, d1, d2, d4, d3, d5, d6, d7, d8, d9, d10, d11,d12);
            amdgv.ClearSelection();
            //paidlbl.Text = "";
            //unpailbl.Text = "";
            button3.Visible = false;
            cellcolorcount();
            tadlbl.Text = "Total Running Admission  " + "  :   " + amdgv.Rows.Count.ToString("D");
        }

        private void exadbtn_Click(object sender, EventArgs e)
        {
            tadlbl.Text = "We are processing...........    Please Wait...";
            gd.expadsion(amdgv, d1, d2, d4, d3, d5, d6, d7, d8, d9, d10, d11, d12);
            amdgv.ClearSelection();
            //paidlbl.Text = "";
            //unpailbl.Text = "";
            button3.Visible = false;
            cellcolorcount();
            tadlbl.Text = "Total Expired Admission  "+"  :   " + amdgv.Rows.Count.ToString("D");
        }
    }
}
