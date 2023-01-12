using PLMS.All_Class;
using PLMS.Properties;
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

namespace PLMS
{
    public partial class Student : sample2
    {
        public Student()
        {
            InitializeComponent();
        }
        int save;
        GetData gd = new GetData();
        SaveClass sc = new SaveClass();
        Updatedata ud = new Updatedata();
        Deletedata dd = new Deletedata();
        private void button2_Click(object sender, EventArgs e)
        {
            //newroll nr = new newroll();
            //nr.ShowDialog();
        }
        public void checkid()
        {
            string randno;
            Random rnd = new Random();
            randno = (rnd.Next(100000, 999999)).ToString();
            GlobClass.newsid = Convert.ToInt32(randno.ToString());
            stID.Text = randno.ToString();
        }
        private void Rolls_Load(object sender, EventArgs e)
        {
            //vd.getrolldata(rolldgv, rid, rtitle, rdescription, date);
            //rolldgv.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobClass.sname = searchtxt.Text.ToString();
            gd.searchstudentinfi(dgv, g0, g1, g2, g3, g4, g6,g5);
            dgv.ClearSelection();
        }

        private void rolldgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1 && e.ColumnIndex != -1)
            //{
            //    newroll nr = new newroll();
            //    nr.rolid = Convert.ToInt32(rolldgv.SelectedRows[0].Cells[0].Value);
            //    nr.rolltxt.Text = rolldgv.SelectedRows[0].Cells[1].Value.ToString();
            //    nr.rolldestxt.Text = rolldgv.SelectedRows[0].Cells[2].Value.ToString();
            //    nr.ShowDialog();
            //    vd.getrolldata(rolldgv, rid, rtitle, rdescription, date);
            //    rolldgv.ClearSelection();
            //}
        }
        public override void button1_Click(object sender, EventArgs e)
        {
            Menuboard ds = new Menuboard();
            Maincalss.showwindow(ds,this,MDI.ActiveForm);
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            gd.getstudentinfifull(dgv, g0, g1, g2, g3, g4, g6,g5);
            dgv.ClearSelection();
            searchtxt.Text = "";
            Maincalss.ResetDisable(lp);
            countlbl.Text ="Total Student : "+ dgv.Rows.Count.ToString("D");
        }
        Image i;
        private void studentpic_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap b = new Bitmap(openFileDialog1.FileName);
                //i = new Bitmap();
                i = resizeImage(b, new Size(128, 128));
                studentpic.Image = i;
                studentpic.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                i = Resources.contact;

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

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            Maincalss.ResetEnable(lp);
            stname.Focus();
            save = 0;
            
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Maincalss.Enable(lp);
            save = 1;
            stID.Enabled = false;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (getid > 0)
            {
                DialogResult dr = MessageBox.Show("Do you sure to delete student record ?", "Delete Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dd.delstdentinfo(getid);
                    getid = 0;
                    Maincalss.ResetDisable(lp);
                    gd.getstudentinfi(dgv, g0, g1, g2, g3, g4, g6,g5);
                    studentpic.Image = Resources.contact;
                    dgv.ClearSelection();
                    countlbl.Text = "Total Student : " + dgv.Rows.Count.ToString("D");
                }
                else
                {
                    getid = 0;
                    Maincalss.ResetDisable(lp);
                    studentpic.Image = Resources.contact;
                    dgv.ClearSelection();
                }
                
                save = 0;
            }
            else { Maincalss.ShowMasseg("Please select row to delete ", "Error"); }
        }

        private void savrbtn_Click(object sender, EventArgs e)
        {
            if (save == 0) //Save Opreation
            {
                if(stname.Text.Trim()=="" && stID.Text.Trim()=="" && stmobile.Text.Trim() == "")
                {
                    Maincalss.ShowMasseg("All Fields are mandatory", "Error");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    if (i == null)
                    {
                        i = Resources.contact;
                        i.Save(ms, ImageFormat.Png);
                        byte[] arr = ms.ToArray();
                        sc.studentinfo(stname.Text.Trim(), Convert.ToInt32(stID.Text.Trim()), Convert.ToInt64(stmobile.Text.Trim()), staddress.Text.Trim(), fnametxt.Text.Trim(), arr);
                        Maincalss.ResetDisable(lp);
                        stname.Focus();
                        gd.getstudentinfi(dgv, g0, g1, g2, g3, g4, g6,g5);
                        dgv.ClearSelection();
                        countlbl.Text = "Total Student : " + dgv.Rows.Count.ToString("D");
                    }
                    else
                    {
                        i.Save(ms, ImageFormat.Png);
                        byte[] arr = ms.ToArray();
                        sc.studentinfo(stname.Text.Trim(), Convert.ToInt32(stID.Text.Trim()), Convert.ToInt64(stmobile.Text.Trim()), staddress.Text.Trim(), fnametxt.Text.Trim(), arr);
                        Maincalss.ResetDisable(lp);
                        stname.Focus();
                        gd.getstudentinfi(dgv, g0, g1, g2, g3, g4, g6,g5);
                        dgv.ClearSelection();
                        i = null;
                        studentpic.Image = Resources.contact;
                        countlbl.Text = "Total Student : " + dgv.Rows.Count.ToString("D");
                    }
                }
            }
            else if(save==1)
            {
                // Update Operation
                if (stname.Text.Trim() == "" && stID.Text.Trim() == "" && stmobile.Text.Trim() == "")
                {
                    Maincalss.ShowMasseg("All Fields are mandatory", "Error");
                }
                else
                {
                    
                    if (getid > 0)
                    {
                        if (stname.Text.Trim() != "" && stID.Text.Trim() != "" && stmobile.Text.Trim() != "" && staddress.Text.Trim() != "")
                        {
                            MemoryStream ms = new MemoryStream();
                            if (i == null)
                            {
                                i = studentpic.Image;
                                i.Save(ms, ImageFormat.Png);
                                byte[] arr = ms.ToArray();
                                ud.updatestudentinfo(getid, stname.Text.Trim(), Convert.ToInt64(stmobile.Text.Trim()), staddress.Text.Trim(), fnametxt.Text.Trim(), arr);
                                // sc.studentinfo(stname.Text.Trim(), Convert.ToInt32(stID.Text.Trim()), Convert.ToInt64(stmobile.Text.Trim()), staddress.Text.Trim(), 1, arr);
                                Maincalss.ResetDisable(lp);
                                stname.Focus();
                                gd.getstudentinfi(dgv, g0, g1, g2, g3, g4, g6,g5);
                                dgv.ClearSelection();
                                studentpic.Image = Resources.contact;
                                i = null;
                                getid = 0;
                            }
                            else
                            {
                                i.Save(ms, ImageFormat.Png);
                                byte[] arr = ms.ToArray();
                                ud.updatestudentinfo(getid, stname.Text.Trim(), Convert.ToInt64(stmobile.Text.Trim()), staddress.Text.Trim(), fnametxt.Text.Trim(), arr);
                                //sc.studentinfo(stname.Text.Trim(), Convert.ToInt32(stID.Text.Trim()), Convert.ToInt64(stmobile.Text.Trim()), staddress.Text.Trim(), 1, arr);
                                Maincalss.ResetDisable(lp);
                                stname.Focus();
                                gd.getstudentinfi(dgv, g0, g1, g2, g3, g4, g6,g5);
                                dgv.ClearSelection();
                                i = null;
                                studentpic.Image = Resources.contact;
                                getid = 0;
                            }
                            save = 0;
                        }
                        else { MessageBox.Show("All Fields are  required"); }
                    }
                    else
                    {
                        MessageBox.Show("You have not selected any row", "Student Info not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

            }
        }
        Int32 getid;
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    getid = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                    stname.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                    fnametxt.Text= dgv.SelectedRows[0].Cells["g6"].Value.ToString();
                    stID.Text = dgv.SelectedRows[0].Cells["g2"].Value.ToString();
                    stmobile.Text = dgv.SelectedRows[0].Cells["g3"].Value.ToString();
                    staddress.Text = dgv.SelectedRows[0].Cells["g4"].Value.ToString();
                    if (dgv.SelectedRows[0].Cells["g5"].Value != null)
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])dgv.SelectedRows[0].Cells["g5"].Value;
                        MemoryStream mem = new MemoryStream(data);
                        studentpic.Image = Image.FromStream(mem);
                    }
                    save = 3;
                    stID.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select row properly", "Row not select ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void stname_Leave(object sender, EventArgs e)
        {
            if (save == 0)
            {
                checkid();
                gd.getnewstid();
                stID.Text = GlobClass.newsid.ToString();
            }
            else if (save == 1)
            {

            }
        }

        private void stname_KeyDown(object sender, KeyEventArgs e)
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

        private void stID_KeyDown(object sender, KeyEventArgs e)
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

        private void stmobile_KeyDown(object sender, KeyEventArgs e)
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

        private void staddress_KeyDown(object sender, KeyEventArgs e)
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

        private void stID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void stmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void fnametxt_KeyDown(object sender, KeyEventArgs e)
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
