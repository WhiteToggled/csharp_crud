using System;
using LmsApp.Models;

namespace LmsApp.Menus
{
    public class StudentMenu
    {
        private readonly string valid = "123456";
        private readonly string[] options = {
            "1. Add Student",
            "2. Edit Student",
            "3. Delete Student",
            "4. Search Student",
            "5. View all Students",
            "6. Back to Main Menu",
        };

        public void display()
        {
            while (true)
            {
                MenuManager.showMenu("Student Menu", options);
                char choice = MenuManager.input(valid);

                switch (choice)
                {
                    case '1':
                        addStudent();
                        break;
                    case '2':
                        editStudent();
                        break;
                    case '3':
                        deleteStudent();
                        break;
                    case '4':
                        searchStudent();
                        break;
                    case '5':
                        viewAllStudents();
                        break;
                    case '6':
                        return;
                }
            }
        }

        private void addStudent()
        {
            Console.Write("Enter RegNo: ");
            string regNo = Console.ReadLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Department: ");
            string department = Console.ReadLine();
            Console.Write("Enter Session: ");
            int session = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            float cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Student student = new Student(regNo, name, department, session, cgpa, address);
            student.AddStudent();
            Console.WriteLine("Student added successfully.");
        }

        private void editStudent()
        {
            Console.Write("Enter RegNo of Student to Edit: ");
            string regNo = Console.ReadLine();
            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter New CGPA: ");
            float cgpa = float.Parse(Console.ReadLine());

            Student student = new Student(regNo, name, cgpa: cgpa);
            student.EditStudent();
            Console.WriteLine("Student updated successfully.");
        }

        private void deleteStudent()
        {
            Console.Write("Enter RegNo of Student to Delete: ");
            string regNo = Console.ReadLine();

            Student student = new Student(regNo);
            student.DeleteStudent();
            Console.WriteLine("Student deleted successfully.");
        }

        private void searchStudent()
        {
            Console.WriteLine("Enter RegNo of student to search: ");
            string regNo = Console.ReadLine();

            Student student = new Student(regNo);
            student.SearchStudent();
        }

        private void viewAllStudents()
        {
            Student student = new Student("");
            student.ShowStudents();
        }
    }
}
