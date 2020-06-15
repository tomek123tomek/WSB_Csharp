using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {
    class Photocopier : IPrintable, ICopiable {



        public void Print() {

            Console.WriteLine("PRINTUJE..");
        }

        public void Copy() {
            Console.WriteLine("COPIES");
        }


    }
}
