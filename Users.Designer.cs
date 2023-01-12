namespace PLMS
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.useremail = new System.Windows.Forms.TextBox();
            this.usermobtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.savrbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.g0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.lp.SuspendLayout();
            this.rp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Size = new System.Drawing.Size(871, 60);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // lp
            // 
            this.lp.Controls.Add(this.useremail);
            this.lp.Controls.Add(this.usermobtxt);
            this.lp.Controls.Add(this.label7);
            this.lp.Controls.Add(this.label6);
            this.lp.Controls.Add(this.label5);
            this.lp.Controls.Add(this.label4);
            this.lp.Controls.Add(this.passtxt);
            this.lp.Controls.Add(this.usernametxt);
            this.lp.Controls.Add(this.savrbtn);
            this.lp.Size = new System.Drawing.Size(250, 546);
            this.lp.Controls.SetChildIndex(this.panel1, 0);
            this.lp.Controls.SetChildIndex(this.savrbtn, 0);
            this.lp.Controls.SetChildIndex(this.usernametxt, 0);
            this.lp.Controls.SetChildIndex(this.passtxt, 0);
            this.lp.Controls.SetChildIndex(this.label4, 0);
            this.lp.Controls.SetChildIndex(this.label5, 0);
            this.lp.Controls.SetChildIndex(this.label6, 0);
            this.lp.Controls.SetChildIndex(this.label7, 0);
            this.lp.Controls.SetChildIndex(this.usermobtxt, 0);
            this.lp.Controls.SetChildIndex(this.useremail, 0);
            // 
            // rp
            // 
            this.rp.Controls.Add(this.dgvuser);
            this.rp.Size = new System.Drawing.Size(871, 546);
            this.rp.Controls.SetChildIndex(this.panel2, 0);
            this.rp.Controls.SetChildIndex(this.panel3, 0);
            this.rp.Controls.SetChildIndex(this.dgvuser, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(871, 60);
            // 
            // useremail
            // 
            this.useremail.Enabled = false;
            this.useremail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useremail.Location = new System.Drawing.Point(12, 411);
            this.useremail.Multiline = true;
            this.useremail.Name = "useremail";
            this.useremail.Size = new System.Drawing.Size(226, 29);
            this.useremail.TabIndex = 13;
            this.useremail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.useremail_KeyDown);
            // 
            // usermobtxt
            // 
            this.usermobtxt.Enabled = false;
            this.usermobtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usermobtxt.Location = new System.Drawing.Point(12, 350);
            this.usermobtxt.Multiline = true;
            this.usermobtxt.Name = "usermobtxt";
            this.usermobtxt.Size = new System.Drawing.Size(226, 29);
            this.usermobtxt.TabIndex = 12;
            this.usermobtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usermobtxt_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "User Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(13, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "User Mobile";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passtxt
            // 
            this.passtxt.Enabled = false;
            this.passtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(12, 284);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(226, 29);
            this.passtxt.TabIndex = 11;
            this.passtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passtxt_KeyDown);
            // 
            // usernametxt
            // 
            this.usernametxt.Enabled = false;
            this.usernametxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(12, 218);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(226, 29);
            this.usernametxt.TabIndex = 10;
            this.usernametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernametxt_KeyDown);
            // 
            // savrbtn
            // 
            this.savrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savrbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.savrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savrbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savrbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savrbtn.Location = new System.Drawing.Point(12, 462);
            this.savrbtn.Name = "savrbtn";
            this.savrbtn.Size = new System.Drawing.Size(226, 44);
            this.savrbtn.TabIndex = 14;
            this.savrbtn.Text = "&Save";
            this.savrbtn.UseVisualStyleBackColor = true;
            this.savrbtn.Click += new System.EventHandler(this.savrbtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.addbtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editbtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deletebtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.viewbtn, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbtn.Location = new System.Drawing.Point(3, 3);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(165, 54);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "&Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editbtn.Location = new System.Drawing.Point(174, 3);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(165, 54);
            this.editbtn.TabIndex = 1;
            this.editbtn.Text = "&Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebtn.Location = new System.Drawing.Point(345, 3);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(165, 54);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "&Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewbtn.Location = new System.Drawing.Point(516, 3);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(166, 54);
            this.viewbtn.TabIndex = 3;
            this.viewbtn.Text = "&View";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // dgvuser
            // 
            this.dgvuser.AllowUserToAddRows = false;
            this.dgvuser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvuser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuser.BackgroundColor = System.Drawing.Color.White;
            this.dgvuser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvuser.ColumnHeadersHeight = 35;
            this.dgvuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g0,
            this.g1,
            this.g2,
            this.g3,
            this.g4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvuser.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvuser.EnableHeadersVisualStyles = false;
            this.dgvuser.Location = new System.Drawing.Point(0, 120);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.ReadOnly = true;
            this.dgvuser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvuser.RowHeadersVisible = false;
            this.dgvuser.RowHeadersWidth = 30;
            this.dgvuser.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvuser.RowTemplate.Height = 100;
            this.dgvuser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvuser.Size = new System.Drawing.Size(871, 426);
            this.dgvuser.TabIndex = 3;
            this.dgvuser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvuser_CellDoubleClick);
            // 
            // g0
            // 
            this.g0.HeaderText = "ID";
            this.g0.Name = "g0";
            this.g0.ReadOnly = true;
            this.g0.Visible = false;
            // 
            // g1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g1.DefaultCellStyle = dataGridViewCellStyle2;
            this.g1.FillWeight = 107.8173F;
            this.g1.HeaderText = "UserName ";
            this.g1.Name = "g1";
            this.g1.ReadOnly = true;
            // 
            // g2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g2.DefaultCellStyle = dataGridViewCellStyle3;
            this.g2.FillWeight = 107.8173F;
            this.g2.HeaderText = "Password";
            this.g2.Name = "g2";
            this.g2.ReadOnly = true;
            // 
            // g3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g3.DefaultCellStyle = dataGridViewCellStyle4;
            this.g3.FillWeight = 107.8173F;
            this.g3.HeaderText = "User Mobile";
            this.g3.Name = "g3";
            this.g3.ReadOnly = true;
            // 
            // g4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g4.DefaultCellStyle = dataGridViewCellStyle5;
            this.g4.FillWeight = 107.8173F;
            this.g4.HeaderText = "User Email";
            this.g4.Name = "g4";
            this.g4.ReadOnly = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 546);
            this.Name = "Users";
            this.Text = "Users";
            this.panel3.ResumeLayout(false);
            this.lp.ResumeLayout(false);
            this.lp.PerformLayout();
            this.rp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox useremail;
        private System.Windows.Forms.TextBox usermobtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Button savrbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn g0;
        private System.Windows.Forms.DataGridViewTextBoxColumn g1;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2;
        private System.Windows.Forms.DataGridViewTextBoxColumn g3;
        private System.Windows.Forms.DataGridViewTextBoxColumn g4;
    }
}