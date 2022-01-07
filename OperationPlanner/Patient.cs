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
        public float Age { get; set; }
        public float BMI { get; set; }
        public int Cancer{ get; set; }
        public int CVD { get; set; }
        public int Dementia { get; set; }
        public int Diabetes { get; set; }
        public int Digestive { get; set; }
        public int Osteoart { get; set; }
        public int Psych { get; set; }
        public int Pulmonary { get; set; }
        public int Charlson { get; set; }
        public float Mortality_rsi { get; set; }
        public float Complication_rsi { get; set; }
        public string Surgery_type { get; set; }
        public int JUP_priority_predicted { get; set; }
        public int JUP_priority_ideal { get; set; }


        // Zeby dodac idealny priorytet zmienic konstuktor i 0 w ciele funkcji
        public Patient(string name, float age, float bmi, int cancer, int cvd, int dementia, int diabetes, int digestive, 
            int osteoart, int psych, int pulmonary, int charlson, float mortality_rsi, float complication_rsi, string surgery_type, int jup_priority_predicted)
        {
            Name = name;
            Age = age;
            BMI = bmi;
            Cancer = cancer;
            CVD = cvd;
            Dementia = dementia;
            Diabetes = diabetes;
            Digestive = digestive;
            Osteoart = osteoart;
            Psych = psych;
            Pulmonary = pulmonary;
            Charlson = charlson;
            Mortality_rsi = mortality_rsi;
            Complication_rsi = complication_rsi;
            Surgery_type = surgery_type;
            JUP_priority_predicted = jup_priority_predicted;
            JUP_priority_ideal = 0;

        }
    }
}
