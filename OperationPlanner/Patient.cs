using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlanner
{
    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public float BMI { get; set; }

        public Patient(string name, int age, bool gender, float bmi)
        {
            Name = name;
            Age = age;
            Gender = gender;
            BMI = bmi;
        }
    }
}
