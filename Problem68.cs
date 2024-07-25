using System;
namespace Application
{
    public abstract class Employee
    {
        public decimal salaryPerMonth;

        public Employee(decimal salaryPerMonth)
        {
            this.salaryPerMonth = salaryPerMonth;
        }
        public abstract decimal CalculateTotalSalary();
    }
    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(decimal salaryPerMonth) : base(salaryPerMonth)
        {

        }
        public override decimal CalculateTotalSalary()
        {
            return (salaryPerMonth * 12) + salaryPerMonth;
        }
    }

    class Program
    {
        public static void solution()
        {

            SalariedEmployee employee = new SalariedEmployee(5000);
            decimal totalSalary = employee.CalculateTotalSalary();

            Console.WriteLine("Total compensation for the employee: " + totalSalary);
        }
    }
}


