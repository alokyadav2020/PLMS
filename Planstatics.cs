using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLMS.All_Class;
using PLMS.Properties;

namespace PLMS
{
    public partial class Planstatics : sample
    {
        public Planstatics()
        {
            InitializeComponent();
        }                
        private void vpbtn_Click(object sender, EventArgs e)
        {
            GetData gd = new GetData();
            gd.getplandetail(dgv1, d0, d1);
            dgv1.ClearSelection();
            dgv2.ClearSelection();
            plannolbl.Text = dgv1.Rows.Count.ToString();
            printbtn.Visible = false;
            Maincalss.CDGVR(dgv2);
            if (dgv2.Rows.Count > 0) { gd.getsumplan(tsnlbl, palbl, tpalbl, tualbl); } else { tsnlbl.Text = "0.00"; palbl.Text = "0.00"; tpalbl.Text = "0.00"; tualbl.Text = "0.00"; }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                try
                {
                    GlobClass.planid = Convert.ToInt32(dgv1.SelectedRows[0].Cells[0].Value);
                    GetData gd = new GetData();
                    gd.getplanstat(dgv2, g0, g1, g2, g3, g4, g5, g6,g7);
                    if (dgv2.Rows.Count > 0) { gd.getsumplan(tsnlbl, palbl, tpalbl, tualbl); } else { tsnlbl.Text = "0.00";palbl.Text = "0.00";tpalbl.Text = "0.00";tualbl.Text = "0.00"; }                    
                    dgv2.ClearSelection();
                    printbtn.Visible = false;
                    cellcolorcount();
                }
                catch (Exception)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menuboard dsb = new Menuboard();           
            Maincalss.showwindow(dsb, this, MDI.ActiveForm);
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (GlobClass.idforprint > 0)
            {
                GetData gd = new GetData();
                gd.getpriintid();
                PrintDoc printd = new PrintDoc();
                GlobClass.checkprint = 0;
                printd.print4page();
                GlobClass.checkprint = 1;
                GlobClass.idforprint = 0;
                dgv2.ClearSelection();
                printbtn.Visible = false;
            }
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv2.Rows.Count > 0)
            {
                try
                {
                    GlobClass.idforprint = Convert.ToInt32(dgv2.SelectedRows[0].Cells[0].Value);
                    printbtn.Visible = true;
                }
                catch (Exception)
                {
                    
                }
            }
        }

        void cellcolorcount()
        {
            if (dgv2.Rows.Count > 0)
            {
                for (int i = 0; i < dgv2.Rows.Count; i++)
                {
                    int sum = Convert.ToInt32(dgv2.Rows[i].Cells[6].Value);
                    if (sum > 0)
                    {
                        dgv2.Rows[i].Cells[6].Style.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
