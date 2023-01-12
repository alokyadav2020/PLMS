using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMS
{
    class DataAccess
    {
        // Backup SQLite DB
        public static void BackupDB(string filepath, string srcfilename, string destifilename)
        {
            try
            {
                var srcfie = Path.Combine(filepath, srcfilename);
                var destfile = Path.Combine(filepath, destifilename);                
                if (File.Exists(destfile)) File.Delete(destfile);
                File.Copy(srcfie, destfile);
                //Setings ss = new Setings();
               // ss.backnf.ShowBalloonTip(7000);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Setings ss = new Setings();
                ss.backnf.BalloonTipTitle = "Failed";
                ss.backnf.BalloonTipText = "Please try Again Later..";
                ss.backnf.ShowBalloonTip(7000);
            }
           
        }

        // Resstore SQLite DB
        public static void RestoreDB(string filepath, string srcfilename, string destfilename, bool IsCopy = false)
        {
            try
            {
                var srcfile = Path.Combine(filepath, "Back"+".File");
                var destfile = Path.Combine(filepath, destfilename);
                if (File.Exists(destfile)) File.Delete(destfile);
                if (IsCopy)
                {
                    BackupDB(filepath, srcfilename, destfilename);
                    Setings ss = new Setings();
                    ss.restornf.ShowBalloonTip(7000);
                }
                else
                {
                    File.Move(srcfile, destfile);
                    Setings ss = new Setings();
                    ss.restornf.ShowBalloonTip(7000);
                }
            }
            catch (Exception)
            {
                Maincalss.ShowMasseg("Database is busy, Please Restart Application and Restore Databae", "Error");
                Setings ss = new Setings();
                ss.restornf.BalloonTipTitle = "Failed";
                ss.restornf.BalloonTipText = "Please Try Again Later...";
                ss.restornf.ShowBalloonTip(7000);
            }
            
        }
    }
}
