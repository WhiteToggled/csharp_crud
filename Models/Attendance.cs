using System;
using LmsApp.Helpers;

namespace LmsApp.Models
{
    public class Attendance
    {
        public string StudentRegNo { get; set; }
        public string Course_ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Status { get; set; }

        public Attendance(string regno, string crs_id, DateTime time, int status)
        {
            StudentRegNo = regno;
            Course_ID = crs_id;
            TimeStamp = time;
            Status = status;
        }

        public void MarkAttendance()
        {
            string query = $"INSERT INTO Attendance VALUES ('{StudentRegNo}', '{Course_ID}', " +
                           $"'{TimeStamp:yyyy-MM-dd HH:mm:ss}', {Status})";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditAttendance() {
            string query = $"UPDATE Attendance SET Status = {Status} " +
                           $"WHERE StudentRegNo = '{StudentRegNo}' AND Course_ID = '{Course_ID}' AND DATE(TimeStamp) = '{TimeStamp:yyyy-MM-dd}'";
            DatabaseHelper.Instance.Update(query);
        }

        public static void ViewAttendanceByDate(DateTime date)
        {
            string query = $"SELECT * FROM Attendance WHERE DATE(TimeStamp) = '{date:yyyy-MM-dd}'";
            var reader = DatabaseHelper.Instance.getData(query);
            
            while (reader.Read())
            {
                Console.WriteLine($"{reader["StudentRegNo"]} - {reader["Course_ID"]} - {reader["TimeStamp"]} - {(reader["Status"].ToString() == "True" ? "Present" : "Absent")}");
            }
        }
    }
}
