using System;
using System.Globalization;

namespace Listas
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Raise(double percent)
        {
            Salary = Salary + Salary * (percent / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
