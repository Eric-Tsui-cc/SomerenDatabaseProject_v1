using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        public List<Lecturer> GetAllLecturers()
        {
            string query = "SELECT lecturerid, firstname, lastname, telephonenumber, age, roomnumber FROM LECTURER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));


        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer> teachers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer teacher = new Lecturer()
                {
                    Number = (int)dr["LecturerID"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    PhoneNumber = dr["TelephoneNumber"].ToString(),
                    Age = (int)dr["Age"],
                    RoomNumber = dr["RoomNumber"].ToString()
                };
            teachers.Add(teacher) ;
            }
            return teachers;
        }
        // for adding lecturer to the database
        public void AddLecturer(Lecturer lecturer)
        {
            string query = "INSERT INTO Lecturer (LecturerID, FirstName, LastName, TelephoneNumber, Age, RoomNumber) VALUES (@LaecturerID, @FirstName, @LastName, @TelephoneNumber, @Age, @RoomNumber)";
            SqlParameter[] sqlParameters =
            {
            new SqlParameter("@LaecturerID", lecturer.Number),
            new SqlParameter("@FirstName", lecturer.FirstName),
            new SqlParameter("@LastName", lecturer.LastName),
            new SqlParameter("@TelephoneNumber", lecturer.PhoneNumber),
            new SqlParameter("@Age", lecturer.Age),
            new SqlParameter("@RoomNumber", lecturer.RoomNumber)
        };
            ExecuteEditQuery(query, sqlParameters);
        }

        //for editting the lecturer table 
        public void UpdateLecturer(Lecturer lecturer)
        {
            string query = "UPDATE Lecturer " +
                           "SET LecturerID=@LecturerID,FirstName=@FirstName, LastName=@LastName, TelephoneNumber=@TelephoneNumber, Age=@Age, RoomNumber=@RoomNumber " +
                           "WHERE LecturerID=@LecturerID;";
            SqlParameter[] sqlParameters =
            {
            new SqlParameter("@LecturerID", lecturer.Number),
            new SqlParameter("@FirstName", lecturer.FirstName),
            new SqlParameter("@LastName", lecturer.LastName),
            new SqlParameter("@TelephoneNumber", lecturer.PhoneNumber),
            new SqlParameter("@Age", lecturer.Age),
            new SqlParameter("@RoomNumber", lecturer.RoomNumber)
        };
            ExecuteEditQuery(query, sqlParameters);
        }
        
        //for deleting a lecturer form the database 
        public void DeleteLecturer(Lecturer lecturer)
        {
            string query = "DELETE FROM Lecturer WHERE LecturerID=@LecturerID;";
            SqlParameter[] sqlParameters =
            {
            new SqlParameter("@LecturerID", lecturer.Number)
        };
            ExecuteEditQuery(query, sqlParameters);
        }

        public Lecturer GetByLecturerID(int lecturerID)
        {
            Lecturer lecturer = null;
            string query = "SELECT * FROM Lecturer WHERE LecturerID=@LectureID;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                 new SqlParameter("@LectureID", lecturerID)
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
                    PhoneNumber = row["TelephoneNumber"].ToString(),
                    Age =Convert.ToInt32( row["age"]),
                    RoomNumber = row["RoomNumber"].ToString()
                };
            }

            return lecturer;
        }

       

    }
}
