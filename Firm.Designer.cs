namespace PLMS
{
    partial class Firm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.savbtn = new System.Windows.Forms.Button();
            this.regtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firmconttxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firmaddtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firmnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.removebtn = new System.Windows.Forms.Button();
            this.logopb = new System.Windows.Forms.PictureBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lp.SuspendLayout();
            this.rp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            this.SuspendLayout();
            // 
            // lp
            // 
            this.lp.Size = new System.Drawing.Size(250, 688);
            // 
            // rp
            // 
            this.rp.Controls.Add(this.label7);
            this.rp.Controls.Add(this.logopb);
            this.rp.Controls.Add(this.removebtn);
            this.rp.Controls.Add(this.savbtn);
            this.rp.Controls.Add(this.regtxt);
            this.rp.Controls.Add(this.label6);
            this.rp.Controls.Add(this.firmconttxt);
            this.rp.Controls.Add(this.label5);
            this.rp.Controls.Add(this.firmaddtxt);
            this.rp.Controls.Add(this.label4);
            this.rp.Controls.Add(this.firmnametxt);
            this.rp.Controls.Add(this.label3);
            this.rp.Controls.Add(this.resetbtn);
            this.rp.Size = new System.Drawing.Size(997, 688);
            this.rp.TabIndex = 0;
            this.rp.Controls.SetChildIndex(this.panel2, 0);
            this.rp.Controls.SetChildIndex(this.resetbtn, 0);
            this.rp.Controls.SetChildIndex(this.label3, 0);
            this.rp.Controls.SetChildIndex(this.firmnametxt, 0);
            this.rp.Controls.SetChildIndex(this.label4, 0);
            this.rp.Controls.SetChildIndex(this.firmaddtxt, 0);
            this.rp.Controls.SetChildIndex(this.label5, 0);
            this.rp.Controls.SetChildIndex(this.firmconttxt, 0);
            this.rp.Controls.SetChildIndex(this.label6, 0);
            this.rp.Controls.SetChildIndex(this.regtxt, 0);
            this.rp.Controls.SetChildIndex(this.savbtn, 0);
            this.rp.Controls.SetChildIndex(this.removebtn, 0);
            this.rp.Controls.SetChildIndex(this.logopb, 0);
            this.rp.Controls.SetChildIndex(this.label7, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.backbtn, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(997, 60);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(228, 0);
            this.label1.Size = new System.Drawing.Size(22, 60);
            this.label1.Text = "";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 0);
            this.label2.Size = new System.Drawing.Size(48, 60);
            this.label2.Text = "                       ";
            // 
            // savbtn
            // 
            this.savbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.savbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savbtn.ForeColor = System.Drawing.Color.White;
            this.savbtn.Location = new System.Drawing.Point(486, 554);
            this.savbtn.Name = "savbtn";
            this.savbtn.Size = new System.Drawing.Size(97, 41);
            this.savbtn.TabIndex = 4;
            this.savbtn.Text = "&Save";
            this.toolTip1.SetToolTip(this.savbtn, "Save Firm Data , Press Alt+S");
            this.savbtn.UseVisualStyleBackColor = false;
            this.savbtn.Click += new System.EventHandler(this.savbtn_Click);
            // 
            // regtxt
            // 
            this.regtxt.Enabled = false;
            this.regtxt.Location = new System.Drawing.Point(215, 479);
            this.regtxt.Multiline = true;
            this.regtxt.Name = "regtxt";
            this.regtxt.Size = new System.Drawing.Size(368, 35);
            this.regtxt.TabIndex = 3;
            this.regtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.regtxt_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(212, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Registration no. (if any..)";
            // 
            // firmconttxt
            // 
            this.firmconttxt.Enabled = false;
            this.firmconttxt.Location = new System.Drawing.Point(215, 395);
            this.firmconttxt.Multiline = true;
            this.firmconttxt.Name = "firmconttxt";
            this.firmconttxt.Size = new System.Drawing.Size(368, 35);
            this.firmconttxt.TabIndex = 2;
            this.firmconttxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firmconttxt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(212, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact";
            // 
            // firmaddtxt
            // 
            this.firmaddtxt.Enabled = false;
            this.firmaddtxt.Location = new System.Drawing.Point(215, 312);
            this.firmaddtxt.Multiline = true;
            this.firmaddtxt.Name = "firmaddtxt";
            this.firmaddtxt.Size = new System.Drawing.Size(368, 35);
            this.firmaddtxt.TabIndex = 1;
            this.firmaddtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firmaddtxt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(212, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // firmnametxt
            // 
            this.firmnametxt.Enabled = false;
            this.firmnametxt.Location = new System.Drawing.Point(215, 227);
            this.firmnametxt.Multiline = true;
            this.firmnametxt.Name = "firmnametxt";
            this.firmnametxt.Size = new System.Drawing.Size(368, 35);
            this.firmnametxt.TabIndex = 0;
            this.firmnametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firmnametxt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(212, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Firm Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.removebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.Location = new System.Drawing.Point(741, 340);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(100, 41);
            this.removebtn.TabIndex = 14;
            this.removebtn.Text = "&Remove";
            this.toolTip1.SetToolTip(this.removebtn, "Remove Logo , Press Alt+ R");
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // logopb
            // 
            this.logopb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logopb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logopb.Enabled = false;
            this.logopb.Image = global::PLMS.Properties.Resources.w;
            this.logopb.Location = new System.Drawing.Point(741, 209);
            this.logopb.Name = "logopb";
            this.logopb.Size = new System.Drawing.Size(100, 100);
            this.logopb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logopb.TabIndex = 15;
            this.logopb.TabStop = false;
            this.toolTip1.SetToolTip(this.logopb, "Click To Select Logo ");
            this.logopb.Click += new System.EventHandler(this.logopb_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resetbtn.BackgroundImage = global::PLMS.Properties.Resources.document_edit;
            this.resetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbtn.FlatAppearance.BorderSize = 0;
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbtn.ForeColor = System.Drawing.Color.Black;
            this.resetbtn.Location = new System.Drawing.Point(37, 188);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(111, 104);
            this.resetbtn.TabIndex = 5;
            this.resetbtn.Text = "&Edit";
            this.resetbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.resetbtn, "Edit , Press Alt+E");
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Visible = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 45);
            this.label7.TabIndex = 16;
            this.label7.Text = "Firm Registration Form";
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::PLMS.Properties.Resources.left_grey;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(0, 0);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(228, 60);
            this.backbtn.TabIndex = 1;
            this.toolTip1.SetToolTip(this.backbtn, "Back , Press Esc");
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Visible = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 688);
            this.KeyPreview = true;
            this.Name = "Firm";
            this.Text = "Firm Registration Form";
            this.Load += new System.EventHandler(this.Firm_Load);
            this.lp.ResumeLayout(false);
            this.rp.ResumeLayout(false);
            this.rp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.PictureBox logopb;
        private System.Windows.Forms.Button savbtn;
        private System.Windows.Forms.TextBox regtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firmconttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firmaddtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firmnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}