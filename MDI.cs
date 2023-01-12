using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PLMS.All_Class;
using System.Data.SQLite;
using PLMS.ConnectionClass;
using System.IO;

namespace PLMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //public static Environment.SpecialFolder DataPath = Environment.SpecialFolder.ApplicationData;
        private  void MDI_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.firmname!="")
            {
                Logingpage lp = new Logingpage();
                Maincalss.showwindow(lp, this);
                //GlobClass.HN = PLMS.Properties.Settings.Default.firmname;
                this.Text = "Developed by Alok Ranjan      |      Today      " + DateTime.Now.ToLongDateString() + "        |        " + Properties.Settings.Default.firmname + "       ";
            }
            else
            {
                Firm fr = new Firm();
                Maincalss.showwindow(fr, MDI.ActiveForm);
            }
        }
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logingpage lp = new Logingpage();
            Maincalss.showwindow(lp, this);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
