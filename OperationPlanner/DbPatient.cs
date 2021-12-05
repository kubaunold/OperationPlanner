using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OperationPlanner
{
    class DbPatient
    {
        public static MySqlConnection GetConnection()
        {
            string sql = Constants.connString;

            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL COnnection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return conn;
        }

        public static void AddPatient(Patient pat)
        {
            string sql = "INSERT INTO patient_table VALUES (NULL, @PatientName, @PatientAge, @PatientGender, @PatientBMI, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PatientName", MySqlDbType.VarChar).Value = pat.Name;
            cmd.Parameters.Add("@PatientAge", MySqlDbType.Int32).Value = pat.Age;
            cmd.Parameters.Add("@PatientGender", MySqlDbType.Int32).Value = pat.Gender;
            cmd.Parameters.Add("@PatientBMI", MySqlDbType.Float).Value = pat.BMI;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Patient not inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void UpdatePatient(Patient pat, string id)
        {
            string sql = "UPDATEpatient_table SET Name = @PatientName, Age = @PatientAge, Gender = @PatientGender, BMI = @PatientBMI WHERE ID = @PatientID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PatientName", MySqlDbType.VarChar).Value = pat.Name;
            cmd.Parameters.Add("@PatientAge", MySqlDbType.Int32).Value = pat.Age;
            cmd.Parameters.Add("@PatientGender", MySqlDbType.Int32).Value = pat.Gender;
            cmd.Parameters.Add("@PatientBMI", MySqlDbType.Float).Value = pat.BMI;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Patient not updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DeletePatient(string id)
        {
            string sql = "DELETE FROM patient_table WHERE ID = @PatientID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PatientID", MySqlDbType.VarChar).Value = id;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Patient not deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();

        }

    }
}
