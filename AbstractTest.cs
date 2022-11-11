using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo12
{
    abstract class AbstractTest
    {
        protected int x = 100;
        protected int y = 150;
        public abstract int TestMethod();
        public abstract int GetX
        {
            get;
        }
        public abstract int GetY
        {
            get;
        }
    }
}
