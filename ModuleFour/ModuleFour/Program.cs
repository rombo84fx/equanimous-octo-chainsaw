using System;

namespace ModuleFour
{
    class ModuleFourAssignment
    {
        struct Student
        {
            public string FirstName;
            public string LastName;
            public DateTime BirthDate;

            public Student(string firstName, string lastName, DateTime birthDate)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.BirthDate = birthDate;
            }
        }

        struct Teacher
        {
            public string FirstName;
            public string LastName;
            public DateTime BirthDate;
            
            public Teacher(string firstName, string lastName, DateTime birthDate)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.BirthDate = birthDate;
            } 
        }

        struct Program
        {
            public string ProgramName;
            public string ProgramDescription;
            public string ProgramSchool;

            public Program(string name, string description, string school)
            {
                this.ProgramName = name;
                this.ProgramDescription = description;
                this.ProgramSchool = school;
            }
        }

        struct Course
        {
            public string CourseName;
            public string CourseDescription;
            public string CourseInstructor;

            public Course(string name, string description, string instructor)
            {
                this.CourseName = name;
                this.CourseDescription = description;
                this.CourseInstructor = instructor;
            }
        }

        static void Main(string[] args)
        {
            Student[] StudentArray = new Student[5];
            StudentArray[0] = new Student("Gerardo", "Martinez", new DateTime(1984, 5, 7));
            Console.WriteLine("The information of the first student in the array is:");
            Console.WriteLine("First Name: {0}", StudentArray[0].FirstName);
            Console.WriteLine("Last Name: {0}", StudentArray[0].LastName);
            Console.WriteLine("Birth Date: {0}", StudentArray[0].BirthDate.ToString("d"));
            Console.ReadKey();
        }
    }
}
