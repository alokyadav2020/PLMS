using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using PLMS.All_Class;
using System.Web;

namespace PLMS
{
    public partial class Expiresoftware : sample
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);
        public Expiresoftware()
        {
            InitializeComponent();
        }
        string RandomNumber;
        
        private void getserialbtn_Click(object sender, EventArgs e)
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                if (GlobClass.expiryDAY < 15)
                {
                    GetData gd = new GetData();
                    gd.getfirm();
                    rp.BackColor = Color.ForestGreen;
                    titlelb.Text = "Enter Serial Key, if not awailable contact service provider";
                    keylbl.Visible = true;
                    keytxt.Visible = true;
                    keytxt.Text = "";
                    activatebtn.Visible = true;
                    keytxt.Focus();
                    sendmail();
                }
                else
                {
                    titlelb.Text = "Your Software Up to Date , "+ "Remaining Days : "+ GlobClass.expiryDAY.ToString("N");
                    rp.BackColor = Color.ForestGreen;
                    label4.Text = " UP TO DATE";
                }
            }
            else
            {
                rp.BackColor = Color.IndianRed;
                titlelb.Text = "Internet not connected , Connect Internet......";
                keylbl.Visible = false;
                keytxt.Visible = false;
                activatebtn.Visible = false;
                notifyIcon1.ShowBalloonTip(500);
            }
        }
        public async void sendmail()
        {
            await Task.Run(() => {
                try
                {
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Port = 587;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("aacademy2022@gmail.com", "8005086600");
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("aacademy2022@gmail.com");
                    mail.To.Add("alokranjan.ucer@gmail.com");
                    Random rnd = new Random();
                    RandomNumber = (rnd.Next(100000, 999999)).ToString();
                    mail.Subject = "Serial Key For Renewal PLMS Softwate  | Firm name : " + GlobClass.HN;
                    mail.Body = "Serial Key for Renewal Softwate PLMS " + "\n\n Current Date :" + DateTime.Now + "\n\n Valid Upto: " + DateTime.Now.AddYears(5) + "\n\n\nSerial Key is " + RandomNumber + "\n\n\n" + Properties.Settings.Default.firmname + "\n" + "Address : "+ GlobClass.mt2 + "\n" + "Mobile : "+ GlobClass.mt3 + "\n" +"Registration : "+ GlobClass.mt4+ "";
                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });

        }

        private void activatebtn_Click(object sender, EventArgs e)
        {
            if (keytxt.Text == RandomNumber)
            {
                DateTime d1 = DateTime.Now;
                DateTime d2 = d1.AddYears(5);
                TimeSpan t = d2 - d1;
                double d = t.TotalDays;
                SaveClass sc = new SaveClass();
                sc.addexpiry(d1, d2, Convert.ToInt32(d), GlobClass.version);
                notifyIcon1.BalloonTipTitle = "Success";
                notifyIcon1.BalloonTipText = "5 Year validation extended";
                notifyIcon1.ShowBalloonTip(500);
                Logingpage ds = new Logingpage();
                Maincalss.showwindow(ds, this, MDI.ActiveForm);                
            }
            else
            {
                titlelb.Text = "Incorrect Serial Key";
                keytxt.Focus();
                notifyIcon1.BalloonTipTitle = "Incorrect Serial Key";
                notifyIcon1.BalloonTipText = "Please Conform serial key";
                notifyIcon1.ShowBalloonTip(500);
                keytxt.BackColor = Color.Red;
            }
        }

        private void keytxt_TextChanged(object sender, EventArgs e)
        {
            keytxt.BackColor = Color.White;
            titlelb.Text = "Enter Serial Key, if not awailable contact service provider";
        }

        private void keytxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Expiresoftware_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.Down)
            //    {
            //        e.SuppressKeyPress = true;
            //        SendKeys.Send("{tab}");
            //    }
            //    else if (e.KeyCode == Keys.Up)
            //    {
            //        e.SuppressKeyPress = true;
            //        SendKeys.Send("+{tab}");
            //    }
            //    else if (e.KeyCode == Keys.Escape)
            //    {
            //        this.Close();
            //    }
            //    else if (e.KeyCode == Keys.Q)
            //    {
                    
            //    }
            //}
            //catch
            //{
            //}
        }

        private void Expiresoftware_Load(object sender, EventArgs e)
        {
            if (GlobClass.expiryDAY > 15)
            {
                titlelb.Text ="Software Expire On :  "+ GlobClass.expirydate.ToString();
                rp.BackColor = Color.ForestGreen;
                label4.Text = "Software Expiry ";
            }
            else
            {
                titlelb.Text = "Software Expire On :  " + GlobClass.expirydate.ToString();
                rp.BackColor = Color.IndianRed;
                label4.Text = "Software Expiry ";
            }
        }
    }
}
