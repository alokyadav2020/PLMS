namespace PLMS
{
    partial class CreatExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bacbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.edectxt = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.epricetxt = new System.Windows.Forms.TextBox();
            this.enametxt = new System.Windows.Forms.TextBox();
            this.savrbtn = new System.Windows.Forms.Button();
            this.dgvexp = new System.Windows.Forms.DataGridView();
            this.g0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lp.SuspendLayout();
            this.rp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexp)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lp
            // 
            this.lp.Controls.Add(this.edectxt);
            this.lp.Controls.Add(this.lable);
            this.lp.Controls.Add(this.label5);
            this.lp.Controls.Add(this.label4);
            this.lp.Controls.Add(this.epricetxt);
            this.lp.Controls.Add(this.enametxt);
            this.lp.Controls.Add(this.savrbtn);
            this.lp.Size = new System.Drawing.Size(250, 536);
            this.lp.Controls.SetChildIndex(this.panel1, 0);
            this.lp.Controls.SetChildIndex(this.savrbtn, 0);
            this.lp.Controls.SetChildIndex(this.enametxt, 0);
            this.lp.Controls.SetChildIndex(this.epricetxt, 0);
            this.lp.Controls.SetChildIndex(this.label4, 0);
            this.lp.Controls.SetChildIndex(this.label5, 0);
            this.lp.Controls.SetChildIndex(this.lable, 0);
            this.lp.Controls.SetChildIndex(this.edectxt, 0);
            // 
            // rp
            // 
            this.rp.Controls.Add(this.dgvexp);
            this.rp.Controls.Add(this.panel3);
            this.rp.Size = new System.Drawing.Size(793, 536);
            this.rp.Controls.SetChildIndex(this.panel2, 0);
            this.rp.Controls.SetChildIndex(this.panel3, 0);
            this.rp.Controls.SetChildIndex(this.dgvexp, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bacbtn);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.bacbtn, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Size = new System.Drawing.Size(793, 60);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(240, 0);
            this.label1.Size = new System.Drawing.Size(10, 60);
            this.label1.Text = "";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(24, 60);
            this.label2.Text = "";
            // 
            // bacbtn
            // 
            this.bacbtn.BackgroundImage = global::PLMS.Properties.Resources.left_grey;
            this.bacbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bacbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bacbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bacbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bacbtn.FlatAppearance.BorderSize = 0;
            this.bacbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bacbtn.Location = new System.Drawing.Point(0, 0);
            this.bacbtn.Name = "bacbtn";
            this.bacbtn.Size = new System.Drawing.Size(240, 60);
            this.bacbtn.TabIndex = 1;
            this.bacbtn.UseVisualStyleBackColor = true;
            this.bacbtn.Click += new System.EventHandler(this.bacbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 60);
            this.panel3.TabIndex = 1;
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
            this.addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
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
            // edectxt
            // 
            this.edectxt.Enabled = false;
            this.edectxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edectxt.Location = new System.Drawing.Point(12, 334);
            this.edectxt.Multiline = true;
            this.edectxt.Name = "edectxt";
            this.edectxt.Size = new System.Drawing.Size(226, 29);
            this.edectxt.TabIndex = 12;
            this.edectxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edectxt_KeyDown);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lable.Location = new System.Drawing.Point(13, 314);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(74, 17);
            this.lable.TabIndex = 7;
            this.lable.Text = "Descrpition";
            this.lable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expense Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // epricetxt
            // 
            this.epricetxt.Enabled = false;
            this.epricetxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epricetxt.Location = new System.Drawing.Point(12, 268);
            this.epricetxt.Multiline = true;
            this.epricetxt.Name = "epricetxt";
            this.epricetxt.Size = new System.Drawing.Size(226, 29);
            this.epricetxt.TabIndex = 11;
            this.epricetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.epricetxt_KeyDown);
            this.epricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epricetxt_KeyPress);
            // 
            // enametxt
            // 
            this.enametxt.Enabled = false;
            this.enametxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enametxt.Location = new System.Drawing.Point(12, 202);
            this.enametxt.Multiline = true;
            this.enametxt.Name = "enametxt";
            this.enametxt.Size = new System.Drawing.Size(226, 29);
            this.enametxt.TabIndex = 10;
            this.enametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enametxt_KeyDown);
            // 
            // savrbtn
            // 
            this.savrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savrbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.savrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savrbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savrbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savrbtn.Location = new System.Drawing.Point(12, 394);
            this.savrbtn.Name = "savrbtn";
            this.savrbtn.Size = new System.Drawing.Size(226, 44);
            this.savrbtn.TabIndex = 14;
            this.savrbtn.Text = "&Save";
            this.savrbtn.UseVisualStyleBackColor = true;
            this.savrbtn.Click += new System.EventHandler(this.savrbtn_Click);
            // 
            // dgvexp
            // 
            this.dgvexp.AllowUserToAddRows = false;
            this.dgvexp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvexp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvexp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvexp.BackgroundColor = System.Drawing.Color.White;
            this.dgvexp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvexp.ColumnHeadersHeight = 35;
            this.dgvexp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g0,
            this.g1,
            this.g2,
            this.g3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvexp.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvexp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvexp.EnableHeadersVisualStyles = false;
            this.dgvexp.Location = new System.Drawing.Point(0, 120);
            this.dgvexp.Name = "dgvexp";
            this.dgvexp.ReadOnly = true;
            this.dgvexp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvexp.RowHeadersVisible = false;
            this.dgvexp.RowHeadersWidth = 30;
            this.dgvexp.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvexp.RowTemplate.Height = 30;
            this.dgvexp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvexp.Size = new System.Drawing.Size(793, 416);
            this.dgvexp.TabIndex = 3;
            this.dgvexp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexp_CellDoubleClick);
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
            this.g1.HeaderText = "Expense Name ";
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
            this.g2.HeaderText = "Price";
            this.g2.Name = "g2";
            this.g2.ReadOnly = true;
            // 
            // g3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g3.DefaultCellStyle = dataGridViewCellStyle4;
            this.g3.FillWeight = 107.8173F;
            this.g3.HeaderText = "Description";
            this.g3.Name = "g3";
            this.g3.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(371, 60);
            this.label7.TabIndex = 0;
            this.label7.Text = "Create Expense Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(416, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(377, 60);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // CreatExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bacbtn;
            this.ClientSize = new System.Drawing.Size(1043, 536);
            this.Name = "CreatExpenses";
            this.Text = "Expenses Name";
            this.lp.ResumeLayout(false);
            this.lp.PerformLayout();
            this.rp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexp)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bacbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.TextBox edectxt;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epricetxt;
        private System.Windows.Forms.TextBox enametxt;
        private System.Windows.Forms.Button savrbtn;
        private System.Windows.Forms.DataGridView dgvexp;
        private System.Windows.Forms.DataGridViewTextBoxColumn g0;
        private System.Windows.Forms.DataGridViewTextBoxColumn g1;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2;
        private System.Windows.Forms.DataGridViewTextBoxColumn g3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
    }
}