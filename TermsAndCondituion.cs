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
    public partial class TermsAndCondituion : sample2
    {
        public TermsAndCondituion()
        {
            InitializeComponent();
        }
        SaveClass sc = new SaveClass();
        GetData gd = new GetData();
        Updatedata ud = new Updatedata();
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            gd.getterms(line1txt, line2txt, line3txt, line4txt);
            Maincalss.Enable(rp);
        }

        private void savbtn_Click(object sender, EventArgs e)
        {
            if (line1txt.Text != "" && line2txt.Text != "" &&   line3txt.Text != "" &&  line4txt.Text != "")
            {
                if (GlobClass.termid > 0)
                {
                    ud.updateterm(line1txt.Text, line2txt.Text, line3txt.Text, line4txt.Text);
                }
                else
                {
                    sc.saveterms(line1txt.Text, line2txt.Text, line3txt.Text, line4txt.Text);
                }

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void line1txt_KeyDown(object sender, KeyEventArgs e)
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

        private void line2txt_KeyDown(object sender, KeyEventArgs e)
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

        private void line3txt_KeyDown(object sender, KeyEventArgs e)
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

        private void line4txt_KeyDown(object sender, KeyEventArgs e)
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
    }
}
