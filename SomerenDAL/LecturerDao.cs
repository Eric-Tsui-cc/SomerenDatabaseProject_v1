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
            string query = "SELECT LecturerID,FirstName, LastName,TelephoneNumber,Age,RoomNumber FROM Lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            // Create a mock DataTable object
/*            DataTable mockDataTable = new DataTable();
            mockDataTable.Columns.Add("lecturerid", typeof(int));
            mockDataTable.Columns.Add("firstname", typeof(string));
            mockDataTable.Columns.Add("lastname", typeof(string));
            mockDataTable.Columns.Add("telephonenumber", typeof(string));
            mockDataTable.Columns.Add("age", typeof(int));
            mockDataTable.Columns.Add("roomnumber", typeof(int));

            // Add some mock data rows
            mockDataTable.Rows.Add(1, "John", "Doe", "123-456-7890", 40, 101);
            mockDataTable.Rows.Add(2, "Jane", "Smith", "987-654-3210", 35, 102);
            // Add more data rows to simulate real data

            // Call the ReadTables method and return the result
            return ReadTables(mockDataTable);*/

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
    }
}
