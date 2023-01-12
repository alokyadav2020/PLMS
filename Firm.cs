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

using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using PLMS.Properties;

namespace PLMS
{
    public partial class Firm : sample
    {
        public Firm()
        {
            InitializeComponent();
        }
        GetData gd = new GetData();
        SaveClass sc = new SaveClass();
        Updatedata ud = new Updatedata();
        private void resetbtn_Click(object sender, EventArgs e)
        {
            gd.getpageheader(firmnametxt, firmaddtxt, firmconttxt, regtxt, logopb);
            Maincalss.Enable(rp);
            firmnametxt.Focus();
            gd.getfirmid();
        }
        Image i;
        private void logopb_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap b = new Bitmap(openFileDialog1.FileName);
                //i = new Bitmap();
                i = resizeImage(b, new Size(80, 80));
                logopb.Image = i;
                logopb.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                i = Resources.w;

            }
        }
        private static Image resizeImage(Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private void savbtn_Click(object sender, EventArgs e)
        {
            if (GlobClass.headerid > 0)
            {
                if (firmaddtxt.Text != "" && firmnametxt.Text != "" && firmconttxt.Text != "")
                {
                    MemoryStream ms = new MemoryStream();
                    if (i == null)
                    {
                        i = Resources.w;
                        i.Save(ms, ImageFormat.Png);
                        byte[] arr = ms.ToArray();
                        ud.updateheader(firmnametxt.Text, firmaddtxt.Text, firmconttxt.Text, regtxt.Text, arr);
                        PLMS.Properties.Settings.Default.firmname = firmnametxt.Text;
                        PLMS.Properties.Settings.Default.Save();
                        Menuboard mb = new Menuboard();
                        Maincalss.showwindow(mb, this, MDI.ActiveForm);
                    }
                    else
                    {
                        i.Save(ms, ImageFormat.Png);
                        byte[] arr = ms.ToArray();
                        ud.updateheader(firmnametxt.Text, firmaddtxt.Text, firmconttxt.Text, regtxt.Text, arr);
                        PLMS.Properties.Settings.Default.firmname = firmnametxt.Text;
                        PLMS.Properties.Settings.Default.Save();
                        Menuboard mb = new Menuboard();
                        Maincalss.showwindow(mb, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (firmaddtxt.Text != "" && firmnametxt.Text != "" && firmconttxt.Text != "")
                {
                    MemoryStream ms = new MemoryStream();
                    if (i == null)
                    {
                        i = Resources.w;
                        i.Save(ms, ImageFormat.Png);
                        byte[] arr = ms.ToArray();
                        sc.headerinfo(firmnametxt.Text, firmaddtxt.Text, firmconttxt.Text, regtxt.Text, arr);
                        PLMS.Properties.Settings.Default.firmname = firmnametxt.Text;
                        PLMS.Properties.Settings.Default.Save();
                        Logingpage lp = new Logingpage();
                        Maincalss.showwindow(lp, this, MDI.ActiveForm);
                    }
                    else
                    {
                        i.Save(ms, ImageFormat.Png);
                        byte[] arr = ms.ToArray();
                        sc.headerinfo(firmnametxt.Text, firmaddtxt.Text, firmconttxt.Text, regtxt.Text, arr);
                        PLMS.Properties.Settings.Default.firmname = firmnametxt.Text;
                        PLMS.Properties.Settings.Default.Save();
                        Logingpage lp = new Logingpage();
                        Maincalss.showwindow(lp, this, MDI.ActiveForm);
                    }
                }
            }
            
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            logopb.Image = Resources.w;
        }

        private void firmnametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void firmaddtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void firmconttxt_KeyDown(object sender, KeyEventArgs e)
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

        private void regtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            Menuboard dsb = new Menuboard();
           // Settings st = new Settings();
            Maincalss.showwindow(dsb, this, MDI.ActiveForm);
        }

        private void Firm_Load(object sender, EventArgs e)
        {
            gd.getpageheader(firmnametxt, firmaddtxt, firmconttxt, regtxt, logopb);
            Maincalss.Enable(rp);
            firmnametxt.Focus();
            gd.getfirmid();
        }
        /*
string connection;

public void updateconfigfile(string dbcs)
{
XmlDocument XmlDoc = new XmlDocument();
XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
foreach (XmlElement xElement in XmlDoc.DocumentElement)
{
if(xElement.Name== "connectionStrings")
{
xElement.FirstChild.Attributes[1].Value = dbcs;
}
}
XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
ConfigurationManager.RefreshSection("connectionStrings");
}


private void button1_Click_1(object sender, EventArgs e)
{

if (servernametxt.Text.Trim() != "" && dbnametxt.Text.Trim()!="" && usertxt.Text.Trim()!="" && passtxt.Text.Trim()!= "" )
{
connection = "Data Source=" + servernametxt.Text + ";Initial Catalog = "+dbnametxt.Text+"; User ID = "+usertxt.Text+"; Password="+passtxt.Text+"; MultipleActiveResultSets=true;";
updateconfigfile(connection);
Loggin lg = new Loggin();
lg.ShowDialog();
this.Hide();
}
else { MessageBox.Show("All Fields are mandatory", "Fileds Missing ..", MessageBoxButtons.OK, MessageBoxIcon.Error); }


}

*/
    }
}
