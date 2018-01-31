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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataManSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postavkeAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRes = new System.Windows.Forms.Label();
            this.DMcode = new System.Windows.Forms.TextBox();
            this.cbLiveDisplay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.export_file = new System.Windows.Forms.Button();
            this.refresh_archive = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataman_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataman_slika = new System.Windows.Forms.ToolStripStatusLabel();
            this.TriggerTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startAuto = new System.Windows.Forms.Button();
            this.stopAuto = new System.Windows.Forms.Button();
            this.LivePic = new System.Windows.Forms.PictureBox();
            this.resPic = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.discard_read = new System.Windows.Forms.Button();
            this.testTrigger = new System.Windows.Forms.Button();
            this.connReset = new System.Windows.Forms.Button();
            this.timer_reset = new System.Windows.Forms.Timer(this.components);
            this.missed_trigger = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LivePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataManSettingsToolStripMenuItem,
            this.databaseSettingsToolStripMenuItem,
            this.postavkeAplikacijeToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::cognex_tesanj.Properties.Resources.ajdust_large;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.settingsToolStripMenuItem.Text = "Postavke";
            // 
            // dataManSettingsToolStripMenuItem
            // 
            this.dataManSettingsToolStripMenuItem.Image = global::cognex_tesanj.Properties.Resources.camera_photo_svg;
            this.dataManSettingsToolStripMenuItem.Name = "dataManSettingsToolStripMenuItem";
            this.dataManSettingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.dataManSettingsToolStripMenuItem.Text = "Postavke čitača";
            this.dataManSettingsToolStripMenuItem.Click += new System.EventHandler(this.dataManSettingsToolStripMenuItem_Click);
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Image = global::cognex_tesanj.Properties.Resources.umbr_large;
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Uređivanje arhive";
            this.databaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.databaseSettingsToolStripMenuItem_Click);
            // 
            // postavkeAplikacijeToolStripMenuItem
            // 
            this.postavkeAplikacijeToolStripMenuItem.Image = global::cognex_tesanj.Properties.Resources.adjustlevels_svg;
            this.postavkeAplikacijeToolStripMenuItem.Name = "postavkeAplikacijeToolStripMenuItem";
            this.postavkeAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.postavkeAplikacijeToolStripMenuItem.Text = "Postavke aplikacije";
            this.postavkeAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.postavkeAplikacijeToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 441);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblRes
            // 
            this.lblRes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRes.Location = new System.Drawing.Point(20, 136);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(126, 25);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "Očitani kod:";
            // 
            // DMcode
            // 
            this.DMcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DMcode.Location = new System.Drawing.Point(147, 133);
            this.DMcode.Name = "DMcode";
            this.DMcode.Size = new System.Drawing.Size(218, 31);
            this.DMcode.TabIndex = 9;
            // 
            // cbLiveDisplay
            // 
            this.cbLiveDisplay.AutoSize = true;
            this.cbLiveDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLiveDisplay.Location = new System.Drawing.Point(400, 647);
            this.cbLiveDisplay.Name = "cbLiveDisplay";
            this.cbLiveDisplay.Size = new System.Drawing.Size(145, 29);
            this.cbLiveDisplay.TabIndex = 14;
            this.cbLiveDisplay.Text = "Live display";
            this.cbLiveDisplay.UseVisualStyleBackColor = true;
            this.cbLiveDisplay.CheckedChanged += new System.EventHandler(this.cbLiveDisplay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filter DM koda:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(170, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 31);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.export_file);
            this.groupBox1.Controls.Add(this.refresh_archive);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(389, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 558);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz arhive";
            // 
            // export_file
            // 
            this.export_file.BackColor = System.Drawing.Color.Khaki;
            this.export_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.export_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export_file.Image = global::cognex_tesanj.Properties.Resources.system_save_session_svg;
            this.export_file.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.export_file.Location = new System.Drawing.Point(197, 497);
            this.export_file.Name = "export_file";
            this.export_file.Size = new System.Drawing.Size(191, 50);
            this.export_file.TabIndex = 19;
            this.export_file.Text = "Export odabira";
            this.export_file.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.export_file.UseVisualStyleBackColor = false;
            this.export_file.Click += new System.EventHandler(this.button4_Click);
            // 
            // refresh_archive
            // 
            this.refresh_archive.BackColor = System.Drawing.Color.Khaki;
            this.refresh_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresh_archive.Image = global::cognex_tesanj.Properties.Resources.view_refresh_svg;
            this.refresh_archive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_archive.Location = new System.Drawing.Point(11, 497);
            this.refresh_archive.Name = "refresh_archive";
            this.refresh_archive.Size = new System.Drawing.Size(180, 50);
            this.refresh_archive.TabIndex = 18;
            this.refresh_archive.Text = "Osvježi arhivu";
            this.refresh_archive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_archive.UseVisualStyleBackColor = false;
            this.refresh_archive.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Khaki;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.dataman_status,
            this.toolStripStatusLabel2,
            this.dataman_slika});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::cognex_tesanj.Properties.Resources.clock;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataman_status
            // 
            this.dataman_status.Image = global::cognex_tesanj.Properties.Resources.camera_photo_svg;
            this.dataman_status.Name = "dataman_status";
            this.dataman_status.Size = new System.Drawing.Size(89, 17);
            this.dataman_status.Text = "Stanje čitača";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // dataman_slika
            // 
            this.dataman_slika.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataman_slika.Image = global::cognex_tesanj.Properties.Resources.yast_red_dot;
            this.dataman_slika.Name = "dataman_slika";
            this.dataman_slika.Size = new System.Drawing.Size(16, 17);
            this.dataman_slika.Text = "slika_status";
            // 
            // TriggerTimer
            // 
            this.TriggerTimer.Interval = 600;
            this.TriggerTimer.Tick += new System.EventHandler(this.TriggerTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.startAuto);
            this.groupBox2.Controls.Add(this.stopAuto);
            this.groupBox2.Controls.Add(this.lblRes);
            this.groupBox2.Controls.Add(this.DMcode);
            this.groupBox2.Controls.Add(this.LivePic);
            this.groupBox2.Controls.Add(this.resPic);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(0, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 649);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dataman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Slika očitanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Live display:";
            // 
            // startAuto
            // 
            this.startAuto.BackColor = System.Drawing.Color.LawnGreen;
            this.startAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startAuto.Image = global::cognex_tesanj.Properties.Resources.media_playback_start_svg;
            this.startAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startAuto.Location = new System.Drawing.Point(25, 19);
            this.startAuto.Name = "startAuto";
            this.startAuto.Size = new System.Drawing.Size(340, 50);
            this.startAuto.TabIndex = 20;
            this.startAuto.Text = "Pokreni automatsko čitanje koda";
            this.startAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startAuto.UseVisualStyleBackColor = false;
            this.startAuto.Click += new System.EventHandler(this.startAuto_Click);
            // 
            // stopAuto
            // 
            this.stopAuto.BackColor = System.Drawing.Color.OrangeRed;
            this.stopAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopAuto.Image = global::cognex_tesanj.Properties.Resources.media_playback_stop_svg;
            this.stopAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopAuto.Location = new System.Drawing.Point(25, 75);
            this.stopAuto.Name = "stopAuto";
            this.stopAuto.Size = new System.Drawing.Size(340, 49);
            this.stopAuto.TabIndex = 21;
            this.stopAuto.Text = "Zaustavi automatsko čitanje koda";
            this.stopAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopAuto.UseVisualStyleBackColor = false;
            this.stopAuto.Click += new System.EventHandler(this.stopAuto_Click);
            // 
            // LivePic
            // 
            this.LivePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LivePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LivePic.Location = new System.Drawing.Point(25, 426);
            this.LivePic.Name = "LivePic";
            this.LivePic.Size = new System.Drawing.Size(340, 217);
            this.LivePic.TabIndex = 13;
            this.LivePic.TabStop = false;
            // 
            // resPic
            // 
            this.resPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resPic.Location = new System.Drawing.Point(25, 184);
            this.resPic.Name = "resPic";
            this.resPic.Size = new System.Drawing.Size(340, 217);
            this.resPic.TabIndex = 12;
            this.resPic.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            // 
            // logo_pic
            // 
            this.logo_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logo_pic.BackColor = System.Drawing.Color.Transparent;
            this.logo_pic.BackgroundImage = global::cognex_tesanj.Properties.Resources.sinel_logo;
            this.logo_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_pic.Location = new System.Drawing.Point(883, 619);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(351, 58);
            this.logo_pic.TabIndex = 23;
            this.logo_pic.TabStop = false;
            // 
            // discard_read
            // 
            this.discard_read.BackColor = System.Drawing.Color.Khaki;
            this.discard_read.BackgroundImage = global::cognex_tesanj.Properties.Resources.go_parent_folder_svg;
            this.discard_read.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.discard_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.discard_read.Image = global::cognex_tesanj.Properties.Resources.window_close_svg;
            this.discard_read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discard_read.Location = new System.Drawing.Point(585, 591);
            this.discard_read.Name = "discard_read";
            this.discard_read.Size = new System.Drawing.Size(192, 50);
            this.discard_read.TabIndex = 11;
            this.discard_read.Text = "Poništi očitanje";
            this.discard_read.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discard_read.UseVisualStyleBackColor = false;
            this.discard_read.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // testTrigger
            // 
            this.testTrigger.BackColor = System.Drawing.Color.Khaki;
            this.testTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testTrigger.Image = global::cognex_tesanj.Properties.Resources.media_playback_start_svg;
            this.testTrigger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testTrigger.Location = new System.Drawing.Point(400, 591);
            this.testTrigger.Name = "testTrigger";
            this.testTrigger.Size = new System.Drawing.Size(180, 50);
            this.testTrigger.TabIndex = 10;
            this.testTrigger.Text = "Test Trigger";
            this.testTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.testTrigger.UseVisualStyleBackColor = false;
            this.testTrigger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testTrigger_MouseDown);
            this.testTrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.testTrigger_MouseUp);
            // 
            // connReset
            // 
            this.connReset.BackColor = System.Drawing.Color.Khaki;
            this.connReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connReset.Location = new System.Drawing.Point(585, 644);
            this.connReset.Name = "connReset";
            this.connReset.Size = new System.Drawing.Size(192, 33);
            this.connReset.TabIndex = 20;
            this.connReset.Text = "Resetiranje konekcije";
            this.connReset.UseVisualStyleBackColor = false;
            this.connReset.Click += new System.EventHandler(this.connReset_Click);
            // 
            // timer_reset
            // 
            this.timer_reset.Interval = 3000;
            this.timer_reset.Tick += new System.EventHandler(this.timer_reset_Tick);
            // 
            // missed_trigger
            // 
            this.missed_trigger.Tick += new System.EventHandler(this.missed_trigger_Tick);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1234, 702);
            this.Controls.Add(this.connReset);
            this.Controls.Add(this.logo_pic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbLiveDisplay);
            this.Controls.Add(this.discard_read);
            this.Controls.Add(this.testTrigger);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 740);
            this.MinimumSize = new System.Drawing.Size(1250, 740);
            this.Name = "Main_form";
            this.Text = "Datamatrix arhiviranje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_form_FormClosing);
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LivePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataManSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button testTrigger;
        public System.Windows.Forms.TextBox DMcode;
        private System.Windows.Forms.Button discard_read;
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
        private System.Windows.Forms.Button export_file;
        private System.Windows.Forms.Button refresh_archive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem postavkeAplikacijeToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel dataman_status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel dataman_slika;
        private System.Windows.Forms.Button connReset;
        private System.Windows.Forms.Timer timer_reset;
        private System.Windows.Forms.Timer missed_trigger;
    }
}

