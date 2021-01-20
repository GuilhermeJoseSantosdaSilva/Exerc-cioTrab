using System;
using ExemploEnum.Entities;
using ExemploEnum.Entities.Enums;

namespace ExemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's name: ");
            Department dep = new Department
            {
                Name = Console.ReadLine()
            };
            Console.WriteLine("\bEnter worker data: ");
            Console.Write("\bName: ");
            string name = Console.ReadLine();
            Console.Write("\bLevel (JUNIOR/MIDLEVEL/SENIOR): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("\bBase Salary: ");
            double baseS = Convert.ToDouble(Console.ReadLine());
            Worker wrk = new Worker
            {
                Name = name,
                BaseSalary = baseS,
                Level = level
            };
            Console.Write("\bHow many contracts to this worker?: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<number; i++)
            {
                DateTime date;
                string[] dat;
                int day, month, year, duration;
                double value;

                Console.Write("Enter the initial date (DD/MM/YYYY): ");
                dat = Console.ReadLine().Split('/');
                day = Convert.ToInt32(dat[0]);
                month = Convert.ToInt32(dat[1]);
                year = Convert.ToInt32(dat[2]);
                date = new DateTime(year, month, day);
                Console.Write("Hours: ");
                duration = Convert.ToInt32(Console.ReadLine());
                Console.Write("Value per Hour: ");
                value = Convert.ToDouble(Console.ReadLine());

                HourContract contract = new HourContract
                {
                    Hour = duration,
                    Date = date,
                    ValueperHour = value
                };

                wrk.addContract(contract);
            }

            Console.Write("\bEnter the month and year to calculate income (MM/YYYY): ");
            string[] dat2 = Console.ReadLine().Split('/');
            int month2 = Convert.ToInt32(dat2[0]);
            int year2 = Convert.ToInt32(dat2[1]);
            double total = wrk.income(month2, year2) + wrk.BaseSalary;
            Console.WriteLine();
            Console.WriteLine($"\bName: {wrk.Name}");
            Console.WriteLine($"\bDepartment: {dep.Name}");
            Console.WriteLine($"\bIncome for {month2}/{year2}: R${total:F2}");          
        }
    }
}
