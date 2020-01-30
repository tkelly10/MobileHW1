using System;
namespace MobileHwProgram1_2
{
    public class Teacher : Person
    {
        public int Tenure { get; set; }

        public override string Display()
        {
            string output = null;

            output += string.Format("{0} {1} {2} {3} - {4} Years of Service", Id, Name, Age, Program, Tenure);

            return output;
        }
    }
}
