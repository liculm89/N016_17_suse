using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Data.OleDb;

namespace cognex_tesanj
{
    public static class Globals
    {
        public static string rezultat;

        public static string database_loc = Properties.Settings.Default["db_loc"].ToString();
        public static string archive_loc = Properties.Settings.Default["archive_loc"].ToString();
        public static string external_archive_loc = Properties.Settings.Default["external_archive_loc"].ToString();
        public static string export_folder = Properties.Settings.Default["Export_folder"].ToString();
        public static string db_passwd = Properties.Settings.Default["db_passwd"].ToString();
        public static string timeout_counter = Properties.Settings.Default["timeout_counter"].ToString();
        public static string trigger_timer = Properties.Settings.Default["trigger"].ToString();

    }

    static class Program
    {

        private static bool con_test(string db, string passwd)
        {
            try
            {
                string conString = "Provider=Microsoft.ACE.OLEDB.12.0; Jet OLEDB:Database Password=" + passwd + "; Persist Security Info = False; Data Source=" + db + ";";

                OleDbConnection con = new OleDbConnection(conString);
                con.Open();

               // Console.WriteLine("***************************************************");
               // Console.WriteLine(con.State.ToString());
                
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static void update_globals()
        {

            Globals.database_loc = Properties.Settings.Default["db_loc"].ToString();
            Globals.archive_loc = Properties.Settings.Default["archive_loc"].ToString();
            Globals.external_archive_loc = Properties.Settings.Default["external_archive_loc"].ToString();
            Globals.export_folder = Properties.Settings.Default["Export_folder"].ToString();
            Globals.db_passwd = Properties.Settings.Default["db_passwd"].ToString();
            Globals.timeout_counter = Properties.Settings.Default["timeout_counter"].ToString();
            Globals.trigger_timer = Properties.Settings.Default["trigger"].ToString();
            
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);

            string database_loc = Globals.database_loc;
            string Db_Password = Globals.db_passwd;

            bool check_connection = con_test(database_loc, Db_Password);

            if (check_connection)
            {
                Application.Run(new Main_form());
            }
            else
            {
                MessageBox.Show("Pogreška prilikom učitavanja baze podataka!", "Database error");
                //Application.Run(new Main_form());
                Application.Run(new select_db());
                Application.Run(new Main_form());
            }
        }
    }
}

