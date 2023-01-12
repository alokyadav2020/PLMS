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
    public partial class sample : Form
    {
        public sample()
        {
            InitializeComponent();
        }

        private void sample_Load(object sender, EventArgs e)
        {
            label2.Text = GlobClass.username;
        }
    }
}
