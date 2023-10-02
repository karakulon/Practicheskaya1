using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experiment1
{
    internal class A
    {
        private B? b;
        public string? PropertyA {  get; set; }
        public B? GetB { get => b; set { b = value; b.GetA = this; } }
    }
}
