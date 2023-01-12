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
    public partial class Plan : sample2
    {
        public Plan()
        {
            InitializeComponent();
        }
        int Save;
        int pid;
        GetData gd = new GetData();
        SaveClass sc = new SaveClass();
        Updatedata ud = new Updatedata();
        Deletedata dd = new Deletedata();
        private void Users_Load(object sender, EventArgs e)
        {


        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Save = 0;
            Maincalss.ResetEnable(lp);
            pnametxt.Focus();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if(pnametxt.Text=="" && ppricetxt.Text == "")
            {
                Maincalss.ShowMasseg("Please double click on plan to select", "Error");
            }
            else
            {
                Save = 1;
                Maincalss.Enable(lp);
                pnametxt.Focus();
            }
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (pid > 0)
            {
                DialogResult dr = MessageBox.Show("Do you sure to delete ?", "Delete conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    dd.delplan(pid);
                    gd.getplan(pdgv, p0, p1, p2, p3, p4, p5);
                    pdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    pid = 0;
                }
                else
                {
                    pdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    pid = 0;
                }
            }
            else { MessageBox.Show("Please select the row to detele", "Row not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            gd.getplan(pdgv, p0, p1, p2, p3, p4, p5);
            pdgv.ClearSelection();
            Maincalss.ResetDisable(lp);
        }

        private void savrbtn_Click(object sender, EventArgs e)
        {
            if(pnametxt.Text.Trim()!="" & ppricetxt.Text.Trim() != "")
            {
                if (Save == 0)
                {
                    sc.Planinfo(pnametxt.Text.Trim(), Convert.ToDecimal(ppricetxt.Text.Trim()), ptimetxt.Text.Trim(), pdurationttxt.Text.Trim(), pdescritiontxt.Text.Trim());
                    gd.getplan(pdgv, p0, p1, p2, p3, p4, p5);
                    pdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);

                }
                else if (Save == 1)
                {
                    ud.updatePlaninfo(pid, pnametxt.Text.Trim(), Convert.ToDecimal(ppricetxt.Text.Trim()), ptimetxt.Text.Trim(), pdurationttxt.Text.Trim(), pdescritiontxt.Text.Trim());
                    pid = 0;
                    gd.getplan(pdgv, p0, p1, p2, p3, p4, p5);
                    pdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                }
            }
            else { Maincalss.ShowMasseg("All fields are manatory", "Error"); }
        }

        private void pdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (pdgv.Rows.Count > 0)
                {
                    pid = Convert.ToInt32(pdgv.SelectedRows[0].Cells[0].Value);
                    pnametxt.Text = pdgv.SelectedRows[0].Cells[1].Value.ToString();
                    ppricetxt.Text = pdgv.SelectedRows[0].Cells[2].Value.ToString();
                    ptimetxt.Text = pdgv.SelectedRows[0].Cells[3].Value.ToString();
                    pdurationttxt.Text = pdgv.SelectedRows[0].Cells[4].Value.ToString();
                    pdescritiontxt.Text = pdgv.SelectedRows[0].Cells[5].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select row properly", "Row not select ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pnametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void ppricetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void ptimetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void pdurationttxt_KeyDown(object sender, KeyEventArgs e)
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

        private void pdescritiontxt_KeyDown(object sender, KeyEventArgs e)
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

        private void ppricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pid > 0)
            {
                DialogResult dr = MessageBox.Show("Do you sure to delete ?", "Delete conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    dd.delplan(pid);
                    gd.getplan(pdgv, p0, p1, p2, p3, p4, p5);
                    pdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    pid = 0;
                }
                else
                {
                    pdgv.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    pid = 0;
                }
            }
            else { MessageBox.Show("Please select the row to detele", "Row not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
