﻿using System;
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
            SchoolProgram Program = SchoolProgram.Undeclared;
            int counter = 1;
            string input;
            bool stillGoing;

            do
            {
                
                Console.WriteLine("1) Student\n2) Teacher\n3) Exit");
                input = Console.ReadLine();
                if(input != "3")
                {
                    stillGoing = true;
                    Console.WriteLine("Name: ");
                    Name = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ID: ");
                    Id = Convert.ToInt32(Console.ReadLine());

                    foreach (SchoolProgram sp in Enum.GetValues(typeof(SchoolProgram)))
                    {
                        Console.WriteLine($"{counter}) {sp}");
                        counter++;
                    }
                    counter = 1;
                    int choice = Convert.ToInt32(Console.ReadLine());
                    foreach (SchoolProgram sp in Enum.GetValues(typeof(SchoolProgram)))
                    {
                        if ((choice - 1) == (int)sp)
                        {
                            Program = sp;
                        }
                    }

                    switch (input)
                    {
                        case "1":
                            {
                                Student student = new Student
                                {
                                    Name = Name,
                                    Age = Age,
                                    Id = Id,
                                    Program = Program
                                };
                                Console.WriteLine("Credits Earned: ");
                                student.Credit = Convert.ToInt32(Console.ReadLine());
                                People.Add(student);
                                break;
                            }
                        case "2":
                            {
                                Teacher teacher = new Teacher
                                {
                                    Name = Name,
                                    Age = Age,
                                    Id = Id,
                                    Program = Program
                                };
                                Console.WriteLine("Years of Service");
                                teacher.Tenure = Convert.ToInt32(Console.ReadLine());
                                People.Add(teacher);
                                break;
                            }
                        
                    }
                }
                else { stillGoing = false; }
                
            } while (stillGoing);

            foreach(Person p in People)
            {
                Console.WriteLine(p.Display());
            }
        }



    }
}
