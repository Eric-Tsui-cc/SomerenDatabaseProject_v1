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

            string query = "SELECT Studentnumber, FirstName, LastName,Telephonenumber,RoomNumber,Class FROM STUDENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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