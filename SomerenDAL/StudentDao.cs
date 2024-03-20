using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {

            //string query = "SELECT Studentnumber, FirstName, LastName,Telephonenumber,RoomNumber,Class FROM STUDENT";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            // Create a mock DataTable object
            DataTable mockDataTable = new DataTable();
            mockDataTable.Columns.Add("Studentnumber", typeof(int));
            mockDataTable.Columns.Add("FirstName", typeof(string));
            mockDataTable.Columns.Add("LastName", typeof(string));
            mockDataTable.Columns.Add("Telephonenumber", typeof(string));
            mockDataTable.Columns.Add("RoomNumber", typeof(string));
            mockDataTable.Columns.Add("Class", typeof(string));

            // Add some mock data rows
            mockDataTable.Rows.Add(1, "John", "Doe", "123-456-7890", "101", "Math");
            mockDataTable.Rows.Add(2, "Jane", "Smith", "987-654-3210", "102", "History");
            // Add more data rows to simulate real data

            // Call the ReadTables method and return the result
            return ReadTables(mockDataTable);
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["Studentnumber"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    TelePhoneNumber = dr["TelePhoneNumber"].ToString(),
                    RoomNumber = dr["RoomNumber"].ToString(),
                    Class = dr["Class"].ToString(),
                };
                students.Add(student);
            }
            return students;
        }
    }
}