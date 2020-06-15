using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {
    [AttributeUsage(AttributeTargets.Class)]

    class CustomAttribute : Attribute {

        public string Author { get ; }
        public string Description { get ; }

        public CustomAttribute ( string author , string description )
        {
            Author = author ;
            Description = description ;
         }








    }
}
