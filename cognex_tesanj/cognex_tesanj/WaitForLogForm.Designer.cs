namespace cognex_tesanj
{
    partial class WaitForLogForm
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
            this.lblDMcode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGraph = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.count = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDMcode
            // 
            this.lblDMcode.AutoSize = true;
            this.lblDMcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDMcode.Location = new System.Drawing.Point(383, 112);
            this.lblDMcode.Name = "lblDMcode";
            this.lblDMcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDMcode.Size = new System.Drawing.Size(114, 25);
            this.lblDMcode.TabIndex = 0;
            this.lblDMcode.Text = "lblDMcode";
            this.lblDMcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(190, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 105);
            this.button1.TabIndex = 1;
            this.button1.Text = "Poništi očitanje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(383, 237);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGraph
            // 
            this.lblGraph.AutoSize = true;
            this.lblGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGraph.Location = new System.Drawing.Point(383, 174);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(164, 25);
            this.lblGraph.TabIndex = 3;
            this.lblGraph.Text = "Čekanje grafa...";
            this.lblGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(251, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Očitani kod:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(318, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Graf:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(138, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum/Vrijeme očitanja:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.Aquamarine;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.count.ForeColor = System.Drawing.Color.Red;
            this.count.Location = new System.Drawing.Point(108, 16);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(450, 55);
            this.count.TabIndex = 7;
            this.count.Text = "ČEKANJE GRAFA :";
            this.count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.count);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDMcode);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblGraph);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 438);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // WaitForLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "WaitForLogForm";
            this.Text = "Čekanje Grafa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WaitForLogForm_FormClosing);
            this.Load += new System.EventHandler(this.WaitForLogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDMcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblGraph;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}