using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {
    abstract class Animal {

        public string Name;
        public float Height;
        public float Weight;

        public Animal(string _name) {
            Name = _name;
        }

        


        public int speed {get; protected set;}

        public void ShowInfo() {
            Console.WriteLine(this.Height);
            Console.WriteLine(this.Name);

        }


        public int Age { get ; private set ; }

         public void SetItsAge ( int age )
         {
            Age = age ;
         }

         public void SetItsAge ( DateTime BirthDate )
         {
            // ...
         }



        public virtual void SayHello()
        {
            Console.WriteLine("I'm an animal");
        }

        public virtual void SayHello(string name) {
            Console.WriteLine("I'm an animal and my name is { Name }");
        }



        public abstract void Cry ();












    }
}
