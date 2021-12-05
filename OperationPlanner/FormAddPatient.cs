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
        public string id, name, age, gender, bmi;

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
            txtGender.Text = gender;
            txtBMI.Text = bmi;
        }

        public void SaveInfo()
        {
            lblFormPatient.Text = "Add Patient";
            btnSave.Text = "Save";
        }

        public void Clear()
        {
            txtName.Text = txtAge.Text = txtGender.Text = txtBMI.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Patient name is Empty ( > 3).");
                return;
            }

            int age = -1;
            if (int.TryParse(txtAge.Text, out age))
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

            int gender = -1;
            if(int.TryParse(txtGender.Text, out gender))
            {   // parsing successfull
                if(gender == 1)
                {   // male

                }
                else if (gender == 0)
                {   // female

                }
                else
                {   // error
                    MessageBox.Show("Numbers accepted are: '0' for female or '1' for male).");
                }
            }
            else
            {
                MessageBox.Show("Patient gender is invalid ('0' for female or '1' for male).");
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



            if (btnSave.Text == "Save")
            {
                Patient pat = new Patient(txtName.Text.Trim(), age, (gender==0 ? false : true), bmi);
                DbPatient.AddPatient(pat);
                Clear();
            }

            if (btnSave.Text == "Update")
            {
                Patient pat = new Patient(txtName.Text.Trim(), age, (gender == 0 ? false : true), bmi);
                DbPatient.UpdatePatient(pat, id);

            }

            _parent.Display();
        }
    }
}
