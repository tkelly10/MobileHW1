using System;

namespace MobileHwProgram1_2
{
    public abstract class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public SchoolProgram Program { get; set; }

        public abstract string Display();
    }
}
