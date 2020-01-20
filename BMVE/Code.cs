using BMVE.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE
{
    class Code : Runnable
    {
        void PrintHelloWorld()
        {
            string helloWorld = "Hello, world!";
            Console_WriteLine(helloWorld);
        }

        public override void Main()
        {
            Console_WriteLine("Hello, Guys");
            Console_WriteLine("Hello, Guys");
            Console_WriteLine("Hello, Guys");
            Console_WriteLine("Hello, Guys");
            Console_WriteLine("Hello, Guys");
        }

    }
}
