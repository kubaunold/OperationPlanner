using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationPlanner
{
    public partial class FormAddPatient : Form
    {
        private readonly FormPatientInfo _parent;
        //public string id;
        //public string name;
        //public int age;
        //public int gender;
        //public float bmi;
        public string id, name, age, bmi, cancer, cvd, dementia, diabetes, digestive, osteoart, psych, pulmonary, charlson, mortality_rsi, complication_rsi, surgery_type;

        public FormAddPatient(FormPatientInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        public void UpdateInfo()
        {
            lblFormPatient.Text = "Update Patient";
            btnSave.Text = "Update";
            txtName.Text = name;
            txtAge.Text = age;
            txtBMI.Text = bmi;
            txtCancer.Text = cancer;
            txtCVD.Text = cvd;
            txtDementia.Text = dementia;
            txtDiabetes.Text = diabetes;
            txtDigestive.Text = digestive;
            txtOsteoart.Text = osteoart;
            txtPsych.Text = psych;
            txtPulmonary.Text = pulmonary;
            txtCharlson.Text = charlson;
            txtMortality_rsi.Text = mortality_rsi;
            txtComplication_rsi.Text = complication_rsi;
            txtSurgery_type.Text = surgery_type;
        }

        public void SaveInfo()
        {
            lblFormPatient.Text = "Add Patient";
            btnSave.Text = "Save";
        }

        public void Clear()
        {
            txtName.Text = txtAge.Text = txtBMI.Text = txtCancer.Text = txtCVD.Text = txtDementia.Text = txtDiabetes.Text = txtDigestive.Text = txtOsteoart.Text = txtPsych.Text = txtPulmonary.Text = txtCharlson.Text = txtMortality_rsi.Text = txtComplication_rsi.Text = txtSurgery_type.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Patient name is Empty ( > 3).");
                return;
            }

            float age = -1;
            if (float.TryParse(txtAge.Text, out age))
            {   // parsing successfull
                if (age < 0 || age > 200)
                {
                    MessageBox.Show("Patient age is out of range (0-200).");
                    return;
                }
                else
                {   // age is OK
                }
            }
            else
            {
                MessageBox.Show("Patient age is invalid (0-200).");
            }

            
   

            float bmi = (float)(-1.0);
            if (float.TryParse(txtBMI.Text, out bmi))
            {   // parsing successfull
                if (bmi < 0 || bmi > 100)
                {
                    MessageBox.Show("Patient BMI is out of range (0-100).");
                    return;
                }
                else
                {   // BMI is OK
                }
            }
            else
            {
                MessageBox.Show("Patient BMI is invalid (0-100).");
            }

            int cancer = -1;
            if (int.TryParse(txtCancer.Text, out cancer))
            {   // parsing successfull
                if (cancer < 0 || cancer > 1)
                {
                    MessageBox.Show("Patient cancer must be 0 or 1.");
                    return;
                }
                else
                {   // cancer is OK
                }
            }
            else
            {
                MessageBox.Show("Patient cancer is invalid.");
            }

            int cvd = -1;
            if (int.TryParse(txtCVD.Text, out cvd))
            {   // parsing successfull
                if (cvd < 0 || cvd > 1)
                {
                    MessageBox.Show("Patient cvd must be 0 or 1.");
                    return;
                }
                else
                {   // cvd is OK
                }
            }
            else
            {
                MessageBox.Show("Patient cvd is invalid.");
            }

            int dementia = -1;
            if (int.TryParse(txtDementia.Text, out dementia))
            {   // parsing successfull
                if (dementia < 0 || dementia > 1)
                {
                    MessageBox.Show("Patient dementia must be 0 or 1.");
                    return;
                }
                else
                {   // dementia is OK
                }
            }
            else
            {
                MessageBox.Show("Patient dementia is invalid.");
            }

            int diabetes = -1;
            if (int.TryParse(txtDiabetes.Text, out diabetes))
            {   // parsing successfull
                if (diabetes < 0 || diabetes > 1)
                {
                    MessageBox.Show("Patient diabetes must be 0 or 1.");
                    return;
                }
                else
                {   // diabetes is OK
                }
            }
            else
            {
                MessageBox.Show("Patient diabetes is invalid.");
            }

            int digestive = -1;
            if (int.TryParse(txtDigestive.Text, out digestive))
            {   // parsing successfull
                if (digestive < 0 || digestive > 1)
                {
                    MessageBox.Show("Patient digestive must be 0 or 1.");
                    return;
                }
                else
                {   // digestive is OK
                }
            }
            else
            {
                MessageBox.Show("Patient digestive is invalid.");
            }

            int osteoart = -1;
            if (int.TryParse(txtOsteoart.Text, out osteoart))
            {   // parsing successfull
                if (osteoart < 0 || osteoart > 1)
                {
                    MessageBox.Show("Patient osteoart must be 0 or 1.");
                    return;
                }
                else
                {   // osteoart is OK
                }
            }
            else
            {
                MessageBox.Show("Patient osteoart is invalid.");
            }

            int psych = -1;
            if (int.TryParse(txtPsych.Text, out psych))
            {   // parsing successfull
                if (psych < 0 || psych > 1)
                {
                    MessageBox.Show("Patient psych must be 0 or 1.");
                    return;
                }
                else
                {   // psych is OK
                }
            }
            else
            {
                MessageBox.Show("Patient psych is invalid.");
            }

            int pulmonary = -1;
            if (int.TryParse(txtPulmonary.Text, out pulmonary))
            {   // parsing successfull
                if (pulmonary < 0 || pulmonary > 1)
                {
                    MessageBox.Show("Patient pulmonary must be 0 or 1.");
                    return;
                }
                else
                {   // pulmonary is OK
                }
            }
            else
            {
                MessageBox.Show("Patient pulmonary is invalid.");
            }

            int charlson = -1;
            if (int.TryParse(txtCharlson.Text, out charlson))
            {   // parsing successfull
                if (charlson < 0 || charlson > 24)
                {
                    MessageBox.Show("Patient charlson must be between 0 and 24.");
                    return;
                }
                else
                {   // charlson is OK
                }
            }
            else
            {
                MessageBox.Show("Patient charlson is invalid.");
            }

            float mortality_rsi = -11;
            if (float.TryParse(txtMortality_rsi.Text, out mortality_rsi))
            {   // parsing successfull
                if (mortality_rsi < -10 || mortality_rsi > 10)
                {
                    MessageBox.Show("Patient mortality_rsi must be 0 or 1.");
                    return;
                }
                else
                {   // mortalisty_rsi is OK
                }
            }
            else
            {
                MessageBox.Show("Patient mortality_rsi is invalid.");
            }

            float complication_rsi = -11;
            if (float.TryParse(txtComplication_rsi.Text, out complication_rsi))
            {   // parsing successfull
                if (complication_rsi < -10 || complication_rsi > 10)
                {
                    MessageBox.Show("Patient complication_rsi must be 0 or 1.");
                    return;
                }
                else
                {   // complication_rsi is OK
                }
            }
            else
            {
                MessageBox.Show("Patient complication_rsi is invalid.");
            }

           

            if (btnSave.Text == "Save")
            {   XGBTrainer xg = new XGBTrainer();
                int jup = xg.Predict(age, bmi, cancer,cvd,dementia,diabetes,digestive,osteoart,psych,pulmonary,charlson,mortality_rsi,complication_rsi);
                Patient pat = new Patient(txtName.Text.Trim(), age, bmi, cancer, cvd, dementia, diabetes, digestive, osteoart, psych, pulmonary, charlson, mortality_rsi, complication_rsi, txtSurgery_type.Text.Trim(), jup);

                DbPatient.AddPatient(pat);
                Clear();
            }

            if (btnSave.Text == "Update")
            {
                XGBTrainer xg = new XGBTrainer();
                int jup = xg.Predict(age, bmi, cancer, cvd, dementia, diabetes, digestive, osteoart, psych, pulmonary, charlson, mortality_rsi, complication_rsi);
                Patient pat = new Patient(txtName.Text.Trim(), age, bmi, cancer, cvd, dementia, diabetes, digestive, osteoart, psych, pulmonary, charlson, mortality_rsi, complication_rsi, txtSurgery_type.Text.Trim(), jup);
                DbPatient.UpdatePatient(pat, id, 1);
                Close();
            }

            _parent.Display();
        }
    }
}
