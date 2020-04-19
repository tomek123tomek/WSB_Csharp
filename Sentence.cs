using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_lab2
{
    class Sentence
    {

        string[] words = " ABC DEF GHI JKL ".Split();


        public string this[int wordNum] // indexer
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }





        }
}
