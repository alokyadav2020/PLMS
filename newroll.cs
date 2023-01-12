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
    public partial class newroll : sample3

    {
        public newroll()
        {
            InitializeComponent();
        }
        public int rolid { get; set; }
        public string Isupdate { get; set; }
        Insertion i = new Insertion();
        comboretrival cr = new comboretrival();
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (rolldestxt.Text != "" && rolldestxt.Text != "")
            {
                if (rolid > 0)
                {
                    Updatedata ud = new Updatedata();
                    //ud.updaterolls(rolid, rolltxt.Text, rolldestxt.Text);
                    resetcont();
                    rolid = 0;
                    savebtn.Text = "Save";

                }
                else
                {
                    i.insertroll(rolltxt.Text, rolldestxt.Text);
                    resetcont();

                }

            }

        }
        void resetcont()
        {
            rolltxt.Text = "";
            rolldestxt.Text = "";
            rolltxt.Focus();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (rolid > 0)
            {
                Deletedata d = new Deletedata();
                //d.deleteroll(rolid);
                resetcont();
                rolid = 0;

            }

        }

        private void newroll_Load(object sender, EventArgs e)
        {
            rolltxt.Focus();
            if (rolid > 0)
            {
                deletebtn.Visible = true;
                savebtn.Text = "Update";
            }
            else { savebtn.Text = "Save"; }
        }

        private void rolltxt_Leave(object sender, EventArgs e)
        {
            // cr.checkitem("getrollbyid", "roll", rolltxt.Text);
        }
    }
}
