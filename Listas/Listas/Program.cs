using System;
using System.Globalization;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int N = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Employee #" + i + ": ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee funcionario = new Employee(id, name, salary);
                list.Add(funcionario);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idRaise = int.Parse(Console.ReadLine());

            if (list.Find(x => x.Id == idRaise) != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Find(x => x.Id == idRaise).Raise(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee funcionario in list)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}