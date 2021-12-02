namespace employees_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Chinara","Ibadova","Backend developer",80);
            //Employee emp = new Employee();
            //emp.Name = "Chinara";
            //emp.Surname = "Ibadova";
            //emp.Positon = "Backend developer";
            //emp.DailySalary = 80;
            emp.MonthlySalary(emp.Name, emp.Surname, emp.Positon, emp.DailySalary);

        }
    }
}
