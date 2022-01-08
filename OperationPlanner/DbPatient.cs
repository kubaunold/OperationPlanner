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
                MessageBox.Show("MySQL Connection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return conn;
        }

        public static void AddPatient(Patient pat)
        {
            string sql = "INSERT INTO patient_table VALUES (NULL, @PatientName, @PatientAge, @PatientBMI, @PatientCancer, @PatientCVD, @PatientDementia, @PatientDiabetes, @PatientDigestive, @PatientOsteoart, @PatientPsych, @PatientPulmonary, @PatientCharlson, @PatientMortality_rsi, @PatientComplication_rsi, @PatientSurgery_type, @PatientJUP_priority_predicted, @PatientJUP_priority_ideal, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PatientName", MySqlDbType.VarChar).Value = pat.Name;
            cmd.Parameters.Add("@PatientAge", MySqlDbType.Float).Value = pat.Age;
            cmd.Parameters.Add("@PatientBMI", MySqlDbType.Float).Value = pat.BMI;
            cmd.Parameters.Add("@PatientCancer", MySqlDbType.Int32).Value = pat.Cancer;
            cmd.Parameters.Add("@PatientCVD", MySqlDbType.Int32).Value = pat.CVD;
            cmd.Parameters.Add("@PatientDementia", MySqlDbType.Int32).Value = pat.Dementia;
            cmd.Parameters.Add("@PatientDiabetes", MySqlDbType.Int32).Value = pat.Diabetes;
            cmd.Parameters.Add("@PatientDigestive", MySqlDbType.Int32).Value = pat.Digestive;
            cmd.Parameters.Add("@PatientOsteoart", MySqlDbType.Int32).Value = pat.Osteoart;
            cmd.Parameters.Add("@PatientPsych", MySqlDbType.Int32).Value = pat.Psych;
            cmd.Parameters.Add("@PatientPulmonary", MySqlDbType.Int32).Value = pat.Pulmonary;
            cmd.Parameters.Add("@PatientCharlson", MySqlDbType.Int32).Value = pat.Charlson;
            cmd.Parameters.Add("@PatientMortality_rsi", MySqlDbType.Float).Value = pat.Mortality_rsi;
            cmd.Parameters.Add("@PatientComplication_rsi", MySqlDbType.Float).Value = pat.Complication_rsi;
            cmd.Parameters.Add("@PatientSurgery_type", MySqlDbType.VarChar).Value = pat.Surgery_type;
            cmd.Parameters.Add("@PatientJUP_priority_predicted", MySqlDbType.VarChar).Value = pat.JUP_priority_predicted;
            cmd.Parameters.Add("@PatientJUP_priority_ideal", MySqlDbType.VarChar).Value = pat.JUP_priority_ideal;

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

        public static void UpdatePatient(Patient pat, string id, int communication)
        {
            string sql = "UPDATE patient_table SET Name = @PatientName, Age = @PatientAge, BMI = @PatientBMI, Cancer = @PatientCancer, CVD = @PatientCVD, Dementia = @PatientDementia, Diabetes = @PatientDiabetes, Digestive = @PatientDigestive, Osteoart = @PatientOsteoart, Psych = @PatientPsych, Pulmonary = @PatientPulmonary, Charlson = @PatientCharlson, Mortality_rsi = @PatientMortality_rsi, Complication_rsi = @PatientComplication_rsi, Surgery_type = @PatientSurgery_type, JUP_priority_predicted = @PatientJUP_priority_predicted, JUP_priority_ideal = @PatientJUP_priority_ideal  WHERE ID = @PatientID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PatientID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PatientName", MySqlDbType.VarChar).Value = pat.Name;
            cmd.Parameters.Add("@PatientAge", MySqlDbType.Float).Value = pat.Age;
            cmd.Parameters.Add("@PatientBMI", MySqlDbType.Float).Value = pat.BMI;
            cmd.Parameters.Add("@PatientCancer", MySqlDbType.Int32).Value = pat.Cancer;
            cmd.Parameters.Add("@PatientCVD", MySqlDbType.Int32).Value = pat.CVD;
            cmd.Parameters.Add("@PatientDementia", MySqlDbType.Int32).Value = pat.Dementia;
            cmd.Parameters.Add("@PatientDiabetes", MySqlDbType.Int32).Value = pat.Diabetes;
            cmd.Parameters.Add("@PatientDigestive", MySqlDbType.Int32).Value = pat.Digestive;
            cmd.Parameters.Add("@PatientOsteoart", MySqlDbType.Int32).Value = pat.Osteoart;
            cmd.Parameters.Add("@PatientPsych", MySqlDbType.Int32).Value = pat.Psych;
            cmd.Parameters.Add("@PatientPulmonary", MySqlDbType.Int32).Value = pat.Pulmonary;
            cmd.Parameters.Add("@PatientCharlson", MySqlDbType.Int32).Value = pat.Charlson;
            cmd.Parameters.Add("@PatientMortality_rsi", MySqlDbType.Float).Value = pat.Mortality_rsi;
            cmd.Parameters.Add("@PatientComplication_rsi", MySqlDbType.Float).Value = pat.Complication_rsi;
            cmd.Parameters.Add("@PatientSurgery_type", MySqlDbType.VarChar).Value = pat.Surgery_type;
            cmd.Parameters.Add("@PatientJUP_priority_predicted", MySqlDbType.VarChar).Value = pat.JUP_priority_predicted;
            cmd.Parameters.Add("@PatientJUP_priority_ideal", MySqlDbType.VarChar).Value = pat.JUP_priority_ideal;

            
            
           try
           {
               int temp = cmd.ExecuteNonQuery();
               if (communication == 1) MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           catch (MySqlException ex)
           {
               if (communication == 1) MessageBox.Show("Patient not updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           catch
           {
               if (communication == 1) MessageBox.Show("[ERR_117] Error of another type.");
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


        public static List<string> TakeIDs()
        {
            int index;
            string index_str = "";
            List<string> list = new List<string>();
            string sql = "SELECT ID FROM patient_table";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    index = reader.GetInt32(0);
                    index_str = index.ToString();
                    list.Add(index_str);
                }
                return list;
            }
        }

        public static Patient TakeRow(string id)
        {
            Patient pat = new Patient("xd",0,0,0,0,0,0,0,0,0,0,0,0,0,"katar",0);
            string sql = "SELECT * FROM patient_table WHERE ID = " + id;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    pat.Name= reader.GetString(1);
                    pat.Age = reader.GetFloat(2);
                    pat.BMI = reader.GetFloat(3);
                    pat.Cancer = reader.GetInt32(4);
                    pat.CVD = reader.GetInt32(5);
                    pat.Dementia = reader.GetInt32(6);
                    pat.Diabetes = reader.GetInt32(7);
                    pat.Digestive = reader.GetInt32(8);
                    pat.Osteoart = reader.GetInt32(9);
                    pat.Psych = reader.GetInt32(10);
                    pat.Pulmonary = reader.GetInt32(11);
                    pat.Charlson = reader.GetInt32(12);
                    pat.Mortality_rsi = reader.GetFloat(13);
                    pat.Complication_rsi = reader.GetFloat(14);
                    pat.JUP_priority_predicted = reader.GetInt32(16);
                    pat.JUP_priority_ideal = reader.GetInt32(17);

                }               
            }
            return pat;
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl.DefaultView;
            
            conn.Close();
        }

    }
}
