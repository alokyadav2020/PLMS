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
    public partial class Dashboard : sample
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void backbrn_Click(object sender, EventArgs e)
        {
            Menuboard mb = new Menuboard();
            Maincalss.showwindow(mb, this, MDI.ActiveForm);
        }

        private void statsbtn_Click(object sender, EventArgs e)
        {
            GetData gd = new GetData();
            gd.getpichart(chart1);
            gd.getplanchart(planchart);
            gd.getplanpaidchart(chart2);
            gd.getplanunpaidchart(chart3);
            gd.getsumstamount(talbl, tpalbl, tupalbl);
            gd.getSUMEXPENSE(chart5);
            gd.getexpechart(chart4);
            gd.gettotalexpense(texpenslbl);
        }
    }
}
