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
            string query = "SELECT Student_ID, First_Name, Last_Name,Phone_Number,Class FROM STUDENT";
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
                    Number = (int)dr["Student_ID"],
                    FirstName = dr["First_Name"].ToString(),
                    LastName = dr["Last_Name"].ToString(),
                    PhoneNumber = (int)dr["Phone_Number"],
                    Class = dr["Class"].ToString(),
                };
                students.Add(student);
            }
            return students;
        }
    }
}