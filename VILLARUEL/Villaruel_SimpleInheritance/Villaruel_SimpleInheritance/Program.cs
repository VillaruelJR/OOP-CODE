using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villaruel_SimpleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JOHN ROBERT C. VILLARUEL
            //BSIT-301
            //TITLE: Simple Inheritance
            
            RegularStudent student = new RegularStudent();
            student.Name = "JOHN ROBERT VILLARUEL";
            student.Program = "BSIT";
            student.Section = "301";
           
 

            IrregularStudent student1 = new IrregularStudent();
            student1.Name = "JOHN ROBERT VILLARUEL";
            student1.Program = "BSIT";
            student1.UnitEnrolled = "20";

            Console.ReadKey();
        }
    }
}
