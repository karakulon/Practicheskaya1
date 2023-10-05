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
        public List<Student>? Students = new List<Student>();

        public override string ToString()
        {   
            return $"Direction : {Direction}" + "\n" + $"Year : {Year}" + "\n" + $"Number of students - {Students.Count}";
        }
    }
}
