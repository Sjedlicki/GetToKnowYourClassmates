using System;
using System.Collections.Generic;

namespace GetToKnowYourClassmates
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Steve", "The Moon", "Spaghetti"),
                new Student("Josh", "Mars Base 1", "Steak"),
                new Student("Tommy", "Pluto", "Grass")
            };

            Student selectedStudent = new Student(); ;

            while(true)
            {
                DisplayStudents(students);


                bool isValid = false;
                while(isValid == false)
                {
                    Console.WriteLine("Please select a Student from Above?");
                    string userSelection = Console.ReadLine();

                    foreach (Student student in students)
                    {
                        if (student.Name.Contains(userSelection, StringComparison.OrdinalIgnoreCase))
                        {
                            selectedStudent = student;
                            isValid = true;
                            break;
                        }                        
                    }
                }

                Console.WriteLine($"Great choice, you chose {selectedStudent.Name}!");

                string yesOrNo =  "y";
                while (yesOrNo == "y")
                {
                    Console.WriteLine($"What would you like to know more about {selectedStudent.Name}. Hometown or Favorite food?");
                    string userInput = Console.ReadLine();

                    if (userInput.Contains("home"))
                    {
                        selectedStudent.DisplayHometown();
                    }
                    else if (userInput.Contains("food") || userInput.Contains("fav"))
                    {
                        selectedStudent.DisplayFavoriteFood();
                    }
                    else
                    {
                        Console.WriteLine("Not a valid selection!");
                    }

                    Console.WriteLine($"Continue learning more about {selectedStudent.Name}? y/n");
                    yesOrNo =Console.ReadLine();
                }

            }

        }

        public static void DisplayStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
