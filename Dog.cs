using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {

    class Dog : Animal {


        public string Breed { get ; private set ;}


        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }



        public void WagItsTail() {
            Console.WriteLine("I'm wagging my tail ... ");
        }


        public override void SayHello(string Name)
        {
            Console.WriteLine("I'm a DOG and my name is {Name} - Woof ! Woof !");
        }



        public override void Cry()
        {
            Console.WriteLine (" Woof ! Woof ! Woof !");
        }











    }
}
