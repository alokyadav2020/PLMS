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
    public partial class CreatExpenses : sample
    {
        public CreatExpenses()
        {
            InitializeComponent();
        }
        int Save;
        int expid;
        GetData gd = new GetData();
        SaveClass sc = new SaveClass();
        Updatedata ud = new Updatedata();
        Deletedata dd = new Deletedata();
        private void bacbtn_Click(object sender, EventArgs e)
        {
            Expenses exp = new Expenses();
            Maincalss.showwindow(exp,this, MDI.ActiveForm);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Save = 0;
            Maincalss.ResetEnable(lp);
            enametxt.Focus();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (enametxt.Text == "" && epricetxt.Text == "")
            {
                Maincalss.ShowMasseg("Please double click on plan to select", "Error");
            }
            else
            {
                Save = 1;
                Maincalss.Enable(lp);
                enametxt.Focus();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (expid > 0)
            {
                DialogResult dr = MessageBox.Show("Do you sure to delete ?", "Delete conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    dd.delexpense(expid);
                    gd.getexpense(dgvexp, g0, g1, g2, g3);
                    dgvexp.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    expid = 0;
                }
                else
                {
                    dgvexp.ClearSelection();
                    Maincalss.ResetDisable(lp);
                    expid = 0;
                }
            }
            else { MessageBox.Show("Please select the row to detele", "Row not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            gd.getexpense(dgvexp, g0, g1, g2, g3);
            dgvexp.ClearSelection();
            Maincalss.ResetDisable(lp);
        }

        private void savrbtn_Click(object sender, EventArgs e)
        {
            if (enametxt.Text.Trim() != "" & epricetxt.Text.Trim() != "")
            {
                if (Save == 0)// Insert Operation
                {
                    sc.expensinfo(enametxt.Text, Convert.ToDecimal(epricetxt.Text), edectxt.Text);
                    gd.getexpense(dgvexp, g0, g1, g2, g3);
                    dgvexp.ClearSelection();
                    Maincalss.ResetDisable(lp);

                }
                else if (Save == 1)
                {
                    ud.updateexpense(expid, enametxt.Text, Convert.ToDecimal(epricetxt.Text), edectxt.Text);
                    expid = 0;
                    gd.getexpense(dgvexp, g0, g1, g2, g3);
                    dgvexp.ClearSelection();
                    Maincalss.ResetDisable(lp);
                }
            }
            else { Maincalss.ShowMasseg("All fields are manatory", "Error"); }
        }

        private void dgvexp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvexp.Rows.Count > 0)
                {
                    expid = Convert.ToInt32(dgvexp.SelectedRows[0].Cells[0].Value);
                    enametxt.Text = dgvexp.SelectedRows[0].Cells[1].Value.ToString();
                    epricetxt.Text = dgvexp.SelectedRows[0].Cells[2].Value.ToString();
                    edectxt.Text = dgvexp.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {
                Maincalss.ShowMasseg("Select Proper row to Update OR Delete Data", "Error");
            }
           
        }

        private void enametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void epricetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void epricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
