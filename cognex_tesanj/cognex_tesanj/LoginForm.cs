using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;

namespace cognex_tesanj
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
           
            InitializeComponent();
            PasswdBox.Text = "";
            PasswdBox.PasswordChar = '*';
            PasswdBox.MaxLength = 4;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string database_loc = "'H:\\database_access.accdb'";
            string Db_Password = "0000";
            string conString = "Provider=Microsoft.ACE.OLEDB.12.0; Jet OLEDB:Database Password=" + Db_Password + "; Persist Security Info = False; Data Source=" + database_loc + ";";

            OleDbConnection con = new OleDbConnection(conString);

            //String sql = "SELECT * FROM Login";
            OleDbDataAdapter test = new OleDbDataAdapter("Select Count(*) From Login where user='" + NameBox.Text + "' and password='" + PasswdBox.Text + "'", con);
            DataTable logins = new DataTable();
            test.Fill(logins);

            if ((NameBox.Text == "") || (PasswdBox.Text == ""))
            {
                MessageBox.Show("Pogreška prilikom logina. Upiši korisničko ime i lozinku!", "Login error");
            }
            else
            {
                if (logins.Rows[0][0].ToString() == "1")
                {
                    Console.WriteLine("yast");
                    this.Close();
                    Database_form f2 = new Database_form();

                    f2.StartPosition = FormStartPosition.Manual;
                    f2.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);

                    //LoginForm f2 = new LoginForm();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Pogreška prilikom logina. Pogrešno korisničko ime ili lozinka!", "Login error");
                }
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
