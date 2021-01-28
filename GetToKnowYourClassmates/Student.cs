using System;
using System.Collections.Generic;
using System.Text;

namespace GetToKnowYourClassmates
{
    public class Student
    {
        public string Name { get; set; }
        public string Hometown { get; set; }
        public string FavoriteFood { get; set; }
        public string Hobby { get; set; }
        public string Music { get; set; }


        public Student() // Default Constuctor NO PARAMETERS!
        {
            Name = "John Doe";
        }

        public Student(string name, string hometown, string favoriteFood)
        {
            Name = name;
            Hometown = hometown;
            FavoriteFood = favoriteFood;
        }

        public void DisplayHometown()
        {
            Console.WriteLine($"{Name} hometown is {Hometown}");
        }

        public void DisplayFavoriteFood()
        {
            Console.WriteLine($"{Name}'s favorite food is {FavoriteFood}");
        }
    }
}
