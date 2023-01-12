using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using PLMS.Properties;

namespace PLMS
{
    class Maincalss
    {
        public static void showwindow(Form openwin, Form closewin, Form MDI)
        {
            closewin.Close();
            openwin.WindowState = FormWindowState.Maximized;
            openwin.MdiParent = MDI;
            openwin.Show();
        }
        public static void showwindow(Form openwin, Form MDI)
        {
            openwin.WindowState = FormWindowState.Maximized;
            openwin.MdiParent = MDI;
            openwin.Show();
        }

        public static void SNC(DataGridView dgv, string sno)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                count++;
                row.Cells[sno].Value = count;

            }
        }
        public static void ShowMasseg(string mgs, string type)
        {
            if (type == "Success")
            {
                MessageBox.Show(mgs,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (type == "Error")
            {
                MessageBox.Show(mgs, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (type == "save")
            {
                MessageBox.Show(mgs,"Saved Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (type == "update")
            {
                MessageBox.Show(mgs, "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "delete")
            {
                MessageBox.Show(mgs, "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void ResetEnable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;

                }
                else if(c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Text = "";
                    cb.Enabled = true;
                }
                else if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    //pb.Image= Resources.contact;
                    pb.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = true;
                }
               
            }

        }
        public static void ResetDisable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;

                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Text ="" ;
                    cb.Enabled = false;
                }
                else if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = Resources.contact;
                    pb.Enabled = false;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
            }

        }
        public static void Disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                   // tb.Text = "";
                    tb.Enabled = false;

                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                   // cb.SelectedIndex = -1;
                    cb.Enabled = false;
                }
                else if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = Resources.contact;
                    //pb.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
            }

        }
        public static void Enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    //tb.Text = "";
                    tb.Enabled = true;

                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                   // cb.SelectedIndex = -1;
                    cb.Enabled = true;
                }
                else if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    //pb.Image= Resources.contact;
                    pb.Enabled = true;
                }
                else if(c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                
            }

        }
        public static void Reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;

                }
                //else if (c is ComboBox)
                //{
                //    ComboBox cb = (ComboBox)c;
                //    // cb.SelectedIndex = -1;
                //    cb.Enabled = true;
                //}
                else if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image= Resources.contact;
                    pb.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }

            }

        }
       public static void CDGVR(DataGridView dgv)
        {
            try
            {
                while (dgv.Rows.Count > 0)
                {
                    if (dgv.Rows.Count > 0)
                    {
                        dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
                    }
                }
            }
            catch (Exception)
            {

            }
            dgv.Refresh();
        }
    }
}
