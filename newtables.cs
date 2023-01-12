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
    public partial class newtables : sample3
    {
        public newtables()
        {
            InitializeComponent();
        }
        public Int16 tid { get; set; }
        public bool Isupdate { get; set; }
        public Int16 cfid { get; set; }
        comboretrival cr = new comboretrival();
        Insertion i = new Insertion();
        Updatedata ud = new Updatedata();
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (fncb.Text != "" && tntxt.Value != 0 && chairtxt.Value != 0)
            {
                if (Isupdate == false)
                {
                    i.inserttables(Convert.ToInt32(tntxt.Value), Convert.ToInt16(chairtxt.Value), Convert.ToInt16(fncb.SelectedValue.ToString()));
                    restcon();

                }
                else if (Isupdate == true)
                {
                    //ud.updatetables(tid, Convert.ToInt32(tntxt.Value), Convert.ToInt16(chairtxt.Value), Convert.ToInt16(fncb.SelectedValue.ToString()));
                    savebtn.Text = "Save";
                    restcon();
                    Isupdate = false;
                }
            }
        }

        private void newtables_Load(object sender, EventArgs e)
        {
            cr.loadcombo("getfloor", fncb, "fn", "fid");
            fncb.SelectedIndex = -1;
            if (Isupdate == true)
            {
                savebtn.Text = "Upadate";
                cr.loaditem("getfloorbuid", fncb, "@id", "fn", cfid);
            }
            // 

        }
        void restcon()
        {
            fncb.SelectedIndex = -1;
            tntxt.Value = 0;
            chairtxt.Value = 0;
        }
    }
}
