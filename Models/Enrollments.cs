using System;

namespace LmsApp.Models
{
    public class Enrollments
    {
        public string StudentRegNo { get; set; }
        public string Course_ID { get; set; }

        public Enrollments(string reg, string id)
        {
            StudentRegNo = reg;
            Course_ID = id;
        }

        public void EnrollStudent()
        {
            string query = $"INSERT INTO Enrollments VALUES ('{StudentRegNo}', '{Course_ID}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void UnenrollStudent()
        {
            string query = $"DELETE FROM Enrollments WHERE StudentRegNo = '{StudentRegNo}' AND Course_ID = '{Course_ID}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void ShowEnrollments()
        {
            string query = "SELECT * FROM Enrollments";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Console.WriteLine($"{reader["StudentRegNo"]} - {reader["Course_ID"]}");
            }
        }
    }
}
