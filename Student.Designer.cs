namespace PLMS
{
    partial class Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.savrbtn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.g0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.studentpic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stname = new System.Windows.Forms.TextBox();
            this.stID = new System.Windows.Forms.TextBox();
            this.stmobile = new System.Windows.Forms.TextBox();
            this.staddress = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.countlbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.lp.SuspendLayout();
            this.rp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchtxt);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Size = new System.Drawing.Size(1100, 60);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PLMS.Properties.Resources.left_grey;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.toolTip1.SetToolTip(this.button1, "Back");
            // 
            // lp
            // 
            this.lp.Controls.Add(this.staddress);
            this.lp.Controls.Add(this.stmobile);
            this.lp.Controls.Add(this.label7);
            this.lp.Controls.Add(this.label6);
            this.lp.Controls.Add(this.label5);
            this.lp.Controls.Add(this.label8);
            this.lp.Controls.Add(this.label4);
            this.lp.Controls.Add(this.stID);
            this.lp.Controls.Add(this.studentpic);
            this.lp.Controls.Add(this.fnametxt);
            this.lp.Controls.Add(this.stname);
            this.lp.Controls.Add(this.savrbtn);
            this.lp.Size = new System.Drawing.Size(250, 694);
            this.lp.Controls.SetChildIndex(this.savrbtn, 0);
            this.lp.Controls.SetChildIndex(this.panel1, 0);
            this.lp.Controls.SetChildIndex(this.stname, 0);
            this.lp.Controls.SetChildIndex(this.fnametxt, 0);
            this.lp.Controls.SetChildIndex(this.studentpic, 0);
            this.lp.Controls.SetChildIndex(this.stID, 0);
            this.lp.Controls.SetChildIndex(this.label4, 0);
            this.lp.Controls.SetChildIndex(this.label8, 0);
            this.lp.Controls.SetChildIndex(this.label5, 0);
            this.lp.Controls.SetChildIndex(this.label6, 0);
            this.lp.Controls.SetChildIndex(this.label7, 0);
            this.lp.Controls.SetChildIndex(this.stmobile, 0);
            this.lp.Controls.SetChildIndex(this.staddress, 0);
            // 
            // rp
            // 
            this.rp.Controls.Add(this.dgv);
            this.rp.Size = new System.Drawing.Size(1100, 694);
            this.rp.Controls.SetChildIndex(this.panel2, 0);
            this.rp.Controls.SetChildIndex(this.panel3, 0);
            this.rp.Controls.SetChildIndex(this.dgv, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.countlbl);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Size = new System.Drawing.Size(1100, 60);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.panel2.Controls.SetChildIndex(this.countlbl, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Size = new System.Drawing.Size(85, 51);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.None;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Size = new System.Drawing.Size(31, 20);
            // 
            // savrbtn
            // 
            this.savrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savrbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.savrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savrbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savrbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savrbtn.Location = new System.Drawing.Point(12, 600);
            this.savrbtn.Name = "savrbtn";
            this.savrbtn.Size = new System.Drawing.Size(226, 44);
            this.savrbtn.TabIndex = 5;
            this.savrbtn.Text = "&Save";
            this.savrbtn.UseVisualStyleBackColor = true;
            this.savrbtn.Click += new System.EventHandler(this.savrbtn_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g0,
            this.g1,
            this.g6,
            this.g2,
            this.g3,
            this.g4,
            this.g5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(0, 120);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgv.RowTemplate.Height = 100;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1100, 574);
            this.dgv.TabIndex = 2;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
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
            this.g1.HeaderText = "Student Name ";
            this.g1.Name = "g1";
            this.g1.ReadOnly = true;
            // 
            // g6
            // 
            this.g6.HeaderText = "Father Name";
            this.g6.Name = "g6";
            this.g6.ReadOnly = true;
            // 
            // g2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g2.DefaultCellStyle = dataGridViewCellStyle3;
            this.g2.FillWeight = 107.8173F;
            this.g2.HeaderText = "Sutent ID";
            this.g2.Name = "g2";
            this.g2.ReadOnly = true;
            // 
            // g3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g3.DefaultCellStyle = dataGridViewCellStyle4;
            this.g3.FillWeight = 107.8173F;
            this.g3.HeaderText = "Student Mobile";
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
            this.g4.HeaderText = "Student Address";
            this.g4.Name = "g4";
            this.g4.ReadOnly = true;
            // 
            // g5
            // 
            this.g5.FillWeight = 107.8173F;
            this.g5.HeaderText = "Photo";
            this.g5.Name = "g5";
            this.g5.ReadOnly = true;
            this.g5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.g5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundImage = global::PLMS.Properties.Resources.search;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchbtn.Location = new System.Drawing.Point(1000, 14);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(33, 29);
            this.searchbtn.TabIndex = 1;
            this.toolTip1.SetToolTip(this.searchbtn, "Search");
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(806, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Student Form";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.editbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.deletebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.viewbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(758, 14);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(226, 29);
            this.searchtxt.TabIndex = 0;
            // 
            // studentpic
            // 
            this.studentpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentpic.Enabled = false;
            this.studentpic.Image = global::PLMS.Properties.Resources.contact;
            this.studentpic.Location = new System.Drawing.Point(72, 87);
            this.studentpic.Name = "studentpic";
            this.studentpic.Size = new System.Drawing.Size(117, 123);
            this.studentpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.studentpic.TabIndex = 2;
            this.studentpic.TabStop = false;
            this.toolTip1.SetToolTip(this.studentpic, "Click here to select photo");
            this.studentpic.Click += new System.EventHandler(this.studentpic_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student Mobile";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stname
            // 
            this.stname.Enabled = false;
            this.stname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stname.Location = new System.Drawing.Point(12, 251);
            this.stname.Multiline = true;
            this.stname.Name = "stname";
            this.stname.Size = new System.Drawing.Size(226, 29);
            this.stname.TabIndex = 0;
            this.stname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stname_KeyDown);
            this.stname.Leave += new System.EventHandler(this.stname_Leave);
            // 
            // stID
            // 
            this.stID.Enabled = false;
            this.stID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stID.Location = new System.Drawing.Point(12, 383);
            this.stID.Multiline = true;
            this.stID.Name = "stID";
            this.stID.Size = new System.Drawing.Size(226, 29);
            this.stID.TabIndex = 2;
            this.stID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stID_KeyDown);
            this.stID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stID_KeyPress);
            // 
            // stmobile
            // 
            this.stmobile.Enabled = false;
            this.stmobile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmobile.Location = new System.Drawing.Point(12, 449);
            this.stmobile.Multiline = true;
            this.stmobile.Name = "stmobile";
            this.stmobile.Size = new System.Drawing.Size(226, 29);
            this.stmobile.TabIndex = 3;
            this.stmobile.TextChanged += new System.EventHandler(this.stmobile_TextChanged);
            this.stmobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stmobile_KeyDown);
            this.stmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stmobile_KeyPress);
            // 
            // staddress
            // 
            this.staddress.Enabled = false;
            this.staddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staddress.Location = new System.Drawing.Point(12, 515);
            this.staddress.Multiline = true;
            this.staddress.Name = "staddress";
            this.staddress.Size = new System.Drawing.Size(226, 75);
            this.staddress.TabIndex = 4;
            this.staddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.staddress_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fnametxt
            // 
            this.fnametxt.Enabled = false;
            this.fnametxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(12, 317);
            this.fnametxt.Multiline = true;
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(226, 29);
            this.fnametxt.TabIndex = 1;
            this.fnametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fnametxt_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Father  name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countlbl
            // 
            this.countlbl.AutoSize = true;
            this.countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.countlbl.Location = new System.Drawing.Point(175, 19);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(145, 25);
            this.countlbl.TabIndex = 3;
            this.countlbl.Text = "Total Student ?";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1350, 694);
            this.KeyPreview = true;
            this.Name = "Student";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.Rolls_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.lp.ResumeLayout(false);
            this.lp.PerformLayout();
            this.rp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button savrbtn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox studentpic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stname;
        private System.Windows.Forms.TextBox stID;
        private System.Windows.Forms.TextBox stmobile;
        private System.Windows.Forms.TextBox staddress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn g0;
        private System.Windows.Forms.DataGridViewTextBoxColumn g1;
        private System.Windows.Forms.DataGridViewTextBoxColumn g6;
        private System.Windows.Forms.DataGridViewTextBoxColumn g2;
        private System.Windows.Forms.DataGridViewTextBoxColumn g3;
        private System.Windows.Forms.DataGridViewTextBoxColumn g4;
        private System.Windows.Forms.DataGridViewImageColumn g5;
        private System.Windows.Forms.Label countlbl;
    }
}