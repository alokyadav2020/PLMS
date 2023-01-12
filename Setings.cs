using PLMS.All_Class;
using PLMS.ConnectionClass;
using PLMS.Properties;
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
    public partial class Setings : sample2
    {
        public Setings()
        {
            InitializeComponent();
        }
      

        private void termbtn_Click(object sender, EventArgs e)
        {
            TermsAndCondituion tc = new TermsAndCondituion();
            Maincalss.showwindow(tc,this,MDI.ActiveForm);
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            Users ur = new Users();
            Maincalss.showwindow(ur, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Firm tt = new Firm();
            Maincalss.showwindow(tt, this, MDI.ActiveForm);
        }
        public static Environment.SpecialFolder DataPath = Environment.SpecialFolder.ApplicationData ;

        private void cdbbtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Data Source=" + Environment.GetFolderPath(DataPath) + "\\PLMS\\lab.db;"))
            {
                CreatDB cdb = new CreatDB();
                cdb.creatdatabase();
            }
            else { MessageBox.Show("Database Already exits","",MessageBoxButtons.OK,MessageBoxIcon.Information);}
        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private void restoredbbtn_Click(object sender, EventArgs e)
        {
            
            DialogResult result = fbd.ShowDialog();
            if(result==DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                propercetacelbl.Text = "Backuping Database File,  Please wait........";
                string dbpath = Environment.GetFolderPath(DataPath) + "\\PLMS";
                var dbname = "lab.db";
                var bacpath = fbd.SelectedPath + "\\" + "Back" + ".File";
                filesize = bacpath.Length;
                DataAccess.BackupDB(dbpath, dbname, bacpath);
                backnf.ShowBalloonTip(100);
                // progressBar1.Visible = false;
                propercetacelbl.Text = "Backuping Database File Completed !!";
            }
           
        }

        private void Restoredb_Click(object sender, EventArgs e)
        {
            
            propercetacelbl.Text = "Restoring Database File,  Please wait........";
            GC.Collect();
            GC.WaitForPendingFinalizers();
            string backdbpath = string.Empty;
            var dbname = "Back"+".File";
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                backdbpath = Path.GetDirectoryName(opd.FileName);
                var restorebto = Environment.GetFolderPath(DataPath) + "\\PLMS" + "\\" + "lab" + ".db";
                propercetacelbl.Visible = true;
                DataAccess.RestoreDB(backdbpath, dbname, restorebto, true);
                //MessageBox.Show("Success");
                //restornf.ShowBalloonTip(100);
                propercetacelbl.Text = "Restoring Database File Completed !!";
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (GlobClass.version == Application.ProductVersion)
            {
                MessageBox.Show("Your Software is Upto Date", "Running updated version", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {               
                Updatedata ud = new Updatedata();
                ud.updateversion();
                vertlp.Visible = false;
                updatebtn.BackColor = Color.WhiteSmoke;
                updatebtn.ForeColor = Color.Black;
                GetData gd = new GetData();
                gd.getexpiry();
                DialogResult result = MessageBox.Show("Please make database backup","Backup Database",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    restoredbbtn.PerformClick();
                }
            }
        }

        private void Expirybtn_Click(object sender, EventArgs e)
        {
            GetData gd = new GetData();
            gd.getexpiry();
            Expiresoftware exps = new Expiresoftware();
            Maincalss.showwindow(exps, MDI.ActiveForm);
        }
        int filesize;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // progressBar1.Visible = true;
            //progressBar1.Value = e.ProgressPercentage;
           // progressBar1.Maximum = filesize;
            //progressBar1.PerformStep();
            progressBar1.Value = e.ProgressPercentage;
            //propercetacelbl.Text = 100 / filesize +" %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void Setings_Load(object sender, EventArgs e)
        {
            if (GlobClass.version == Application.ProductVersion)
            {
                
            }
            else
            {
                vertlp.Visible = true;
                olderlbl.Text = "Running Version : " + GlobClass.version;
                currentlbl.Text = "New awailable Version : " + Application.ProductVersion;
                updatebtn.BackColor = Color.Red;
                //updatebtn.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
