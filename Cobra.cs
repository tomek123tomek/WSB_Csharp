using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {
    class Cobra : Snake {

        public int __long;
        public string name;

        public Cobra(int _long, string _name) : base(_long, _name) {
            __long = _long;
            name = _name;
        }


        public void Cry() {

            Console.WriteLine("COBRA CRY.. ");
        }

    }
}
