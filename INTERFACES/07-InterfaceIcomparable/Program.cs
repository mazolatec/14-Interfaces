using _07_InterfaceIcomparable.Entities;

namespace _07_InterfaceIcomparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\filecvs.txt";

            try
            {
                using (StreamReader sr= File.OpenText(path)) 
                {
                    List<Employee> listEmployee = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        listEmployee.Add(new Employee(sr.ReadLine()));
                    }
                    listEmployee.Sort();
                    foreach (Employee emp in listEmployee)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}