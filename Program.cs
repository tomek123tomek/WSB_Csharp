# define TRACE_ON
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;

namespace DelegatyItp {

    
    class Program {
        static int Squere(int x) {
            return x * x;
        }

        static int Multiply(int x, int y) {
            return x * y;
        }

        [Obsolete(" Legacy implementation , use ... instead ")] // warning
        [Conditional("TRACE_ON")]
        public static void Log ( string logMsg )
        {
            Console . WriteLine ( logMsg );
        }


        

        static void Main(string[] args) {

            Dog piesek1 = new Dog("Puszek", "pudel");

            piesek1.Height = 12;
            piesek1.Name = "Puszor";

            piesek1.ShowInfo();
            piesek1.WagItsTail();


            Animal myAnimal = new Dog("Azor", "pudel");
            myAnimal.Name = "Azorek";

            //Dog myDog = new Animal();

            Dog myDog = new Dog("Wika", "bulldog");
            Animal a = myDog ; // rzutowanie w gore

            //Console . WriteLine (a.Name );
            //a.WagItsTail (); // blad kompilacji

            //Dog d = (Dog)a;
            //a.WagItsTail(); // wywolanie metody sie uda

            //Animal puszek2 = new Animal("Puszek"); // niemozna

            myAnimal.SetItsAge(12);

            Snake snejk1 = new Snake(3, "Bidon");

            //snejk1.showInfo();
            snejk1.Cry();

            Cobra koberka = new Cobra(3, "KOBERKA");
            //koberka.Cry(); nie dziala bo snejk:sealed


            IPrintable printer = new Printer();
            ICopiable copier = new Photocopier();



            var pcbBomA = new PcbBom(printer);
            //var pcbBomB = new PcbBom(copier);

            pcbBomA.Print();
            //pcbBomB.Print();



            
            ExampleTransformer transformer = new ExampleTransformer();
            transformer.TransformationCompleted += () => Console.WriteLine("ZROBIONE");
            transformer.Transform(Squere, 2);
            transformer.Transform(Multiply, 3, 2);
            transformer.Transform((x) => { return x * x * x * x; }, 2);
            transformer.Transform((x, y) => { return x / y; }, 2, 0);
            

            List<string> lst = new List<string>();

            lst.Add("Ross Gellar");
            lst.Add("Chandler Bing");
            lst.Add("Joey Tribbiani");
            lst.Add("Monika Geller");

            var gellers = lst.Where(x => x.Contains("Gellar")).ToList();

            Type type = typeof(Configuration);

            MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.Static);
            Console.WriteLine(" The methods of the Configuration class are : ");

            foreach (var temp in methodInfos) {
                Console.WriteLine(temp.Name);
            }

            PropertyInfo[] propertiesInfos = type.GetProperties();

            foreach (var temp in propertiesInfos) {
                Console.WriteLine(temp.Name);
            }

            Console.WriteLine("Specify, full class name");

            string className = Console.ReadLine();

            object ret = Activator.CreateInstance(Type.GetType(className));
            Console.WriteLine(ret.GetType().FullName);

            PropertyInfo propertyInfo = ret.GetType().GetProperty("MaxUsersCount");
            //propertyInfo.SetValue(ret ,12345);
            //Console.WriteLine(" MaxUsersCount value has been set to: " + ( ret as Configuration ). MaxUsersCount); 
            // before one has to cast to configuration (?. skip if null )


            Log("COS"); // z TRACE_ON metoda jest wywolywania, bez nie
            


            var customAttributes = typeof ( Configuration ). GetCustomAttributes ();
            foreach ( var attribute in customAttributes )
            {
                Console.WriteLine((attribute as CustomAttribute )?.Author);
                Console.WriteLine((attribute as CustomAttribute )? Description);
            }

            Configuration config = new Configuration();

            config.MaxUserCount = 10;
            config.MaxUserPasswordLength = 15;
            config.MinUserPasswordLength = 8;

            Configuration.Save(config , "Config.xml");
            Console.ReadLine();
        }


    }
}
