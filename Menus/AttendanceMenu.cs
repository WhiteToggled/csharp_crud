using System;
using LmsApp.Models;

namespace LmsApp.Menus
{
    public class AttendanceMenu
    {
        private readonly string valid = "1234";
        private readonly string[] options = {
            "1. Mark Attendance",
            "2. Edit Attendance",
            "3. View Attendance By Date",
            "4. Back to Main Menu",
        };

        public void display()
        {
            while (true)
            {
                MenuManager.showMenu("Attendance Menu", options);
                char choice = MenuManager.input(valid);

                switch (choice)
                {
                    case '1':
                        markAttendance();
                        break;
                    case '2':
                        editAttendance();
                        break;
                    case '3':
                        viewAttendanceByDate();
                        Console.WriteLine("Press any key to continue . . ");
                        Console.Read();
                        break;
                    case '4':
                        return;
                }
                Thread.Sleep(500);
            }
        }

        private void markAttendance()
        {
            Console.Write("Enter Student Registration Number: ");
            string studentRegNo = Console.ReadLine().Trim();
            Console.Write("Enter Course ID: ");
            string courseID = Console.ReadLine().Trim();
            Console.Write("Enter Attendance Status (1 for Present, 0 for Absent): ");
            int status = int.Parse(Console.ReadLine().Trim());

            Attendance attendance = new Attendance(studentRegNo, courseID, DateTime.Now, status);
            attendance.MarkAttendance();
            Console.WriteLine("Attendance marked successfully.");
        }

        private void editAttendance()
        {
            Console.Write("Enter Student Registration Number: ");
            string studentRegNo = Console.ReadLine().Trim();
            Console.Write("Enter Course ID: ");
            string courseID = Console.ReadLine().Trim();
            Console.Write("Enter New Attendance Status (1 for Present, 0 for Absent): ");
            int status = int.Parse(Console.ReadLine().Trim());

            Attendance attendance = new Attendance(studentRegNo, courseID, DateTime.Now, status);
            attendance.EditAttendance();
            Console.WriteLine("Attendance updated successfully.");
        }
        
        private void viewAttendanceByDate()
        {
            Console.Write("Enter Date (YYYY-MM-DD): ");
            DateTime date = DateTime.Parse(Console.ReadLine().Trim());
            Attendance.ViewAttendanceByDate(date);
        }
    }
}
