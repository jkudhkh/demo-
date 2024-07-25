using System;
namespace Application
{
    class Shame
    {
        public string name = "Sita";
        public int salary = 20000;


        public virtual void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary for 11 month: " + salary);
        }

        public int CalculateTotalSalary(int bonus)
        {
            int totalSalary = (salary * 12) + bonus;
            return totalSalary;
        }
    }

    class Aanna
    {
        public static void solution()
        {
            Shame AAA = new Shame();
            AAA.show();

            int bonus = 2000;
            int SalarywithBonus = AAA.CalculateTotalSalary(bonus);


            Console.WriteLine("Bonus for one month: " + bonus);
            Console.WriteLine("Total Salary With Bonus: " + SalarywithBonus);
            Console.ReadLine();
        }
    }

}