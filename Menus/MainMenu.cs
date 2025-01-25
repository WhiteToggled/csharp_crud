using System;

namespace LmsApp.Menus
{
    public class MainMenu
    {
        private readonly string valid = "12345";
        private readonly string[] options = {
            "1. Student Management",
            "2. Course Management",
            "3. Enrollment Management",
            "4. Attendance Management",
            "5. Exit",
        };

        public void display()
        {
            while (true)
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
                        new EnrollmentsMenu().display();
                        break;
                    case '4':
                        Console.WriteLine("AttendanceMenul");
                        // new AttendanceMenu().display();
                        break;
                    case '5':
                        Console.WriteLine("Exiting...");
                        return;
                }
                Thread.Sleep(500);
            }
        }
    }
}
