using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experiment1
{
    internal class A2
    {
        public string? PropertyA2 { get; set; }
        public B2? B2;

        public void AddB2(B2 b2)
        {
            B2 = b2;
        }

    }
}
