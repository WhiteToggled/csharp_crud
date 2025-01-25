using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmsApp.Menus
{
    public class MainMenu
    {
        private string valid = "12345";
        private string[] options = {
            "1. Student Management",
            "2. Course Management",
            "3. Registration Management",
            "4. Attendance Management",
            "5. Exit",
        };

        public void display()
        {
            MenuManager.showMenu("Main Menu", options);
            char choice = MenuManager.input(valid);

            switch (choice)
            {
                case '1':
                    new StudentMenu().display();
                    break;
                case '2':
                    new CourseMenu().display();
                    break;
                case '3':
                    new RegistrationMenu().display();
                    break;
                case '4':
                    new AttendanceMenu().display();
                    break;
                case '5':
                    Console.WriteLine("Exiting...");
                    return;
            }
        }

    }
}
