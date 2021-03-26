using System;

// Object Methods | C# | Tutorial 27

namespace CSharpExercises_27
{
    class Program
    {
        static void Main(string[] args)
        {
            // two objects created in the Student class

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            // this uses the object method within the class to determine
            // if gpa qualifies for honors
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            // this uses the object method within the class to determine
            // if the major is Art
            Console.WriteLine(student1.HasArt());
            Console.WriteLine(student2.HasArt());



            Console.ReadLine();
        }
    }
}
