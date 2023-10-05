using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experiment2
{
    internal class Student
    {
        public string? Name { get; set; }
        public string? SurName {  get; set; }
        public Group? Group { get; set; }

        public override string ToString()
        {
            return Group.Direction + "  " + Group.Year + "\n" + Name + "  " + SurName;
        }
    }
}
