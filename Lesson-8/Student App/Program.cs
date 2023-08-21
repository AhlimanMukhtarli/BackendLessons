using System;
using System.Collections.Generic;

namespace Student_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            List<StudentClass> list = new List<StudentClass>();
            while (true)
            {
                Console.WriteLine("Enter your Full Name:");
                string fullname = Console.ReadLine();
                Console.WriteLine("Enter your group number:");
                int groupnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your age:");
                byte age = Convert.ToByte(Console.ReadLine());
                StudentClass student = new StudentClass(fullname, groupnumber, age);
                list.Add(student);

                Console.WriteLine("Student added successfully");

                // Get and display birth year
                int birthYear = student.GetBirthYear();
                Console.WriteLine($"Your birth year is: {birthYear}");

                // Example usage: Count students in a specific group
                Console.WriteLine("Enter the group number to count students:");
                int targetGroup = Convert.ToInt32(Console.ReadLine());
                int studentCountInGroup = CountStudentsInGroup(targetGroup, list);
                Console.WriteLine($"Number of students in group {targetGroup}: {studentCountInGroup}");
            }

            static int CountStudentsInGroup(int targetGroup, List<StudentClass> students)
            {
                int count = 0;
                foreach (StudentClass student in students)
                {
                    if (student.GroupNo == targetGroup)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        class StudentClass
        {
            public string FullName { get; set; }
            public int GroupNo { get; set; }
            public byte Age { get; set; }

            public StudentClass(string fullname, int groupnumber, byte age)
            {
                FullName = fullname;
                GroupNo = groupnumber;
                Age = age;
            }

            public int GetBirthYear()
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - Age;

            }



        }
        #endregion

    }
}
