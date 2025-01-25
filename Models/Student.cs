using System;
using LmsApp.Helpers;

namespace LmsApp.Models
{
    public class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Session { get; set; }
        // public float Cgpa { get; set; }
        public string Address { get; set; }

        public Student(string regNo, string name = null, string department = null, int session = 0, string address = null)
        {
            RegNo = regNo;
            Name = name;
            Department = department;
            Session = session;
            // Cgpa = cgpa;
            Address = address;
        }

        public void AddStudent()
        {
            string query = $"INSERT INTO Student VALUES ('{RegNo}', '{Name}', '{Department}', {Session}, '{Address}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditStudent()
        {
            string query = $"UPDATE Student SET Name = '{Name}', Department = '{Department}', " +
                           $"Session = {Session}, Address = '{Address}' WHERE RegistrationNumber = '{RegNo}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteStudent()
        {
            string query = $"DELETE FROM Student WHERE RegistrationNumber = '{RegNo}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void SearchStudent()
        {
            string query = $"SELECT * FROM Student WHERE RegistrationNumber = '{RegNo}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                Console.WriteLine($"{reader["RegistrationNumber"]} - {reader["Name"]} - {reader["Department"]} - {reader["Session"]} - {reader["Address"]}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public static void ShowStudents()
        {
            string query = "SELECT * FROM Student";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Console.WriteLine($"{reader["RegistrationNumber"]} - {reader["Name"]} - {reader["Department"]} - {reader["Session"]} - {reader["Address"]}");
            }
        }
    }
}
