namespace cognex_tesanj
{
    partial class select_db
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
            this.TB_db_loc = new System.Windows.Forms.TextBox();
            this.TB_passwd = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.find_dialog = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_db_loc
            // 
            this.TB_db_loc.Location = new System.Drawing.Point(146, 30);
            this.TB_db_loc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_db_loc.Name = "TB_db_loc";
            this.TB_db_loc.Size = new System.Drawing.Size(385, 26);
            this.TB_db_loc.TabIndex = 0;
            // 
            // TB_passwd
            // 
            this.TB_passwd.Location = new System.Drawing.Point(146, 70);
            this.TB_passwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_passwd.Name = "TB_passwd";
            this.TB_passwd.Size = new System.Drawing.Size(88, 26);
            this.TB_passwd.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // find_dialog
            // 
            this.find_dialog.BackColor = System.Drawing.Color.Khaki;
            this.find_dialog.Location = new System.Drawing.Point(539, 30);
            this.find_dialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.find_dialog.Name = "find_dialog";
            this.find_dialog.Size = new System.Drawing.Size(84, 26);
            this.find_dialog.TabIndex = 2;
            this.find_dialog.Text = "...";
            this.find_dialog.UseVisualStyleBackColor = false;
            this.find_dialog.Click += new System.EventHandler(this.find_dialog_Click);
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.LightGreen;
            this.Accept.Image = global::cognex_tesanj.Properties.Resources.dialog_ok;
            this.Accept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accept.Location = new System.Drawing.Point(146, 118);
            this.Accept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(210, 45);
            this.Accept.TabIndex = 3;
            this.Accept.Text = "Potvrdi";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Khaki;
            this.Cancel.Image = global::cognex_tesanj.Properties.Resources.cancel;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(364, 118);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(210, 45);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Odustani";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baza podataka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lozinka :";
            // 
            // select_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(664, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.find_dialog);
            this.Controls.Add(this.TB_passwd);
            this.Controls.Add(this.TB_db_loc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "select_db";
            this.Text = "Postavke baze podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_db_loc;
        private System.Windows.Forms.TextBox TB_passwd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button find_dialog;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}