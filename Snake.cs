using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {



    class Snake : Animal {

        public int _long_;

        public Snake(int _long, string name) : base(name)
        {
            _long_ = _long;
        }


        public sealed override void Cry() {

            Console.WriteLine("SNAKE CRY...");
        }


        /*
        public override void ShowInfo() {
            Console.WriteLine("MY LONG IS" + this._long_);

        }
        */






    }
}
