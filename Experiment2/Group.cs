using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experiment2
{
    internal class Group
    {
        public string? Direction {  get; set; }
        public int? Year { get; set; }
        public Student? Student { get; set; }

        public override string ToString()
        {
            return Direction + "  " + Year + "\n" + Student.Name + "  " + Student.SurName;
        }
    }
}
