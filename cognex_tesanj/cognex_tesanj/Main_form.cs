using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Cognex.DataMan.SDK;
using Cognex.DataMan.SDK.Discovery;
using Cognex.DataMan.SDK.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Xml;
using System.Configuration;

namespace cognex_tesanj
{
    public partial class Main_form : Form
    {

        private ResultCollector _results;
        private SynchronizationContext _syncContext = null;
        private EthSystemDiscoverer _ethSystemDiscoverer = null;
   
        private ISystemConnector _connector = null;
        private DataManSystem _system = null;
        private object _currentResultInfoSyncLock = new object();
        private bool _closing = false;
        private bool _autoconnect = false;
        private object _listAddItemLock = new object();
        //public static TextBox DMcode = new TextBox();
        public bool waitForLog = true;


        public Main_form()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Datamatrix";
            dataGridView1.Columns[2].Name = "Graf";
            dataGridView1.Columns[3].Name = "TimeStamp";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            _syncContext = Cognex.DataMan.SDK.WindowsFormsSynchronizationContext.Current;

            cbLiveDisplay.CheckedChanged += new System.EventHandler(this.cbLiveDisplay_CheckedChanged);
            
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
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
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

        public void setText(String rez)
        {
            Console.WriteLine("setting text");
            //DMcode.TextChanged += new EventHandler(DMCode_TextChanged);
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(delegate
                {
                    if (waitForLog)
                    { 
                        DMcode.Text = rez;
                        WaitForLogForm waitForm = new WaitForLogForm(this, rez);
                        waitForm.StartPosition = FormStartPosition.Manual;
                        waitForm.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                        waitForm.Show();
                       // waitForLog = false;
                     }
                    //DMcode.Text = rez;
                }));
            }
        }

        private void DMCode_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("changed");
        }

        private EthSystemDiscoverer.SystemInfo sysinfo;

        /*
         * eth discover
         * 
         */
        private void Main_form_Load(object sender, EventArgs e)
        {
            _ethSystemDiscoverer = new EthSystemDiscoverer();
            _ethSystemDiscoverer.SystemDiscovered += new EthSystemDiscoverer.SystemDiscoveredHandler(OnEthSystemDiscovered);
            _ethSystemDiscoverer.Discover();
            Console.WriteLine("connector::::::::::::::::::::::::::");
        }

        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            _closing = true;
            _autoconnect = false;

            if (null != _system && _system.State == Cognex.DataMan.SDK.ConnectionState.Connected)
                _system.Disconnect();

            _ethSystemDiscoverer.Dispose();
            _ethSystemDiscoverer = null;
        }

        private void OnEthSystemDiscovered(EthSystemDiscoverer.SystemInfo systemInfo)
        {
            try
            {
                sysinfo = systemInfo;
                connect();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect: " + ex.ToString());
            }
        }

        private void connect()
            {
                try
                {
                    EthSystemDiscoverer.SystemInfo eth_system_info = sysinfo as EthSystemDiscoverer.SystemInfo;
                    EthSystemConnector conn = new EthSystemConnector(eth_system_info.IPAddress, eth_system_info.Port);

                 conn.UserName = "admin";
                 conn.Password = "";
                _connector = conn;
                _system = new DataManSystem(_connector);
                _system.DefaultTimeout = 5000;
                Console.WriteLine("connecting..");
                _system.SystemConnected += new SystemConnectedHandler(OnSystemConnected);
                _system.KeepAliveResponseMissed += new KeepAliveResponseMissedHandler(OnKeepAliveResponseMissed);

                ResultTypes requested_result_types = ResultTypes.ReadXml | ResultTypes.Image | ResultTypes.ImageGraphics | ResultTypes.ReadString;
                _results = new ResultCollector(_system, requested_result_types);
                _results.ComplexResultCompleted += Results_ComplexResultCompleted;
                _results.SimpleResultDropped += Results_SimpleResultDropped;
                _system.SetKeepAliveOptions(true, 3000, 1000);
                _system.Connect();

                try
                {
                    _system.SetResultTypes(requested_result_types);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect: " + ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.ToString());
            }
        }

        private void OnSystemConnected(object sender, EventArgs args)
        {
                    Console.WriteLine("Connected!!!");
        }

        private void Results_ComplexResultCompleted(object sender, ComplexResult e)
        {
                    Console.WriteLine("From results_complex");
                    ShowResult(e);
        }

        private void Results_SimpleResultDropped(object sender, SimpleResult e)
        {
                    ReportDroppedResult(e);
        }
        private void ReportDroppedResult(SimpleResult result)
        {
           ///AddListItem(string.Format("Partial result dropped: {0}, id={1}", result.Id.Type.ToString(), result.Id.Id));
        }

        /*private void cbEnableKeepAlive_CheckedChanged(object sender, EventArgs e)
        {
            if (null != _system)
                _system.SetKeepAliveOptions(cbEnableKeepAlive.Checked, 3000, 1000);
        }*/

        private void OnLiveImageArrived(IAsyncResult result)
        {
            try
            {
                Image image = _system.EndGetLiveImage(result);

                _syncContext.Post(
                    delegate
                    {
                        Size image_size = Gui.FitImageInControl(image.Size, LivePic.Size);
                        Image fitted_image = Gui.ResizeImageToBitmap(image, image_size);
                        LivePic.Image = fitted_image;
                        LivePic.Invalidate();

                        if (cbLiveDisplay.Checked)
                        {
                            _system.BeginGetLiveImage(
                                ImageFormat.jpeg,
                                ImageSize.Sixteenth,
                                ImageQuality.Medium,
                                OnLiveImageArrived,
                                null);
                        }
                    },
                null);
            }
            catch
            {
            }
        }


        public void ShowResult(ComplexResult complexResult)
        {
            List<Image> images = new List<Image>();
            List<string> image_graphics = new List<string>();
            string read_result = null;
            int result_id = -1;
            ResultTypes collected_results = ResultTypes.None;
           // Console.WriteLine(ResultTypes.ReadString);
            // Take a reference or copy values from the locked result info object. This is done
            // so that the lock is used only for a short period of time.
            lock (_currentResultInfoSyncLock)
            {
                foreach (var simple_result in complexResult.SimpleResults)
                {
                    collected_results |= simple_result.Id.Type;

                    switch (simple_result.Id.Type)
                    {
                        case ResultTypes.Image:
                            Image image = ImageArrivedEventArgs.GetImageFromImageBytes(simple_result.Data);
                            if (image != null)
                                images.Add(image);
                            break;

                            case ResultTypes.ImageGraphics:
                            image_graphics.Add(simple_result.GetDataAsString());
                            break;
/*
                        case ResultTypes.ReadXml:
                            read_result = GetReadStringFromResultXml(simple_result.GetDataAsString());
                            result_id = simple_result.Id.Id;
                            break;
*/
                        case ResultTypes.ReadString:
                            read_result = simple_result.GetDataAsString();
                            result_id = simple_result.Id.Id;
                            Console.WriteLine(read_result);
                            setText(read_result);

                            break;
                  
                    }
                }
            }
            //rezultat = read_result;

            // AddListItem(string.Format("Complex result arrived: resultId = {0}, read result = {1}", result_id, read_result));
            //Log("Complex result contains", string.Format("{0}", collected_results.ToString()));
            
            if (images.Count > 0)
            {
                Image first_image = images[0];

                Size image_size = Gui.FitImageInControl(first_image.Size, resPic.Size);
                Image fitted_image = Gui.ResizeImageToBitmap(first_image, image_size);

                if (image_graphics.Count > 0)
                {
                    using (Graphics g = Graphics.FromImage(fitted_image))
                    {
                        foreach (var graphics in image_graphics)
                        {
                            ResultGraphics rg = GraphicsResultParser.Parse(graphics, new Rectangle(0, 0, image_size.Width, image_size.Height));
                            ResultGraphicsRenderer.PaintResults(g, rg);
                        }
                    }
                }

                if (resPic.Image != null)
                {
                    var image = resPic.Image;
                    resPic.Image = null;
                    image.Dispose();
                }

                resPic.Image = fitted_image;
                resPic.Invalidate();
            }
         
            if (read_result != null)
                Console.WriteLine("writing dm");
                lblRes.Text = read_result;
            //this.DMcode.BeginInvoke();
            //rezultat = read_result;
        }

        private void OnKeepAliveResponseMissed(object sender, EventArgs args)
        {
                    Console.WriteLine(".....missed...");
        }

        private void cbLiveDisplay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLiveDisplay.Checked)
                {
                    //btnTrigger.Enabled = false;

                    _system.SendCommand("SET LIVEIMG.MODE 2");
                    _system.BeginGetLiveImage(
                        ImageFormat.jpeg,
                        ImageSize.Sixteenth,
                        ImageQuality.Medium,
                        OnLiveImageArrived,
                        null);
                }
                else
                {
                   // btnTrigger.Enabled = true;

                    _system.SendCommand("SET LIVEIMG.MODE 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set live image mode: " + ex.ToString());
            }
        }
        //EthSystemConnector conn = new EthSystemConnector(168.254.179.54, 22);


        DataSet myset = new DataSet("Excel import");
        DataTable dataTable = new DataTable("excelImport");
        OleDbDataAdapter dataAdapter;
       

        static string Db_Password = "0000";
        //static string database_loc = "'H:\\database_access.accdb'";
        static string database_loc = Globals.database_loc;
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
            //string Db_Password = "0000";
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

        private void populate(string id, string dm, string graf, string ts)
        {
            dataGridView1.Rows.Add(id, dm, graf, ts);
        }

 

      
      /*  private void Main_form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(result);
            //Console.WriteLine(result);

        }*/

        private void open_viewer_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"cmd.exe";
            ExternalProcess.StartInfo.Arguments = @"/c start SetupTool.exe";
            ExternalProcess.StartInfo.UseShellExecute = false;
            ExternalProcess.StartInfo.WorkingDirectory = @"C:\Program Files\Cognex\DataMan\DataMan Software v5.6.3_SR2\";
            ExternalProcess.StartInfo.UseShellExecute = false;
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            try
            {
                ExternalProcess.Start();
                ExternalProcess.WaitForExit();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

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

        private void testTrigger_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                _system.SendCommand("TRIGGER ON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send TRIGGER ON command: " + ex.ToString());
            }
        }

        private void testTrigger_MouseUp(object sender, MouseEventArgs e)
        {
            /*try
            {
                _system.SendCommand("TRIGGER OFF");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send TRIGGER OFF command: " + ex.ToString());
            }*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.DMcode.Text = "";
        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _closing = true;
            _autoconnect = false;

            if (null != _system && _system.State == Cognex.DataMan.SDK.ConnectionState.Connected)
                _system.Disconnect();

            _ethSystemDiscoverer.Dispose();
            _ethSystemDiscoverer = null;

           // _serSystemDiscoverer.Dispose();
         //   _serSystemDiscoverer = null;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //SQL STMT
            String sql = "SELECT * FROM Popis_komada WHERE Datamatrix LIKE '"+ textBox1.Text + "%'";
            cmd = new OleDbCommand(sql, con);

            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = DateTime.Now.ToString("MM-dd-yyyy h:mmtt:ss");
        }



        private void TriggerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                _system.SendCommand("TRIGGER ON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send TRIGGER ON command: " + ex.ToString());
            }
        }

        private void startAuto_Click(object sender, EventArgs e)
        {
            TriggerTimer.Start();
        }

        private void stopAuto_Click(object sender, EventArgs e)
        {
            TriggerTimer.Stop();
        }

        private void DMcode_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

