using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo12
{
    public partial class PartialTest
    {
        public int PrintMath1()
        {
            var result = X+Y;
            Console.WriteLine("The Result is: {0},{1}", X, Y);
            Console.WriteLine("The Result is: {0}", result);

            return result;
        }
    }
}
