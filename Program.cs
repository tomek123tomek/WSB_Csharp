using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_lab2
{

    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double temperatureCelsius)
        {
        return (temperatureCelsius* 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
         return (temperatureFahrenheit - 32) * 5 / 9;
        }
    }
    

    class Program
    {


        public struct PointStruct
        {
            public int x, y;
            public PointStruct(int x, int y) { this.x = x; this.y = y; }
        }

        public class PointClass { public int x, y; }




        static void Main(string[] args)
        {
            PointStruct str1 = new PointStruct();

            PointStruct str2 = new PointStruct(5, 5);



            TimeSpan timeSpan = new TimeSpan(1, 12, 30, 30);
            Console.WriteLine(timeSpan.TotalMinutes);
            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(TimeSpan.FromHours(100) - timeSpan);
            Console.WriteLine(TimeSpan.Parse(" 12.12:21:21 "));


            DateTimeOffset dateTimeOffset = DateTimeOffset.UtcNow;
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.DayOfWeek);
            Console.WriteLine(dateTime.DayOfYear);
            Console.WriteLine(dateTime.ToShortTimeString());
            Console.WriteLine(dateTime.IsDaylightSavingTime());
            Console.WriteLine(new DateTime(2020, 01, 01, 12, 0, 0).IsDaylightSavingTime());

            Console.WriteLine((DateTime.Now + TimeSpan.FromDays(2)).DayOfWeek);

            DateTime dateTime1 = new DateTime(2020, 1, 1, 12, 0, 0);
            DateTime dateTime2 = new DateTime(2020, 1, 1, 12, 0, 0);

            Console.WriteLine(dateTime1 == dateTime2);

            DateTime local = DateTime.Now;
            DateTime utc = DateTime.Now.ToUniversalTime();
            Console.WriteLine(local == utc); // false


            PointStruct pointStructA = new PointStruct(1, 1);
            PointStruct pointStructB = new PointStruct(1, 1);



            PointClass pointClassA = new PointClass();
            PointClass pointClassB = new PointClass();

            pointClassA.x = 1;
            pointClassA.y = 1;

            pointClassB.x = 1;
            pointClassB.y = 1;


            Console.WriteLine(pointStructA.Equals(pointStructB));
            // true, bo są tego samego typu i mają te same wartości pól
            // i się do nich nie odwołujemy przez referencje

            Console.WriteLine(pointClassA.Equals(pointClassB));
            // false. Chyba dlatego że każdy obiekt ma inną referencje
            // w sensie, są zapisane w innym miejscu w pamięci,
            // więc z automatu nie są równe




            PointClass pointClassC = pointClassA;
            Console.WriteLine(pointClassA.Equals(pointClassC));
            // teraz odwołują się do tego samego miejsca w pamięci więc true



            PointChanger(pointClassA);
            PointChanger(pointStructA);



            Console.WriteLine(pointStructA.Equals(pointStructB));
            // dalej jest true ?? czyli chyba jest tworzona osobnia kopia struktury wewnatrz metody

            Console.WriteLine(pointClassA.Equals(pointClassB));
            // false



            PointClass pointClassD = pointClassA;
            Console.WriteLine(pointClassA.Equals(pointClassD));
            // true


            Sentence s = new Sentence();
            Console.WriteLine(s[1]); // DEF
            s[1] = " XYZ ";
            Console.WriteLine(s[1]); // XYZ


            Console.WriteLine(Employee2.employeeCounter);
            Employee2 employee1 = new Employee2();
            Employee2 employee2 = new Employee2();
            Console.WriteLine(Employee2.employeeCounter);













            Console.ReadKey();


        }


        public static void PointChanger(PointClass point)
        {
            point.x = 100;
        }

        public static void PointChanger(PointStruct point)
        {
            point.x = 100;
        }
    }
}
