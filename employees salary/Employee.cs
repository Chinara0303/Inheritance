using System;

namespace employees_salary
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Positon;
        public int DailySalary;

        //public Employee(string name, string surname, string positon, int dailysalary)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Positon = positon;
        //    DailySalary = dailysalary;
        //}

        public void MonthlySalary (string Name, string Surname, string Positon, int DailySalary)
        {
            int MonthlySalary = DailySalary * 30;
            Console.WriteLine(MonthlySalary);


        }
    }
}
