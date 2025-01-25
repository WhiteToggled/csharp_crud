using System;

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
