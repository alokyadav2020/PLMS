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
    public partial class printtype : sample3
    {
        public printtype()
        {
            InitializeComponent();
        }
        public int cid { get; set; }
        public bool Isupdate { get; set; }
        SaveClass sc = new SaveClass();
        GetData gd = new GetData();
        Updatedata ud = new Updatedata();
        private void button1_Click(object sender, EventArgs e)
        {
            if (printprivewbtn.Checked == true)
            {
                ud.updateprint(1, 1);
            }
            else if (savepdfbtn.Checked == true)
            {
                ud.updateprint(1, 2);
            }
            else if (directprintbtn.Checked == true)
            {
                ud.updateprint(1, 3);
            }
            this.Close();
        }

        private void newcustomer_Load(object sender, EventArgs e)
        {
            gd.getpriintid();
            if (GlobClass.printmethod == 1) { printprivewbtn.Checked = true; }
            else if (GlobClass.printmethod == 2) { savepdfbtn.Checked = true; }
            else if (GlobClass.printmethod == 3) { directprintbtn.Checked = true; }
        }
    }
}
