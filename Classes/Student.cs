using System;
namespace MobileHwProgram1_2
{
    public class Student : Person
    {
        public int Credit { get; set; }

        public override string Display()
        {
            string output = null;

            output += string.Format("{0} {1} {2} {3} - {4} Credits Earned", Id, Name, Age, Program, Credit);

            return output;
        }

        public Student()
        {

        }
    }
}
