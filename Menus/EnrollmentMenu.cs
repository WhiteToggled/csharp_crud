using System;
using LmsApp.Models;

namespace LmsApp.Menus
{
    public class EnrollmentsMenu
    {
        private readonly string valid = "1234";
        private readonly string[] options = {
            "1. Enroll Student to Course",
            "2. Unenroll Student From Course",
            "3. View All Enrollments",
            "4. Back to Main Menu",
        };

        public void display()
        {
            while (true)
            {
                MenuManager.showMenu("Enrollments Menu", options);
                char choice = MenuManager.input(valid);

                switch (choice)
                {
                    case '1':
                        enrollStudent();
                        break;
                    case '2':
                        unenrollStudent();
                        break;
                    case '3':
                        viewAllEnrollments();
                        Console.WriteLine("Press any key to continue . . ");
                        Console.Read();
                        break;
                    case '4':
                        return;
                }
                Thread.Sleep(500);
            }
        }

        private void enrollStudent()
        {
            Console.Write("Enter Student Registration Number: ");
            string studentRegNo = Console.ReadLine().Trim();
            Console.Write("Enter Course ID: ");
            string courseID = Console.ReadLine().Trim();

            Enrollments enrollment = new Enrollments(studentRegNo, courseID);
            enrollment.EnrollStudent();
            Console.WriteLine("Student successfully enrolled.");
        }

        private void unenrollStudent()
        {
            Console.Write("Enter Student Registration Number: ");
            string studentRegNo = Console.ReadLine().Trim();
            Console.Write("Enter Course ID: ");
            string courseID = Console.ReadLine().Trim();

            Enrollments enrollment = new Enrollments(studentRegNo, courseID);
            enrollment.UnenrollStudent();
            Console.WriteLine("Student successfully unenrolled.");
        }

        private void viewAllEnrollments()
        {
            Enrollments enrollments = new Enrollments("", "");
            enrollments.ShowEnrollments();
        }
    }
}

