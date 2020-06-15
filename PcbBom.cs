using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatyItp {
    class PcbBom {

         IPrintable printer ;

         public PcbBom ( IPrintable somethingThatPrints )
         {
             printer = somethingThatPrints;
         }
         public void Print ()
         {
             printer.Print();
         }
    }
}
