using System;
using System.Collections;
using System.Collections.Generic;

namespace MobileHwProgram1_2
{
    public class Program2
    {
        public Program2()
        {
            List<Person> People = new List<Person>();
            string Name;
            int Age;
            int Id;
            SchoolProgram Program;
            string input;

            do
            {
                Console.WriteLine("1) Student\n2) Teacher\n3) Exit");
                input = Console.ReadLine();

            } while (input != "3");


        }



    }
}
