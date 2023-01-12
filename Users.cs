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
    public partial class Users : sample2
    {
        public Users()
        {
            InitializeComponent();
        }
        public int save;
        SaveClass sc = new SaveClass();
        GetData gd= new GetData();
        Deletedata dd = new Deletedata();
        Updatedata ud = new Updatedata();
        private void addbtn_Click(object sender, EventArgs e)
        {
            Maincalss.ResetEnable(lp);
            usernametxt.Focus();
            save = 0;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Maincalss.Enable(lp);
            usernametxt.Focus();
            save = 1;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (uid > 0)
            {
                DialogResult dr = MessageBox.Show("Do you sure to delete student record ?", "Delete Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dd.deluser(uid);
                    gd.getusers(dgvuser, g0, g1, g2, g3, g4);
                    dgvuser.ClearSelection();
                    Maincalss.ResetDisable(lp);
                }
                else
                {
                    uid = 0;
                    Maincalss.ResetDisable(lp);
                    dgvuser.ClearSelection();
                }
                  
            }
            else { Maincalss.ShowMasseg("Please select row to delete ", "Error"); }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            gd.getusers(dgvuser, g0, g1, g2, g3, g4);
            dgvuser.ClearSelection();
        }

        private void savrbtn_Click(object sender, EventArgs e)
        {
            if (save == 0)// Save Opertaion
            {
                if(usernametxt.Text=="" && passtxt.Text == "")
                {
                    Maincalss.ShowMasseg("All Fields are mandatory", "Error");
                }
                else
                {
                    sc.userinfo(usernametxt.Text, passtxt.Text, usermobtxt.Text, useremail.Text);
                    Maincalss.ResetDisable(lp);
                    gd.getusers(dgvuser, g0, g1, g2, g3, g4);
                    dgvuser.ClearSelection();
                    //usernametxt.Focus();
                }
            }
            else if (save == 1)// update opration
            {
                if (usernametxt.Text == "" && passtxt.Text == "")
                {
                    Maincalss.ShowMasseg("All Fields are mandatory", "Error");
                }
                else
                {
                    ud.updateuser(uid, usernametxt.Text, passtxt.Text, usermobtxt.Text, useremail.Text);
                    Maincalss.ResetDisable(lp);
                    gd.getusers(dgvuser, g0, g1, g2, g3, g4);
                    dgvuser.ClearSelection();
                }
            }
        }

        private void usernametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void usermobtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void useremail_KeyDown(object sender, KeyEventArgs e)
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
        public int uid;
        private void dgvuser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvuser.Rows.Count > 0)
            {
                try
                {
                    uid = Convert.ToInt32(dgvuser.SelectedRows[0].Cells[0].Value);
                    usernametxt.Text = dgvuser.SelectedRows[0].Cells[1].Value.ToString();
                    passtxt.Text = dgvuser.SelectedRows[0].Cells[2].Value.ToString();
                    usermobtxt.Text = dgvuser.SelectedRows[0].Cells[3].Value.ToString();
                    useremail.Text = dgvuser.SelectedRows[0].Cells[4].Value.ToString();
                }
                catch (Exception)
                {
                    
                }
            }
        }
    }
}
