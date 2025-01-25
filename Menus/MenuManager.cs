using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmsApp.Menus
{
    public class MenuManager
    {
        public static void showMenu(string title, string[] options)
        {
            Console.Clear();
            Console.WriteLine($"==== {title} ====");
            for (int i = 0; i < options.Length; ++i)
            {
                Console.WriteLine(options[i]);
            }
            Console.Write("Enter your choice: ");
        }

        public static char input(string validOptions)
        {
            while (true)
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(input) && input.Length == 1)
                {
                    char choice = input[0];

                    if (validateInput(choice, validOptions))
                    {
                        return choice;
                    }
                }

                Console.WriteLine("Invalid Input. Try Again.");
            }
        }

        private static bool validateInput(char selectedOption, string validOptions)
        {
            foreach (char option in validOptions)
            {
                if (selectedOption == option)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

// public static char MainMenu()
// {
//     Console.Clear();
//     Console.WriteLine("======= Main Menu ======");
//     Console.WriteLine("1. Student Management");
//     Console.WriteLine("2. Course Management");
//     Console.WriteLine("3. Registration Management");
//     Console.WriteLine("4. Attendance Management");
//     Console.WriteLine("5. Exit");

//     Console.Write("Enter your choice: ");
//     char choice = (char)Console.Read();
//     return choice;
// }

// public static char StudentMenu()
// {
//     Console.Clear();
//     Console.WriteLine("1. Add Student");
//     Console.WriteLine("2. Edit Student");
//     Console.WriteLine("3. Delete Student");
//     Console.WriteLine("4. Search Student");
//     Console.WriteLine("5. View all Students");
//     Console.WriteLine("6. Back to Main Menu");

//     Console.Write("Enter your choice: ");
//     char choice = (char)Console.Read();
//     return choice;
// }

// public static char CourseMenu()
// {
//     Console.Clear();
//     Console.WriteLine("1. Add Course");
//     Console.WriteLine("2. Edit Course");
//     Console.WriteLine("3. Delete Course");
//     Console.WriteLine("4. View All Courses");
//     Console.WriteLine("6. Back to Main Menu");

//     Console.Write("Enter your choice: ");
//     char choice = (char)Console.Read();
//     return choice;
// }

// public static char RegistrationMenu()
// {
//     Console.Clear();
//     Console.WriteLine("1. Register Student to Course");
//     Console.WriteLine("2. Unregister Student From Course");
//     Console.WriteLine("3. View All Registrations");
//     Console.WriteLine("4. Back to Main Menu");

//     Console.Write("Enter your choice: ");
//     char choice = (char)Console.Read();
//     return choice;
// }

// public static char AttendanceMenu()
// {
//     Console.Clear();
//     Console.WriteLine("1. Mark Attendance");
//     Console.WriteLine("2. Edit Attendance");
//     Console.WriteLine("3. View Attendance By Date");
//     Console.WriteLine("4. Back to Main Menu");

//     Console.Write("Enter your choice: ");
//     char choice = (char)Console.Read();
//     return choice;
// }
