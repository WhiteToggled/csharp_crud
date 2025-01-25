using System;

namespace LmsApp.Models
{
    public class Course
    {
        public string Course_ID { get; set; }
        public string Course_Name { get; set; }

        public Course(string id, string name = null)
        {
            Course_ID = id;
            Course_Name = name;
        }

        public void AddCourse()
        {
            string query = $"INSERT INTO Course VALUES ('{Course_ID}', '{Course_Name}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditCourse()
        {
            string query = $"UPDATE Course SET  Course_Name = '{Course_Name}' WHERE Course_ID = '{Course_ID}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteCourse()
        {
            string query = $"DELETE FROM Course WHERE Course_ID = '{Course_ID}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void ShowCourses()
        {
            string query = "SELECT * FROM Course";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Course_ID"]} - {reader["Course_Name"]}");
            }
        }
    }
}
