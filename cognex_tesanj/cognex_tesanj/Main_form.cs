using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Cognex.DataMan.SDK;

namespace cognex_tesanj
{
    public partial class Main_form : Form
    {

        private static string _rezultat;
        public static string rezultat
        {
            get
            {
                return _rezultat;
            }
            set // this makes you to change value in form2
            {
                _rezultat = "0";
            }
        }



        DataSet myset = new DataSet("Excel import");
        DataTable dataTable = new DataTable("excelImport");
        OleDbDataAdapter dataAdapter;
       

        static string Db_Password = "0000";
        static string database_loc = "'H:\\database_access.accdb'";
        static string conString = "Provider=Microsoft.ACE.OLEDB.12.0; Jet OLEDB:Database Password=" + Db_Password + "; Persist Security Info = False; Data Source=" + database_loc + ";";


        System.Data.OleDb.OleDbCommandBuilder scb;
        DataSet ds = new DataSet();

        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();

        public static System.Data.OleDb.OleDbConnection CreateConnection()
        {

            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.OleDb.OleDbCommand mycommand = new System.Data.OleDb.OleDbCommand();
           // string Db_Password = "0000";
            //string database_loc = "'H:\\database_access.accdb'";

            //string database_loc = "'G:\\N016_17 - Dogradnja Cognex DM čitača datamatrix koda na stroju za mjerenje sile uprešavanja\\database_access.accdb'";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Jet OLEDB:Database Password=" + Db_Password + "; Persist Security Info = False; Data Source=" + database_loc +";";       

            MyConnection = new System.Data.OleDb.OleDbConnection(connectionString);
            MyConnection.Open();
            return MyConnection;
        }

        public static void ReadData(DataTable data)
        {
            foreach (DataRow dataRow in data.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private void populate(string id, string dm, string graf)
        {
            dataGridView1.Rows.Add(id, dm, graf);
        }

        public Main_form()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Datamatrix";
            dataGridView1.Columns[2].Name = "Graf";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            try
            {
                System.Data.OleDb.OleDbConnection MyConnection = CreateConnection();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dataGridView1.Rows.Clear();
            //SQL STMT
            String sql = "SELECT * FROM Popis_komada";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
                }
                dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };

                con.Close();

                //CLEAR DT 
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

      
        private void Main_form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(result);
            //Console.WriteLine(result);

        }

        private void open_viewer_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Cognex_form cognex_form = new Cognex_form();
         
            cognex_sample sample = new cognex_sample(this);

            //sample.send_result += (sender, e) => lblRes.Text = ((cognex_sample)sender).Message;
            // Create an instance of form 2
     

            // Create an instance of the delegate
            sample.passControl = new cognex_sample.PassControl(PassData);

            // Show form 2
            //form2.Show();

            sample.Show();

            //lblRes.Text = cognex_sample.rezultat;


            //cognex_com.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button pressed", "Title"); 
            //MessageBox.Show()
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnForm1_Click(object sender, System.EventArgs e)
        {

        }

        private void PassData(object sender)
        {
            // Set de text of the textbox to the value of the textbox of form 2
            DMcode.Text = ((TextBox)sender).Text;
        }

    }
}

