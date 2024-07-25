using System;

namespace Application
{
    public abstract class Employe
    {


        public abstract double CalculateSalary(double numberofmonts);



    }

    class Parineti : Employe
    {
        double bonus;
        double monthsalary;




        public Parineti(double monthsalary, double bonus)
        {
            this.bonus = bonus;
            this.monthsalary = monthsalary;
        }

        public override double CalculateSalary(double numberofmonts)
        {
            if (numberofmonts < 12)
            {
                double a = (monthsalary) * (numberofmonts);
                return a;
            }
            else
            {
                double a = monthsalary * 12 + bonus;
                return a;
            }

        }

    }

    class Goru
    {
        public static void Solution()
        {
            Parineti jaja = new Parineti(2000, 1000);

            double b = jaja.CalculateSalary(12);
            Console.WriteLine(jaja);
            double c = jaja.CalculateSalary(6);
            Console.WriteLine(c);
        }
    }
}