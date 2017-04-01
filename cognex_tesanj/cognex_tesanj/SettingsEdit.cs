using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;


namespace cognex_tesanj
{
    public partial class SettingsEdit : Form
    {
        /*
        private void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
        */
        public string[] keys = new string[6];


        public SettingsEdit()
        {
            InitializeComponent();
            keys[0] = "db_loc";
            keys[1] = "archive_loc";
            keys[2] = "external_archive_loc";
            keys[3] = "Export_loc";
            keys[4] = "timeout_counter";
            keys[5] = "trigger";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                
                string directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                Console.WriteLine(directoryPath +"\\" + filename);
                //MessageBox.Show(sr.ReadToEnd().ToString());
                //sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string drp = Path.GetDirectoryName(folderBrowserDialog1.SelectedPath);
                string full_path = Path.GetFullPath(folderBrowserDialog1.SelectedPath);

                Console.WriteLine(full_path);
            }
        }

        private void SettingsEdit_Load(object sender, EventArgs e)
        {
            TBdb_loc.Text = Globals.database_loc;
            TBdigiforce.Text = Globals.external_archive_loc;
            TBexport.Text = Globals.export_folder;
            TBtimeout.Text = Globals.timeout_counter;
            TB_trigger.Text = Globals.trigger_timer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            try
            {

                configFile.AppSettings.Settings.Remove("Export_folder");
                configFile.AppSettings.Settings.Add("Export_folder", @"c:\export123");
                Console.WriteLine("exported");
               configFile.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                /* if (settings[keys[3]] == null)
                 {
                     settings.Add(keys[3], @"C:\EXPORT");
                     Console.WriteLine("created!!!!!");
                 }
                 else
                 {
                     settings[keys[3]].Value = @"c:\EXPORT";
                     Console.WriteLine("modified");
                 }*/
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show("Failed to send TRIGGER ON command: " + ex.ToString());

            }

            //confi
            //configFile.Save(ConfigurationSaveMode.Modified);
            /*try
            {
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
                  catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show("Failed to send TRIGGER ON command: " + ex.ToString());

            }*/
            /*

            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                


                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
            //AddOrUpdateAppSettings("db_loc", TBdb_loc.Text);
            // AddOrUpdateAppSettings("external_archive_loc", TBdigiforce.Text);*/
            this.Close();
        }
    }
}
