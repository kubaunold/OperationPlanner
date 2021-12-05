using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace OperationPlanner
{
    public partial class FormPatientInfo : Form
    {
        public void Log(string s)
        {
            richTextBox_logger.Text += DateTime.Now.ToString() + " " + s + "\n";
        }

        public FormPatientInfo()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                Log("Connecting to database using following connString: " + Constants.connString);

                MySqlConnection conn = new MySqlConnection(Constants.connString);
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test_db.users", conn);

                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "users");
                dataGridView_database.DataSource = ds.Tables["users"];
                conn.Close();


                MessageBox.Show("Connection successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // bind this method to its TextChanged event handler:
        // richTextBox.TextChanged += richTextBox_TextChanged;
        private void richTextBox_logger_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox_logger.SelectionStart = richTextBox_logger.Text.Length;
            // scroll it automatically
            richTextBox_logger.ScrollToCaret();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Welcome to Hospital Operation Planner!");
        }

        private void label_logger_Click(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            DbPatient.DisplayAndSearch("SELECT ID, Name, Age, Gender, BMI FROM patient_table", dataGridView1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormAddPatient form = new FormAddPatient(this);
            form.ShowDialog();
        }

        private void FormPatientInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
