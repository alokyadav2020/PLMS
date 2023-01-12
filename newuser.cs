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
    public partial class newuser : sample3
    {
        public newuser()
        {
            InitializeComponent();
        }
        public int updateid { get; set; }
        public bool isupdate { get; set; }
        public int urollid { get; set; }
        comboretrival cbr = new comboretrival();
        Insertion i = new Insertion();
        Updatedata ud = new Updatedata();
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newuser_Load(object sender, EventArgs e)
        {
            if (isupdate == true)
            {
                savebtn.Text = "Update";
                cbr.loaditem("getrollbyid", rolcb, "@id", "roll", urollid);
            }
            else if (isupdate == false)
            {
                savebtn.Text = "Save";
                cbr.loadcombo("getroll", rolcb, "roll", "rid");
                rolcb.SelectedIndex = -1;
            }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (unametxt.Text != "" && passtxt.Text != "" && rolcb.SelectedIndex != -1)
            {
                if (isupdate == true)
                {
                    //ud.updateuser(updateid, unametxt.Text, passtxt.Text, fnametxt.Text, addesstxt.Text, mobiletxt.Text, rolcb.DisplayMember, isadminchek, isactivechek, destxt.Text, emailtxt.Text, Convert.ToInt32(rolcb.SelectedValue.ToString()));
                }
                else if (isupdate == false)
                {
                    i.insertusers(unametxt.Text, passtxt.Text, fnametxt.Text, addesstxt.Text, mobiletxt.Text, rolcb, isadminchek, isactivechek, destxt.Text, emailtxt.Text, Convert.ToInt32(rolcb.SelectedValue.ToString()));
                }

            }
            else { MessageBox.Show("Username and Password can't be blank", "Fill requared information", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
    }
}
