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
    public partial class Expenses : sample2
    {
        public Expenses()
        {
            InitializeComponent();
        }
        public int Save;
        public int expid;
        GetData gd = new GetData();
        SaveClass sc = new SaveClass();
        Updatedata ud = new Updatedata();
        Deletedata dd = new Deletedata();
        loadcombo lc = new loadcombo();
        private void crextypebtn_Click(object sender, EventArgs e)
        {
            CreatExpenses ce = new CreatExpenses();
            Maincalss.showwindow(ce, MDI.ActiveForm);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Save = 0;
            Maincalss.ResetEnable(lp);
            lc.loadexcb(excb);
            excb.Focus();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if(excb.Text== "" && expricetxt.Text == "" && qytextxt.Text=="" && tpextxt.Text=="")
            {
                Maincalss.ShowMasseg("Please double click on plan to select", "Error");
            }
            else
            {
                Save = 1;
                Maincalss.Enable(lp);
                excb.Enabled = false;
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (expid > 0)
            {
                DialogResult dr = MessageBox.Show("Do you sure to delete ?", "Delete conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    dd.delnewexpense(expid);
                    gd.getnewexpensetop20(newexdgv, p0, p1, p2, p3, p4, p5, p6);
                    newexdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    expid = 0;
                    gd.gettotlaex(totalexplbl);
                }
                else
                {
                    newexdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    expid = 0;
                }
            }
            else { MessageBox.Show("Please select the row to detele", "Row not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            gd.getnewexpense(newexdgv, p0,p1,p2,p3,p4,p5,p6);
            newexdgv.ClearSelection();
            Maincalss.ResetDisable(lp);
            gd.gettotlaex(totalexplbl);
        }

        private void Expenses_Activated(object sender, EventArgs e)
        {
            
        }

        private void excb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maincalss.Reset(lp);
            lc.selectexpense(excb, expricetxt,declable);
           
        }

        private void excb_KeyDown(object sender, KeyEventArgs e)
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

        private void expricetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void qytextxt_KeyDown(object sender, KeyEventArgs e)
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

        private void tpextxt_KeyDown(object sender, KeyEventArgs e)
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

        private void edectxt_KeyDown(object sender, KeyEventArgs e)
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

        private void expricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void qytextxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tpextxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void savrbtn_Click(object sender, EventArgs e)
        {
            if (excb.Text != "" && expricetxt.Text != "" && qytextxt.Text != "" && tpextxt.Text != "")
            {
                if (Save == 0)// Insert Operation
                {
                    sc.newexpense(excb.Text, Convert.ToDecimal(expricetxt.Text), Convert.ToInt32(qytextxt.Text), Convert.ToDecimal(tpextxt.Text),edectxt.Text, exdatetime.Value.ToShortDateString());
                    gd.getnewexpensetop20(newexdgv, p0,p1,p2,p3,p4,p5,p6);
                    newexdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    gd.gettotlaex(totalexplbl);
                }
                else if (Save == 1)// UPdate Operation
                {
                    ud.updatenewexpense(expid, excb.Text, Convert.ToDecimal(expricetxt.Text), Convert.ToInt32(qytextxt.Text), Convert.ToDecimal(tpextxt.Text), edectxt.Text, exdatetime.Value.ToShortDateString());
                    expid = 0;
                    gd.getnewexpensetop20(newexdgv, p0, p1, p2, p3, p4, p5, p6);
                    newexdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    gd.gettotlaex(totalexplbl);
                }
            }
            else { Maincalss.ShowMasseg("All fields are manatory", "Error"); }
        }

        private void newexdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newexdgv.Rows.Count > 0)
                {
                    expid = Convert.ToInt32(newexdgv.SelectedRows[0].Cells[0].Value);
                    excb.Text= newexdgv.SelectedRows[0].Cells[1].Value.ToString();
                    expricetxt.Text = newexdgv.SelectedRows[0].Cells[2].Value.ToString();
                    qytextxt.Text = newexdgv.SelectedRows[0].Cells[3].Value.ToString();
                    tpextxt.Text = newexdgv.SelectedRows[0].Cells[4].Value.ToString();
                    edectxt.Text = newexdgv.SelectedRows[0].Cells[5].Value.ToString();
                    exdatetime.Value = Convert.ToDateTime(newexdgv.SelectedRows[0].Cells[6].Value.ToString());
                    Maincalss.Disable(lp);
                    
                }
            }
            catch (Exception)
            {
                Maincalss.ShowMasseg("Select row properly to UPDATE OR DELETE row", "Error");
            }
        }

        private void exdatetime_KeyDown(object sender, KeyEventArgs e)
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

        private void qytextxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qytextxt.Text.Trim()))
            {
                tpextxt.Text = "";
            }
            else
            {
                int a = Convert.ToInt32(expricetxt.Text);
                int b = Convert.ToInt32(qytextxt.Text);
                int c = a * b;
                tpextxt.Text = c.ToString();
            }
            
        }

        private void selectdt_ValueChanged(object sender, EventArgs e)
        {
            gd.getexpensebydat(selectdt.Value.ToShortDateString(), newexdgv, p0, p1, p2, p3, p4, p5, p6);
            newexdgv.ClearSelection();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            exdatetime.Value = DateTime.Today;
            //selectdt.Value = DateTime.Today;
            //newexdgv.ClearSelection();
        }
    }
}
