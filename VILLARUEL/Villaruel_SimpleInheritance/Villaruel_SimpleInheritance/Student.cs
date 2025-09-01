using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Villaruel_SimpleInheritance;

namespace Villaruel_SimpleInheritance
{
    class Student
    {
        public string Name { get; set; }

        public string Program { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Program: " + Program);
        }
    }

    class  RegularStudent : Student
    {
        public string Section { get; set; }     
        
        public void SectionEnrolled()
        {
            Console.WriteLine("Section of Student:" + Section);
        }
    }
}

    class IrregularStudent : Student
{
    public string UnitEnrolled { get; set; }

    public void EnrolledSemUnits()
    {
        Console.WriteLine("Student Units Enrolled:" + UnitEnrolled);
    }
}
