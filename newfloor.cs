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
    public partial class newfloor : sample3
    {
        public newfloor()
        {
            InitializeComponent();
        }
        public Int16 fid { get; set; }
        public bool Isupdate { get; set; }
        Insertion i = new Insertion();
        Updatedata ud = new Updatedata();
        comboretrival cr = new comboretrival();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savetbn_Click(object sender, EventArgs e)
        {
            if (floornotxt.Text != "" && fnametxt.Text != "")
            {
                if (Isupdate == true)
                {
                    //ud.updatefloor(fid, fnametxt.Text, Convert.ToInt16(floornotxt.Value));
                    //fnametxt.Focus();
                    //Isupdate = false;
                    //fnametxt.Text = "";
                    //floornotxt.Value = 0;
                    //savetbn.Text = "Save";
                }
                else if (Isupdate == false)
                {
                    i.insertfloor(fnametxt.Text, Convert.ToInt16(floornotxt.Value));
                    fnametxt.Focus();
                    fnametxt.Text = "";
                    floornotxt.Value = 0;
                }
            }
        }

        private void newfloor_Load(object sender, EventArgs e)
        {
            if (Isupdate == true) { savetbn.Text = "Update"; }
        }

        private void floornotxt_Leave(object sender, EventArgs e)
        {
            //cr.checkitem("getfloorbuid", "@id", floornotxt.Value);
        }
    }
}
