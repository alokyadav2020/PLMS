using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLMS;

namespace PLMS
{
    public partial class sample2 : sample
    {
        public sample2()
        {
            InitializeComponent();
        }

        public virtual void button1_Click(object sender, EventArgs e)
        {
            Menuboard dsb = new Menuboard();
            Maincalss.showwindow(dsb, this,MDI.ActiveForm);
        }
    }
}
