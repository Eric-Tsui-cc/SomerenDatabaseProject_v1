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
    }
}
