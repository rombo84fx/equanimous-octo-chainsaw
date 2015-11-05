using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFour
{
    class Program
    {
        struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }

            public Student(string firstName, string lastName, DateTime birthDate)
            {
                FirstName = firstName;
                LastName = lastName;
                BirthDate = birthDate;
            }
        }

        enum Week
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        enum Month
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }

        static void Main(string[] args)
        {
            Student student1 = new Student("Gerardo", "Martinez", new DateTime(1984, 5, 7));
            Console.WriteLine("The student: {0} {1} was born on {2}", student1.FirstName, student1.LastName, student1.BirthDate.ToString());
            string[] FiveArray = new string[5];
            for (int i = 0; i < FiveArray.Length; i++)
            {
                FiveArray[i] = "arrValue" + i;
            }
            int j = 0;
            while (j < FiveArray.Length)
            {
                Console.WriteLine(FiveArray[j]);
                j++;
            }
            string[] WeekArray = {Week.Monday.ToString()};
            Console.WriteLine("Using WeekAyyray: {0}", WeekArray[0]);
            Console.WriteLine("Using Week: {0}", Week.Monday);
            Console.ReadLine();
        }
    }
}
