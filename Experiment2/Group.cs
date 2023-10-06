using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace experiment2
{
    internal class Group
    {
        public string? Direction {  get; set; }
        public int? Year { get; set; }
        private List<Student> Students = new List<Student>();

        public override string ToString()
        {   
            string res = $"Direction : {Direction}" + "\n" + $"Year : {Year}" + "\n" + $"Number of students - {Students.Count}\n";
            res = res + "Students:";
            foreach (var student in Students) {
            res =res +"\n"+ student.ToString();
            };
            return res;
        }

        public void Add(Student student)
        {
            Students.Add(student);
            student.Group= this;
        }

        public void New(string name, string surname)
        {
            Students.Add(new Student { Name=name, SurName=surname, Group=this });

        }
        public Group Clone()
        {
            Group clone = new Group { Direction = Direction, Year = Year };
            foreach (Student student in Students)
            {
                clone.Add(student.Clone());
            }
            return clone;
        }
    }
}
