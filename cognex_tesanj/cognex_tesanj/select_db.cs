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
    public partial class select_db : Form
    {
        public select_db()
        {
            InitializeComponent();

            TB_db_loc.Text = Globals.database_loc;
            TB_passwd.PasswordChar = '*';
            TB_passwd.Text = Globals.db_passwd;
        }

        private void find_dialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                TB_db_loc.Text = "'" + directoryPath + "\\" + filename + "'";
            }
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
            Console.WriteLine("location : " + AppDomain.CurrentDomain.SetupInformation.ConfigurationFile.ToString());

        }



        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            AddUpdateAppSettings("db_loc", TB_db_loc.Text);          
            AddUpdateAppSettings("db_passwd", TB_passwd.Text);
            Program.update_globals();
            this.Close();
        }
    }
}
