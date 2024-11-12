using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Basics.Models
{
    internal class Student
    {
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Birthday { get; set; } = "";
        public string School { get; set; } = "";

        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student{Name="name1", Gender="남", Birthday="Birthday1", School="School1"},
            new Student{Name="name22", Gender="여", Birthday="Birthday22", School="School22"},
            new Student{Name="name333", Gender="남", Birthday="Birthday333", School="School333"},
            new Student{Name="name4444", Gender="여", Birthday="Birthday4444", School="School4444"}
        };

        public Student()
        {

        }

        public override string ToString()
        {
            return $"Name:{Name}, Gender:{Gender}, Birthday:{Birthday}, School:{School}";
        }
    }
}
