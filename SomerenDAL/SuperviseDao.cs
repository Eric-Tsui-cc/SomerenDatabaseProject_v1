using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class SuperviseDao:BaseDao
    {
        public Activity GetByName(string name)
        {
            Activity activity = null;
            string query = "SELECT * FROM Activity WHERE Name = @Name;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@Name", name)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                activity = new Activity
                {
                    id = Convert.ToInt32(row["ActivityId"]),
                    Name = row["Name"].ToString(),
                    Date = (DateTime)row["Date"],
                    Time = row["Time"].ToString(),
                };
            }

            return activity;
        }
        public List<Lecturer> GetLecturersIdByActivity(Activity activity)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            string query = "SELECT * FROM Supervise WHERE ActivityID = @ActivityID;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                 new SqlParameter("@ActivityID", activity.id)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer
                {
                    Number = Convert.ToInt32(dr["LecturerID"]),

                };

                lecturers.Add(lecturer);
            }

            return lecturers;
        }
        public Lecturer GetLecturerByid(int Id)
        {
            Lecturer lecturer = null;
            string query = "SELECT * FROM Lecturer WHERE LecturerID = @LecturerID;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@LecturerID", Id)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                lecturer = new Lecturer
                {
                    Number = Convert.ToInt32(row["LecturerID"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    RoomNumber = row["RoomNumber"].ToString(),
                    PhoneNumber = row["TelePhoneNumber"].ToString(),
                    Age = Convert.ToInt32(row["Age"])
                };
            }
            return lecturer;

        }
        public void DeleteSupervisor(Lecturer lecturer, Activity activity)
        {
            string query = "DELETE FROM Supervise WHERE LecturerID=@id AND activityID=@activityID;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@id", lecturer.Number),
            new SqlParameter("@activityID", activity.id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddSupervisor(Lecturer lecturer,Activity activity)
        {
            string query = "INSERT INTO Supervise (LecturerID, activityID) VALUES (@LecturerID, @activityID);";
            SqlParameter[] sqlParameters =
            {
            new SqlParameter("LecturerID", lecturer.Number),
            new SqlParameter("@activityID", activity.id),
        };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
