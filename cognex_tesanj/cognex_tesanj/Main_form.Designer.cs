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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivePic)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_viewer
            // 
            this.open_viewer.Location = new System.Drawing.Point(29, 27);
            this.open_viewer.Name = "open_viewer";
            this.open_viewer.Size = new System.Drawing.Size(192, 23);
            this.open_viewer.TabIndex = 4;
            this.open_viewer.Text = "Open database editor";
            this.open_viewer.UseVisualStyleBackColor = true;
            this.open_viewer.Click += new System.EventHandler(this.open_viewer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "DataMan Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
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
            this.dataGridView1.Location = new System.Drawing.Point(334, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 414);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblRes
            // 
            this.lblRes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(26, 135);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(64, 13);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "Očitani kod:";
            // 
            // DMcode
            // 
            this.DMcode.Location = new System.Drawing.Point(96, 132);
            this.DMcode.Name = "DMcode";
            this.DMcode.Size = new System.Drawing.Size(143, 20);
            this.DMcode.TabIndex = 9;
            // 
            // testTrigger
            // 
            this.testTrigger.Location = new System.Drawing.Point(29, 165);
            this.testTrigger.Name = "testTrigger";
            this.testTrigger.Size = new System.Drawing.Size(75, 23);
            this.testTrigger.TabIndex = 10;
            this.testTrigger.Text = "Test Trigger";
            this.testTrigger.UseVisualStyleBackColor = true;
            this.testTrigger.Click += new System.EventHandler(this.testTrigger_Click_1);
            this.testTrigger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testTrigger_MouseDown);
            this.testTrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.testTrigger_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // resPic
            // 
            this.resPic.Location = new System.Drawing.Point(29, 194);
            this.resPic.Name = "resPic";
            this.resPic.Size = new System.Drawing.Size(277, 214);
            this.resPic.TabIndex = 12;
            this.resPic.TabStop = false;
            // 
            // LivePic
            // 
            this.LivePic.Location = new System.Drawing.Point(29, 453);
            this.LivePic.Name = "LivePic";
            this.LivePic.Size = new System.Drawing.Size(277, 186);
            this.LivePic.TabIndex = 13;
            this.LivePic.TabStop = false;
            // 
            // cbLiveDisplay
            // 
            this.cbLiveDisplay.AutoSize = true;
            this.cbLiveDisplay.Location = new System.Drawing.Point(29, 430);
            this.cbLiveDisplay.Name = "cbLiveDisplay";
            this.cbLiveDisplay.Size = new System.Drawing.Size(71, 17);
            this.cbLiveDisplay.TabIndex = 14;
            this.cbLiveDisplay.Text = "Live view";
            this.cbLiveDisplay.UseVisualStyleBackColor = true;
            this.cbLiveDisplay.CheckedChanged += new System.EventHandler(this.cbLiveDisplay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(334, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "DM kod:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(432, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 31);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 668);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLiveDisplay);
            this.Controls.Add(this.LivePic);
            this.Controls.Add(this.resPic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testTrigger);
            this.Controls.Add(this.DMcode);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.open_viewer);
            this.Controls.Add(this.menuStrip1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

