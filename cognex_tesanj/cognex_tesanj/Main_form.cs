using System;
using System.Data;
using System.Windows.Forms;

namespace cognex_tesanj
{
    public partial class Main_form : Form
    {

        DataSet myset = new DataSet("Excel import");
        DataTable dataTable = new DataTable("excelImport");
        System.Data.OleDb.OleDbDataAdapter dataAdapter;

        System.Data.OleDb.OleDbCommandBuilder scb;
        DataSet ds = new DataSet();

        public static System.Data.OleDb.OleDbConnection CreateConnection()
        {

            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.OleDb.OleDbCommand mycommand = new System.Data.OleDb.OleDbCommand();
            string Db_Password = "0000";
            string database_loc = "'I:\\database_access.accdb'";

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
            Cognex_form cognex_form = new Cognex_form();
            cognex_form.Show();
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
    }
}
