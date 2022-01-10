using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using XGBoost;


namespace OperationPlanner
{
    public partial class FormPatientInfo : Form
    {
        FormAddPatient form;    // FormAddPatient should be FormPatient
        XGBTrainer tr = new XGBTrainer();


        public FormPatientInfo()
        {   // Constructor
            InitializeComponent();
            form = new FormAddPatient(this);
        }

        public void Display()
        {
            DbPatient.DisplayAndSearch("SELECT ID, Name, Age, BMI, Cancer, CVD, Dementia, Diabetes, Digestive, Osteoart, Psych, Pulmonary, Charlson, Mortality_rsi, Complication_rsi, Surgery_type, JUP_priority_predicted, JUP_priority_ideal FROM patient_table", dataGridView1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //FormAddPatient form = new FormAddPatient(this);

            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormPatientInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbPatient.DisplayAndSearch("SELECT ID, Name, Age, BMI, Cancer, CVD, Dementia, Diabetes, Digestive, Osteoart, Psych, Pulmonary, Charlson, Mortality_rsi, Complication_rsi, Surgery_type, JUP_priority_predicted, JUP_priority_ideal FROM patient_table WHERE Name LIKE'%" + txtSearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {   // Edit
                //MessageBox.Show("You ant to edit!");
                form.Clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.age = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.bmi = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.cancer = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.cvd = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.dementia = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.diabetes = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.digestive = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.osteoart = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.psych = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                form.pulmonary = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                form.charlson = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                form.mortality_rsi = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                form.complication_rsi = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                form.surgery_type = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {   // Delete
                if ((MessageBox.Show("Are you sure you want to delete this patient record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)) == DialogResult.Yes)
                {
                    DbPatient.DeletePatient(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                else
                {
                    MessageBox.Show("[ERR_667] Not deleting.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tr.Train();
            MessageBox.Show("Klasyfikator wytrenowany!");
     
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            string napis = "";
            int new_jup_priority;
            Patient pacjent;
            List<string> indeksy;
            indeksy = DbPatient.TakeIDs();
            foreach (string ind in indeksy)
            {
                pacjent = DbPatient.TakeRow(ind);

                new_jup_priority = tr.Predict(pacjent.Age, pacjent.BMI, pacjent.Cancer, pacjent.CVD, pacjent.Dementia, pacjent.Diabetes, pacjent.Digestive, pacjent.Osteoart, pacjent.Psych, pacjent.Pulmonary, pacjent.Charlson, pacjent.Mortality_rsi, pacjent.Complication_rsi);
                pacjent.JUP_priority_predicted = new_jup_priority;          
                DbPatient.UpdatePatient(pacjent, ind, 0);
                
            }
            Display();
            MessageBox.Show("All priorities updated!");
        }


    }
}
