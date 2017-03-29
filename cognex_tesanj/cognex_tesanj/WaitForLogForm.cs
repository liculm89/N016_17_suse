using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace cognex_tesanj
{
    public partial class WaitForLogForm : Form
    {
        static string graph = "Waiting for graph...";
        static string timestamp = null;
        static string dm = null;
        static int counter = 60;

        static string database_loc = Globals.database_loc;
        static string Db_Password = "0000";
        static string conString = "Provider=Microsoft.ACE.OLEDB.12.0; Jet OLEDB:Database Password=" + Db_Password + "; Persist Security Info = False; Data Source=" + database_loc + ";";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd = null;

        private void add(string dm, string graf, string ts)
        {
            //String sql = "INSERT INTO Popis_komada(Datamatrix,Graf,Timestamp) VALUES(@Datamatrix,@Graf,@Timestamp)";
            String sql = "INSERT INTO Popis_komada(Datamatrix,Graf,DatumVrijeme) VALUES(@Datamatrix,@Graf,@DatumVrijeme)";
            cmd = new OleDbCommand(sql, con);

            Console.WriteLine(ts);
            //ADD PARAMS
            cmd.Parameters.AddWithValue("@Datamatrix", dm);
            cmd.Parameters.AddWithValue("@Graf", graf);
            cmd.Parameters.AddWithValue("@DatumVrijeme", ts);
            //OPEN CON AND EXEC insert
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    // clearTxts();
                    // MessageBox.Show("Successfully Inserted");
                    Console.WriteLine("Entry added");
                }
                con.Close();
                //retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private Main_form mainForm = null;

        public WaitForLogForm(Main_form mf ,string DMcode)
        {
            InitializeComponent();

            mainForm = mf as Main_form;
            counter = 60;

             count.Text = "Timeout: " + counter + " s";
            lblDMcode.Text = DMcode;
            dm = DMcode;
            lblTime.Text = DateTime.Now.ToString("MM-dd-yyyy h:mmtt:ss");
            timestamp = DateTime.Now.ToString("MM-dd-yyyy h:mmtt:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WaitForLogForm_Load(object sender, EventArgs e)
        {
            FileSystemWatcher fw = new FileSystemWatcher(@"C:\Temp");
            fw.Created += fileSystemWatcher_Created;
            fw.EnableRaisingEvents = true;
        }
        
        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File created!");
            FileInfo file = new FileInfo(e.FullPath);
            Console.WriteLine(file.Name);
            graph = file.Name.ToString();
  
        }

        private void changeGraph()
        {
            lblGraph.Text = graph;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            changeGraph();

            if (lblGraph.Text !=  "Waiting for graph..." && timestamp != null && dm != null )
            {
                timer1.Stop();
                mainForm.waitForLog = true;

                Console.WriteLine("Database inject");
                add(dm, lblGraph.Text, timestamp);
                this.Close();
            }
        }

        private void WaitForLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
             graph = "Waiting for graph...";
             timestamp = null;
             dm = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            count.Text = "Timeout: " +  counter.ToString() + " s";
            if (counter == 0)
            {
                timer2.Stop();
                this.Close();
                count.Text = counter.ToString();
            }
        }
    }

  

}
