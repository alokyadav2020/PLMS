using PLMS.All_Class;
using PLMS.ConnectionClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMS
{
    public partial class Logingpage : sample
    {
        public Logingpage()
        {
            InitializeComponent();
            retrievrpass();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usertxt.Text.Trim() != "" && passtxt.Text.Trim() != "")
            {
                GetData gd = new GetData();
                gd.getexpiry();
                //GlobClass.version =Application.ProductVersion;
                if (GlobClass.expiryid > 0)
                {
                    SQLiteConnection con = new SQLiteConnection(dbconnection.Connect());
                    try
                    {
                        string q = "select * from User where username=@un AND password=@pss";
                        SQLiteCommand cmd = new SQLiteCommand(q, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@un", usertxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@pss", passtxt.Text.Trim());
                        con.Open();
                        SQLiteDataReader sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            if (GlobClass.expiryDAY > 0)
                            {                               
                                passremeber();
                                // GlobClass.username = sdr[1].ToString();
                                Menuboard ds = new Menuboard();
                                Maincalss.showwindow(ds, this, MDI.ActiveForm);                                
                            }
                            else
                            {
                                notifyIcon1.ShowBalloonTip(100);
                                Expiresoftware expsoft = new Expiresoftware();
                                Maincalss.showwindow(expsoft, this, MDI.ActiveForm);
                                
                            }
                            //VAlue1=> Current Date
                            //Value2=> Expirydate
                        }
                        else
                        {
                            Maincalss.ShowMasseg("Username and password are incorrect", "Error");
                        }
                        sdr.Close();
                        con.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    DateTime d1 = DateTime.Now;
                    DateTime d2 = d1.AddDays(15);
                    TimeSpan t = d2 - d1;
                    double d = t.TotalDays;
                    SaveClass sc = new SaveClass();
                    sc.addexpiry(d1, d2, Convert.ToInt32(d), Application.ProductVersion);
                    passremeber();
                    Menuboard ds = new Menuboard();
                    Maincalss.showwindow(ds, this, MDI.ActiveForm);
                }
                
            }
            else { Maincalss.ShowMasseg("Usaername and Password both are required", "Error"); usertxt.Focus(); }            
        }

        private void usertxt_KeyDown(object sender, KeyEventArgs e)
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

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
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
        void passremeber()
        {
            if (remebercb.Checked == true)
            {
                PLMS.Properties.Settings.Default.username = usertxt.Text;
                PLMS.Properties.Settings.Default.password = passtxt.Text;
                PLMS.Properties.Settings.Default.Save();
               
            }
            else
            {
                PLMS.Properties.Settings.Default.username = "";
                PLMS.Properties.Settings.Default.password = "";
                PLMS.Properties.Settings.Default.Save();
            }
        }
        void retrievrpass()
        {
            if (PLMS.Properties.Settings.Default.username != string.Empty)
            {
                usertxt.Text = PLMS.Properties.Settings.Default.username;
                passtxt.Text = PLMS.Properties.Settings.Default.password;
                remebercb.Checked = true;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static Environment.SpecialFolder DataPath = Environment.SpecialFolder.ApplicationData;
        private void backfilebtn_Click(object sender, EventArgs e)
        {

            string backdbpath = string.Empty;
            var dbname = "Back" + ".File";
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                backdbpath = Path.GetDirectoryName(opd.FileName);
                var restorebto = Environment.GetFolderPath(DataPath) + "\\" + "lab" + ".db";
                DataAccess.RestoreDB(backdbpath, dbname, restorebto, true);
                MessageBox.Show("Success");

            }
            //notify();
        }

        private void Logingpage_Load(object sender, EventArgs e)
        {
            //GetData gd = new GetData();
            //gd.getexpiry();
        }

        private void remebercb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
   
}
