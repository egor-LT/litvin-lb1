using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Employee
    {
        private string lastName;
        private string firstName;
        private string position;
        private int experience;

        
        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        
        public void SetPositionAndExperience(string position, int experience)
        {
            this.position = position;
            this.experience = experience;
        }

        
        private double CalculateSalary()
        {
            double baseSalary = 30000; 

            
            switch (position.ToLower())
            {
                case "junior":
                    baseSalary += 5000;
                    break;
                case "middle":
                    baseSalary += 10000;
                    break;
                case "senior":
                    baseSalary += 15000;
                    break;
                default:
                    Console.WriteLine("Невірна посада");
                    break;
            }

           
            if (experience > 0)
            {
                baseSalary += experience * 1000;
            }

            return baseSalary;
        }

        
        private double CalculateTax(double salary)
        {
            
            return 0.18 * salary;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Прізвище: {lastName}");
            Console.WriteLine($"Ім'я: {firstName}");
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Стаж: {experience} років");

            double salary = CalculateSalary();
            double tax = CalculateTax(salary);

            Console.WriteLine($"Оклад: {salary:C}");
            Console.WriteLine($"Податковий збір: {tax:C}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть прізвище співробітника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введіть ім'я співробітника:");
            string firstName = Console.ReadLine();

            Employee employee = new Employee(lastName, firstName);

            Console.WriteLine("Введіть посаду співробітника (junior, middle, senior):");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть стаж співробітника (у роках):");
            int experience = int.Parse(Console.ReadLine());

            
            employee.SetPositionAndExperience(position, experience);

            
            employee.DisplayInfo();

            Console.ReadLine(); 
        }
    }
}
