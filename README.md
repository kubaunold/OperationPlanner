# OperationPlanner
App for scheduling surgical operations. Robust optimization with Random Machine Breakdowns.

## Project documentation in Overleaf
https://www.overleaf.com/6178914446zhmjdrmdwhkg

## Useful Links
Installing XAMPP'a https://www.youtube.com/watch?v=WSeKPbVZBoo&t=2s

Key tutorial link https://www.youtube.com/watch?v=NrJiEjzyhYc&t=924s&ab_channel=IAmTimCorey

## Copy run environment
1) run Apache and MySQL and open `Admin` page of MySql
![image](https://user-images.githubusercontent.com/48590717/144767103-b535efb5-6d1e-4dd2-8f20-6c6ecfabee22.png)

2) import mock database provided in the repo (`patient.sql`)
![image](https://user-images.githubusercontent.com/48590717/144767377-8f6954c8-fb92-4e35-a6cc-877308c7ec3b.png)

## Adding importing .csv file to sql db
File must look like `patients_csv_v3_only100.csv`
When importing, ommit 0th row (Skip this number of queries (for SQL) starting from the first one: 1) and remove `"` delimiters

## GNATOWSKI -> ToDo:
- Zrobić większy zbiór testowy, tak ok. 10% zbioru treningowego;
- Próbkować różne rekordy do zbioru, a potem wyciągnąć średnią. Czyli nie brać do testów cały czas tych samych 1000 rekordów ale inne za każdym razem i zrobić 10 prób;
- Spróbować zobaczyć co stanie się jak będzie inna liczba klas wyjściowych, czyli nie 40, a np. 10;
- Jak robimy badania dla zbioru treningowego mniejszego niż 30000 to też próbkować i wyciągnąć średnią
