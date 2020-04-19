using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("tomek123", "tomek321", 4000.99m);
            employee1.firstName = "Chandler";
            employee1.lastName = "Bing";
            //employee1.salary = 4000.99m;
            employee1.age = 30;
            //employee1.login = "tomek123";
            //employee1.password = "tomek321";

            Console.WriteLine($"First name : { employee1.firstName }");
            Console.WriteLine($"Last name : { employee1.lastName }");
            Console.WriteLine($"Age : + { employee1.age }");
            Console.WriteLine($"Salary : + { employee1.salary }");

            employee1.ItsEducation = Employee.Education.Higher;

            //Console.WriteLine(employee.isAdult());

            //Console.WriteLine(employee.CheckCredentials("tomek123", "tomek321"));
            Console.WriteLine(employee1.CheckCredentials("tomek123", "txomek321"));



            List<Employee> employeesLst = new List<Employee>();
            employeesLst.Add(employee1);

            Console.WriteLine(employeesLst.Count());

            foreach (var x in employeesLst)
            {
                Console.WriteLine(x.lastName);
            }











            Console.ReadKey();


        }
    }
}
