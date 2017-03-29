﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;


namespace cognex_tesanj
{
    public static class Globals
    {
        public static string rezultat;
        public static string database_loc = ConfigurationManager.AppSettings["db_loc"];
        public static string archive_loc = ConfigurationManager.AppSettings["archive_loc"];
        public static string external_archive_loc = ConfigurationManager.AppSettings["external_archive_loc"];
        public static string export_folder = ConfigurationManager.AppSettings["Export_folder"];
        public static string db_passwd = ConfigurationManager.AppSettings["db_passwd"];
    }


    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new Main_form());
       }
    }
}

