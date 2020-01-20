using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core
{
    public partial class Runnable
    {
        public virtual void Main()
        {
            Console_WriteLine("You should create a BlackMagic.Runnable child class");
            Console_WriteLine("and overload \"Main\" method");
        }
    }
}
