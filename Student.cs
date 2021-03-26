using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises_27
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        // constructor to create student
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        // object method to find if student has honors
        public bool HasHonors()
        {
            //gpa = 90.4;

            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

        // object method to find if student is an Art major
        public bool HasArt()
        {
            

            if (major == "Art")
            {
                return true;
            }
            return false;
        }





    }
}
