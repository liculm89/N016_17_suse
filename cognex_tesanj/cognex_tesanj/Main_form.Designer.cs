namespace cognex_tesanj
{
    partial class Main_form
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
            this.open_viewer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataManSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRes = new System.Windows.Forms.Label();
            this.DMcode = new System.Windows.Forms.TextBox();
            this.testTrigger = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resPic = new System.Windows.Forms.PictureBox();
            this.LivePic = new System.Windows.Forms.PictureBox();
            this.cbLiveDisplay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TriggerTimer = new System.Windows.Forms.Timer(this.components);
            this.startAuto = new System.Windows.Forms.Button();
            this.stopAuto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivePic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_viewer
            // 
            this.open_viewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.open_viewer.Location = new System.Drawing.Point(851, 529);
            this.open_viewer.Name = "open_viewer";
            this.open_viewer.Size = new System.Drawing.Size(192, 47);
            this.open_viewer.TabIndex = 4;
            this.open_viewer.Text = "Uređivanje arhive";
            this.open_viewer.UseVisualStyleBackColor = true;
            this.open_viewer.Click += new System.EventHandler(this.open_viewer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(851, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Postavke Čitača";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataManSettingsToolStripMenuItem,
            this.databaseSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // dataManSettingsToolStripMenuItem
            // 
            this.dataManSettingsToolStripMenuItem.Name = "dataManSettingsToolStripMenuItem";
            this.dataManSettingsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dataManSettingsToolStripMenuItem.Text = "DataMan settings";
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Database settings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 345);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblRes
            // 
            this.lblRes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRes.Location = new System.Drawing.Point(7, 139);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(126, 25);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "Očitani kod:";
            // 
            // DMcode
            // 
            this.DMcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DMcode.Location = new System.Drawing.Point(135, 136);
            this.DMcode.Name = "DMcode";
            this.DMcode.Size = new System.Drawing.Size(224, 31);
            this.DMcode.TabIndex = 9;
            this.DMcode.TextChanged += new System.EventHandler(this.DMcode_TextChanged_1);
            // 
            // testTrigger
            // 
            this.testTrigger.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.testTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testTrigger.Location = new System.Drawing.Point(379, 505);
            this.testTrigger.Name = "testTrigger";
            this.testTrigger.Size = new System.Drawing.Size(184, 42);
            this.testTrigger.TabIndex = 10;
            this.testTrigger.Text = "Test Trigger";
            this.testTrigger.UseVisualStyleBackColor = false;
            this.testTrigger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testTrigger_MouseDown);
            this.testTrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.testTrigger_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(569, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Poništi očitanje";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // resPic
            // 
            this.resPic.Location = new System.Drawing.Point(25, 173);
            this.resPic.Name = "resPic";
            this.resPic.Size = new System.Drawing.Size(328, 230);
            this.resPic.TabIndex = 12;
            this.resPic.TabStop = false;
            // 
            // LivePic
            // 
            this.LivePic.Location = new System.Drawing.Point(25, 409);
            this.LivePic.Name = "LivePic";
            this.LivePic.Size = new System.Drawing.Size(328, 221);
            this.LivePic.TabIndex = 13;
            this.LivePic.TabStop = false;
            // 
            // cbLiveDisplay
            // 
            this.cbLiveDisplay.AutoSize = true;
            this.cbLiveDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLiveDisplay.Location = new System.Drawing.Point(377, 559);
            this.cbLiveDisplay.Name = "cbLiveDisplay";
            this.cbLiveDisplay.Size = new System.Drawing.Size(108, 24);
            this.cbLiveDisplay.TabIndex = 14;
            this.cbLiveDisplay.Text = "Live display";
            this.cbLiveDisplay.UseVisualStyleBackColor = true;
            this.cbLiveDisplay.CheckedChanged += new System.EventHandler(this.cbLiveDisplay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filter DM koda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(217, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 31);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(371, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 472);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz arhive";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1053, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // TriggerTimer
            // 
            this.TriggerTimer.Interval = 2010;
            this.TriggerTimer.Tick += new System.EventHandler(this.TriggerTimer_Tick);
            // 
            // startAuto
            // 
            this.startAuto.BackColor = System.Drawing.Color.LightGreen;
            this.startAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startAuto.Location = new System.Drawing.Point(12, 19);
            this.startAuto.Name = "startAuto";
            this.startAuto.Size = new System.Drawing.Size(347, 50);
            this.startAuto.TabIndex = 20;
            this.startAuto.Text = "Pokreni automatsko čitanje koda";
            this.startAuto.UseVisualStyleBackColor = false;
            this.startAuto.Click += new System.EventHandler(this.startAuto_Click);
            // 
            // stopAuto
            // 
            this.stopAuto.BackColor = System.Drawing.Color.OrangeRed;
            this.stopAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopAuto.Location = new System.Drawing.Point(12, 75);
            this.stopAuto.Name = "stopAuto";
            this.stopAuto.Size = new System.Drawing.Size(347, 49);
            this.stopAuto.TabIndex = 21;
            this.stopAuto.Text = "Zaustavi automatsko čitanje koda";
            this.stopAuto.UseVisualStyleBackColor = false;
            this.stopAuto.Click += new System.EventHandler(this.stopAuto_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(8, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 55);
            this.button3.TabIndex = 18;
            this.button3.Text = "Osvježi arhivu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(199, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 55);
            this.button4.TabIndex = 19;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startAuto);
            this.groupBox2.Controls.Add(this.stopAuto);
            this.groupBox2.Controls.Add(this.lblRes);
            this.groupBox2.Controls.Add(this.DMcode);
            this.groupBox2.Controls.Add(this.LivePic);
            this.groupBox2.Controls.Add(this.resPic);
            this.groupBox2.Location = new System.Drawing.Point(0, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 635);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dataman";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbLiveDisplay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testTrigger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.open_viewer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.Text = "Datamatrix ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_form_FormClosing);
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivePic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button open_viewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataManSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button testTrigger;
        public System.Windows.Forms.TextBox DMcode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.PictureBox resPic;
        private System.Windows.Forms.PictureBox LivePic;
        private System.Windows.Forms.CheckBox cbLiveDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer TriggerTimer;
        private System.Windows.Forms.Button startAuto;
        private System.Windows.Forms.Button stopAuto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

