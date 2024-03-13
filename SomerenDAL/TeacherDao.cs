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
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT lecturer_id, first_name, last_name, telephone_number, age, room_number FROM LECTURER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["lecturer_id"],
                    FirstName = dr["First_Name"].ToString(),
                    LastName = dr["Last_Name"].ToString(),
                    PhoneNumber = (int)dr["Phone_Number"],
                    Age = (int)dr["Age"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
