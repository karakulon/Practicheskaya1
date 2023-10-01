using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experiment1
{
    internal class A3
    {
        public string? PropertyA3 {  get; set; }
        public B3? B3;

        public A3()
        {
            B3 = new B3 ();
        }
    }
}
