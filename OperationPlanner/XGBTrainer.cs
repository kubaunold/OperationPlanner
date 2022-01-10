using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGBoost;


namespace OperationPlanner
{
    class XGBTrainer
    {

        
        public const int iloscKlas = 40; // Definiujemy ile mamy miec klas na wyjsciu
        public const int iloscParametrow = 13; // Definiujemy ile jest parametrow na podstawie ktorych bedziemy decydowali o przynaleznosci do klasy
        // Inicjalizacja klasyfikatora XGBoost. 

        public void Train()
        {

            // Inicjalizacja klasyfikatora XGBoost. 
            var xgb = new XGBClassifier(objective: "multi:softprob", numClass: iloscKlas);

            // Inicjalizacja list potrzebnych do przekopiowania csv do pamieci programu
            List<float[]> records = new List<float[]>();
            List<float> labels = new List<float>();
            float[][] records_array;
            float[] label_array;

            // Rozpoczecie czytania z pliku
            using (var reader = new StreamReader(@"C:\Users\Michal\source\repos\OperationPlanner\training_1k.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    float[] wiersz = new float[iloscParametrow];
                    wiersz[0] = float.Parse(values[1], CultureInfo.InvariantCulture.NumberFormat); // Age
                    wiersz[1] = float.Parse(values[2], CultureInfo.InvariantCulture.NumberFormat); // BMI
                    wiersz[2] = float.Parse(values[3], CultureInfo.InvariantCulture.NumberFormat); // Diseases
                    wiersz[3] = float.Parse(values[4], CultureInfo.InvariantCulture.NumberFormat);
                    wiersz[4] = float.Parse(values[5], CultureInfo.InvariantCulture.NumberFormat);
                    wiersz[5] = float.Parse(values[6], CultureInfo.InvariantCulture.NumberFormat);
                    wiersz[6] = float.Parse(values[7], CultureInfo.InvariantCulture.NumberFormat);
                    wiersz[7] = float.Parse(values[8], CultureInfo.InvariantCulture.NumberFormat);
                    wiersz[8] = float.Parse(values[9], CultureInfo.InvariantCulture.NumberFormat);
                    wiersz[9] = float.Parse(values[10], CultureInfo.InvariantCulture.NumberFormat);
                    wiersz[10] = float.Parse(values[11], CultureInfo.InvariantCulture.NumberFormat); 
                    wiersz[11] = float.Parse(values[12], CultureInfo.InvariantCulture.NumberFormat); //RSI 1
                    wiersz[12] = float.Parse(values[13], CultureInfo.InvariantCulture.NumberFormat); // RSI 2
              
                    float Label = float.Parse(values[16], CultureInfo.InvariantCulture.NumberFormat); // my rsi formula rounded

                  
                    labels.Add(Label);
                    records.Add(wiersz);
                }
               // Konwersja list do tablicy, tak aby moc wywolac funkcje fit
                records_array = records.ToArray();
                label_array = labels.ToArray();
            }

            // Sprawdzamy czy ilosc rekordow jest rowna ilosci etykiet
            Assert.AreEqual(records_array.Length, label_array.Length);


           // Parametry algorytmu ustawiamy poleceniem setparameter, jako argument podajac nazwe parametru i jego wartosc
           // Te parametry mozna takze podac podczas inicjalizacji klasyfikatora
           xgb.SetParameter("max_depth", 3);
            /* LISTA PARAMETRÓW:
        ["max_depth"] = 3,
        ["learning_rate"] = 0.1f,
        ["n_estimators"] = 100,
        ["silent"] = true,
        ["objective"] = "binary:logistic",
        ["booster"] = "gbtree",
        ["tree_method"] = "auto",
        ["nthread"] = -1,
        ["gamma"] = 0,
        ["min_child_weight"] = 1,
        ["max_delta_step"] = 0,
        ["subsample"] = 1,
        ["colsample_bytree"] = 1,
        ["colsample_bylevel"] = 1,
        ["reg_alpha"] = 0,
        ["reg_lambda"] = 1,
        ["scale_pos_weight"] = 1,
        ["sample_type"] = "uniform",
        ["normalize_type"] = "tree",
        ["rate_drop"] = 0.0f,
        ["one_drop"] = 0,
        ["skip_drop"] = 0f,
        ["base_score"] = 0.5f,
        ["seed"] = 0,
        ["missing"] = float.NaN,
        ["_Booster"] = null,
        ["num_class"] = 0
             */
            // Trenujemy drzewo decyzyjne!
            xgb.Fit(records_array, label_array);
            xgb.SaveModelToFile("Classif.dat");
           
        }

        public int Predict(float age, float bmi, float cancer, float cvd, float dementia, float diabetes, float digestive, float osteoart, float psych, float pulmonary, float charlson, float mortality_rsi, float complication_rsi)
        {
            var new_xgb = new XGBClassifier(objective: "multi:softprob", numClass: iloscKlas);
            new_xgb = XGBClassifier.LoadClassifierFromFile("Classif.dat");
            // Wektor do testow
            float[][] vectorsTest = new float[][]
            {
            new[] {age,bmi,cancer,cvd, dementia,diabetes,digestive,osteoart,psych,pulmonary,charlson,mortality_rsi,complication_rsi},
            };


            // Ponizej funkcje do predyckji. Pierwsza zwraca dokladny wynik prawdopodobienstwa przynaleznosci do danej klasy
            // Druga zwraca wartosci zerojedynkowe. Mozna sobie potestowac
             float[] labelsTestPredicted = new_xgb.PredictRaw(vectorsTest);
            //float[] labelsTestPredicted = xgb.Predict(vectorsTest);
            float maxValue = labelsTestPredicted.Max();
            int maxIndex = Array.IndexOf(labelsTestPredicted, maxValue);
            
            
            // Wypisywanie przewidzianych wartosci
           //for (int i = 0;i< labelsTestPredicted.Length;i++)
            //    Console.Write(labelsTestPredicted[i]);

            return maxIndex;
        }
    }
}
