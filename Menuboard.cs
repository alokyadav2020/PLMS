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
    public partial class Menuboard : sample
    {
        public Menuboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student r = new Student();
            Maincalss.showwindow(r, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plan ur = new Plan();
            Maincalss.showwindow(ur, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Logingpage lp = new Logingpage();
            Maincalss.showwindow(lp, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdmissionForm af = new AdmissionForm();
            Maincalss.showwindow(af, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admissionhistory f = new Admissionhistory();
            Maincalss.showwindow(f,  MDI.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Setings t = new Setings();
            Maincalss.showwindow(t, MDI.ActiveForm);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //label2.Text = GlobClass.username;
            vslbl.Text = "Version : " + GlobClass.version;
            if (GlobClass.expiryDAY > 15) { expireylbl.Text = "Expire On : " + GlobClass.expirydate; } else { expireylbl.Text = "Expire On : " + GlobClass.expirydate;expireylbl.BackColor = Color.Red; }
            
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            StudentAccount st = new StudentAccount();
            Maincalss.showwindow(st, MDI.ActiveForm);
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            Expenses exp = new Expenses();
            Maincalss.showwindow(exp, MDI.ActiveForm);
        }

        private void studentinfobtn_Click(object sender, EventArgs e)
        {
            StudentInfo stinfo = new StudentInfo();
            Maincalss.showwindow(stinfo, MDI.ActiveForm);
        }

        private void planaccbtn_Click(object sender, EventArgs e)
        {
            Planstatics ps = new Planstatics();
            Maincalss.showwindow(ps, MDI.ActiveForm);
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            Maincalss.showwindow(dsh, MDI.ActiveForm);
        }
    }
}
