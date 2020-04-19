using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_lab2
{
    class Employee2
    {

        //static Employee2() => Console.WriteLine(" Typ zainicjalizowany ");

        public string Name { get ; set ;}
        public int Id { get ; set ;}
        public static int employeeCounter; // will be set to zero by default


        public Employee2()
        {
            employeeCounter ++;
        }

        public static void PrintEmployeeCounter()
        {
            Console.WriteLine($"There 're { employeeCounter } employees ");
            //Console.WriteLine(Id);

            // nie pozwoli bo statyczna metoda nie odwołuje się do obiektów tylko do klaasy
            // więc nie pozwoli użyć pól które należą do konretnego obiektu
        }











}
}
