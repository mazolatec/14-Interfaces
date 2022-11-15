
using System.Globalization;

namespace _07_InterfaceIcomparable.Entities
{
    internal class Employee:IComparable
    {
        string Name { get; set; }
        double Salary { get; set; } 

        public Employee(string cvsEmployee)
        {
            string[] vect= cvsEmployee.Split(',');
            Name = vect[0];
            Salary =double.Parse( vect[1],CultureInfo.InvariantCulture);
        }
       
        public override string ToString()
        {
            return  Name + " - " + "Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture); 
        }

        public int CompareTo(object? obj)
        {
            if (obj is Employee)
            {
                Employee other = obj as Employee;
                return Name.CompareTo(other.Name);
               
            }
            throw new ArgumentException("Comparing Error: argument is not an Employee");
        }
    }
}
