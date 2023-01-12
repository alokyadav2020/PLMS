namespace PLMS
{
    partial class Setings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setings));
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.termbtn = new System.Windows.Forms.Button();
            this.userbtn = new System.Windows.Forms.Button();
            this.restoredbbtn = new System.Windows.Forms.Button();
            this.Restoredb = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.cdbbtn = new System.Windows.Forms.Button();
            this.Expirybtn = new System.Windows.Forms.Button();
            this.backnf = new System.Windows.Forms.NotifyIcon(this.components);
            this.restornf = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.propercetacelbl = new System.Windows.Forms.Label();
            this.vertlp = new System.Windows.Forms.TableLayoutPanel();
            this.olderlbl = new System.Windows.Forms.Label();
            this.currentlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.lp.SuspendLayout();
            this.rp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.vertlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.propercetacelbl);
            this.panel3.Size = new System.Drawing.Size(953, 60);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // lp
            // 
            this.lp.Controls.Add(this.vertlp);
            this.lp.Size = new System.Drawing.Size(250, 683);
            this.lp.Controls.SetChildIndex(this.panel1, 0);
            this.lp.Controls.SetChildIndex(this.vertlp, 0);
            // 
            // rp
            // 
            this.rp.Controls.Add(this.tableLayoutPanel2);
            this.rp.Size = new System.Drawing.Size(953, 683);
            this.rp.Controls.SetChildIndex(this.panel2, 0);
            this.rp.Controls.SetChildIndex(this.panel3, 0);
            this.rp.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Size = new System.Drawing.Size(953, 60);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.panel2.Controls.SetChildIndex(this.progressBar1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 60);
            this.label3.TabIndex = 1;
            this.label3.Text = "Settings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(753, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.termbtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.userbtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.restoredbbtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Restoredb, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.updatebtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cdbbtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Expirybtn, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(953, 563);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PLMS.Properties.Resources.library;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 134);
            this.button2.TabIndex = 1;
            this.button2.Text = "Firm Registration";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // termbtn
            // 
            this.termbtn.BackgroundImage = global::PLMS.Properties.Resources._new;
            this.termbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.termbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.termbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.termbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.termbtn.Location = new System.Drawing.Point(383, 3);
            this.termbtn.Name = "termbtn";
            this.termbtn.Size = new System.Drawing.Size(184, 134);
            this.termbtn.TabIndex = 0;
            this.termbtn.Text = "Term\'s And Condition";
            this.termbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.termbtn.UseVisualStyleBackColor = true;
            this.termbtn.Click += new System.EventHandler(this.termbtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.BackgroundImage = global::PLMS.Properties.Resources.adduser;
            this.userbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userbtn.Location = new System.Drawing.Point(193, 3);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(184, 134);
            this.userbtn.TabIndex = 0;
            this.userbtn.Text = "User";
            this.userbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userbtn.UseVisualStyleBackColor = true;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // restoredbbtn
            // 
            this.restoredbbtn.BackgroundImage = global::PLMS.Properties.Resources.dd;
            this.restoredbbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.restoredbbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoredbbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restoredbbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.restoredbbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoredbbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restoredbbtn.Location = new System.Drawing.Point(573, 3);
            this.restoredbbtn.Name = "restoredbbtn";
            this.restoredbbtn.Size = new System.Drawing.Size(184, 134);
            this.restoredbbtn.TabIndex = 2;
            this.restoredbbtn.Text = "Backup Database";
            this.restoredbbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.restoredbbtn.UseVisualStyleBackColor = true;
            this.restoredbbtn.Click += new System.EventHandler(this.restoredbbtn_Click);
            // 
            // Restoredb
            // 
            this.Restoredb.BackgroundImage = global::PLMS.Properties.Resources.du;
            this.Restoredb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Restoredb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restoredb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Restoredb.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Restoredb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restoredb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Restoredb.Location = new System.Drawing.Point(763, 3);
            this.Restoredb.Name = "Restoredb";
            this.Restoredb.Size = new System.Drawing.Size(187, 134);
            this.Restoredb.TabIndex = 2;
            this.Restoredb.Text = "Restore Database";
            this.Restoredb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Restoredb.UseVisualStyleBackColor = true;
            this.Restoredb.Click += new System.EventHandler(this.Restoredb_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updatebtn.Image = global::PLMS.Properties.Resources.softupdate;
            this.updatebtn.Location = new System.Drawing.Point(3, 143);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(184, 134);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.Text = "Update";
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // cdbbtn
            // 
            this.cdbbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdbbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdbbtn.Location = new System.Drawing.Point(383, 143);
            this.cdbbtn.Name = "cdbbtn";
            this.cdbbtn.Size = new System.Drawing.Size(184, 134);
            this.cdbbtn.TabIndex = 2;
            this.cdbbtn.Text = "Create Database";
            this.cdbbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cdbbtn.UseVisualStyleBackColor = true;
            this.cdbbtn.Visible = false;
            this.cdbbtn.Click += new System.EventHandler(this.cdbbtn_Click);
            // 
            // Expirybtn
            // 
            this.Expirybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expirybtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Expirybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expirybtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Expirybtn.Image = global::PLMS.Properties.Resources.expiry;
            this.Expirybtn.Location = new System.Drawing.Point(193, 143);
            this.Expirybtn.Name = "Expirybtn";
            this.Expirybtn.Size = new System.Drawing.Size(184, 134);
            this.Expirybtn.TabIndex = 2;
            this.Expirybtn.Text = "Softeware Expiry";
            this.Expirybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Expirybtn.UseVisualStyleBackColor = true;
            this.Expirybtn.Click += new System.EventHandler(this.Expirybtn_Click);
            // 
            // backnf
            // 
            this.backnf.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.backnf.BalloonTipText = "Database Backup Successfully";
            this.backnf.BalloonTipTitle = "Success";
            this.backnf.Icon = ((System.Drawing.Icon)(resources.GetObject("backnf.Icon")));
            this.backnf.Text = "Backup Database";
            this.backnf.Visible = true;
            // 
            // restornf
            // 
            this.restornf.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.restornf.BalloonTipText = "Database Restore Successfully";
            this.restornf.BalloonTipTitle = "Success";
            this.restornf.Icon = ((System.Drawing.Icon)(resources.GetObject("restornf.Icon")));
            this.restornf.Text = "Restore";
            this.restornf.Visible = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(295, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(364, 38);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // propercetacelbl
            // 
            this.propercetacelbl.AutoSize = true;
            this.propercetacelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propercetacelbl.Location = new System.Drawing.Point(61, 19);
            this.propercetacelbl.Name = "propercetacelbl";
            this.propercetacelbl.Size = new System.Drawing.Size(201, 25);
            this.propercetacelbl.TabIndex = 3;
            this.propercetacelbl.Text = "Database file selection";
            this.propercetacelbl.Visible = false;
            // 
            // vertlp
            // 
            this.vertlp.BackColor = System.Drawing.Color.Red;
            this.vertlp.ColumnCount = 1;
            this.vertlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vertlp.Controls.Add(this.olderlbl, 0, 0);
            this.vertlp.Controls.Add(this.currentlbl, 0, 1);
            this.vertlp.Controls.Add(this.label6, 0, 2);
            this.vertlp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vertlp.Location = new System.Drawing.Point(0, 539);
            this.vertlp.Name = "vertlp";
            this.vertlp.RowCount = 3;
            this.vertlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.vertlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.vertlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.vertlp.Size = new System.Drawing.Size(250, 144);
            this.vertlp.TabIndex = 1;
            this.vertlp.Visible = false;
            // 
            // olderlbl
            // 
            this.olderlbl.AutoSize = true;
            this.olderlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olderlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.olderlbl.Location = new System.Drawing.Point(3, 0);
            this.olderlbl.Name = "olderlbl";
            this.olderlbl.Size = new System.Drawing.Size(244, 48);
            this.olderlbl.TabIndex = 0;
            this.olderlbl.Text = "label4";
            this.olderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentlbl
            // 
            this.currentlbl.AutoSize = true;
            this.currentlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentlbl.Location = new System.Drawing.Point(3, 48);
            this.currentlbl.Name = "currentlbl";
            this.currentlbl.Size = new System.Drawing.Size(244, 48);
            this.currentlbl.TabIndex = 0;
            this.currentlbl.Text = "label4";
            this.currentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(3, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 48);
            this.label6.TabIndex = 0;
            this.label6.Text = "Your Software Out of date , Need to UPDATE software ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Setings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1203, 683);
            this.Name = "Setings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Setings_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.lp.ResumeLayout(false);
            this.rp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.vertlp.ResumeLayout(false);
            this.vertlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button termbtn;
        private System.Windows.Forms.Button userbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cdbbtn;
        private System.Windows.Forms.Button restoredbbtn;
        private System.Windows.Forms.Button Restoredb;
        public System.Windows.Forms.NotifyIcon backnf;
        public System.Windows.Forms.NotifyIcon restornf;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Expirybtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label propercetacelbl;
        private System.Windows.Forms.TableLayoutPanel vertlp;
        private System.Windows.Forms.Label olderlbl;
        private System.Windows.Forms.Label currentlbl;
        private System.Windows.Forms.Label label6;
    }
}