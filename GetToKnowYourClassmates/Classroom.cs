using System;
using System.Collections.Generic;
using System.Text;

namespace GetToKnowYourClassmates
{
    public class Classroom
    {
        public List<Student> Students { get; set; }

        public Classroom()
        {
            Students = new List<Student>()
            {
                new Student("Steve", "The Moon", "Spaghetti"),
                new Student("Josh", "Mars Base 1", "Steak"),
                new Student("Tommy", "Pluto", "Grass")
            };
        }
    }
}
