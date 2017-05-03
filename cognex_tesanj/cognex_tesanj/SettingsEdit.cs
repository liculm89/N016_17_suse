using System;

using System.Windows.Forms;
using System.Configuration;
using System.IO;


namespace cognex_tesanj
{
    public partial class SettingsEdit : Form
    {
      
        public string[] keys = new string[7];

        /// <summary>
        /// 
        /// </summary>
        public SettingsEdit()
        {
            InitializeComponent();
            keys[0] = "db_loc";
            keys[1] = "archive_loc";
            keys[2] = "external_archive_loc";
            keys[3] = "Export_folder";
            keys[4] = "timeout_counter";
            keys[5] = "trigger";
            keys[6] = "db_passwd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {      
                string directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                //Console.WriteLine(directoryPath +"\\" + filename);
                TBdb_loc.Text = "'" + directoryPath + "\\" + filename + "'";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string drp = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);
                string full_path = Path.GetFullPath(folderBrowserDialog1.SelectedPath);
                //Console.WriteLine(full_path);
                TBdigiforce.Text = full_path; 
            }
        }

        private void SettingsEdit_Load(object sender, EventArgs e)
        {
            TBdb_loc.Text = Properties.Settings.Default[keys[0]].ToString();
            TBdigiforce.Text = Properties.Settings.Default[keys[2]].ToString();
            TBexport.Text = Properties.Settings.Default[keys[3]].ToString();
            TBtimeout.Text = Properties.Settings.Default[keys[4]].ToString();
            TB_trigger.Text = Properties.Settings.Default[keys[5]].ToString();

            TB_passwd.PasswordChar = '*';
            TB_passwd.Text = Properties.Settings.Default[keys[6]].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            //Properties.Settings.Default[]
        }


        static void AddUpdateAppSettings(string key, string value)
        {
               
                try
                {
                    Properties.Settings.Default[key] = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not write configuration key: " + key);
                }

                Properties.Settings.Default.Save();
                //Console.WriteLine("location : " + AppDomain.CurrentDomain.SetupInformation.ConfigurationFile.ToString());
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button3 click");
            try
            {     
                Console.WriteLine("update");
                AddUpdateAppSettings(keys[0], TBdb_loc.Text);
                AddUpdateAppSettings(keys[2], TBdigiforce.Text);
                AddUpdateAppSettings(keys[3], TBexport.Text);
                AddUpdateAppSettings(keys[4], TBtimeout.Text);
                AddUpdateAppSettings(keys[5], TB_trigger.Text);
                AddUpdateAppSettings(keys[6], TB_passwd.Text);

                Program.update_globals();
              
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show("Failed to send TRIGGER ON command: " + ex.ToString());

            }

          
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string drp = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);
                string full_path = Path.GetFullPath(folderBrowserDialog1.SelectedPath);

                Console.WriteLine(full_path);
                TBexport.Text = full_path.ToString();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
