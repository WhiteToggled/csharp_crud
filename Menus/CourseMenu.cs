using System;
using LmsApp.Models;

namespace LmsApp.Menus
{
    public class CourseMenu
    {
        private readonly string valid = "12345";
        private readonly string[] options = {
            "1. Add Course",
            "2. Edit Course",
            "3. Delete Course",
            "4. View All Courses",
            "5. Back to Main Menu",
        };

        public void display()
        {
            while (true)
            {
                MenuManager.showMenu("Course Menu", options);
                char choice = MenuManager.input(valid);

                switch (choice)
                {
                    case '1':
                        addCourse();
                        break;
                    case '2':
                        editCourse();
                        break;
                    case '3':
                        deleteCourse();
                        break;
                    case '4':
                        Course.ShowCourses();
                        Console.WriteLine("Press any key to continue . . ");
                        Console.Read();
                        break;
                    case '5':
                        return;
                }
                Thread.Sleep(500);
            }
        }

        private void addCourse()
        {
            Console.Write("Enter Course ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Course course = new Course(id, name);
            course.AddCourse();
            Console.WriteLine("Course added successfully.");
        }

        private void editCourse()
        {
            Console.Write("Enter Course ID of course to edit: ");
            string id = Console.ReadLine();
            Console.Write("Enter New Course Name: ");
            string name = Console.ReadLine();

            Course course = new Course(id, name);
            course.EditCourse();
            Console.WriteLine("Course edited successfully.");
        }

        private void deleteCourse()
        {
            Console.Write("Enter Course ID of Course to Delete: ");
            string id = Console.ReadLine();

            Course course = new Course(id);
            course.DeleteCourse();
            Console.WriteLine("Course deleted successfully.");
        }
    }
}
