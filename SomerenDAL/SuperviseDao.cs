using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class SuperviseDao:BaseDao
    {
        public Lecturer GetLecturerNameById(string id)
        {
            Lecturer lecturer = new Lecturer();
            string query = "SELECT lecturer.FirstName, lecturer.LastName FROM Supervise INNER JOIN lecturer ON Supervise.lecturerid = lecturer.lecturerid WHERE supervise.lecturerid = @lecturerid;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@lecturerid", id)
            };
            DataTable resultTable = ExecuteSelectQuery(query, sqlParameters);

            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                DataRow dr = resultTable.Rows[0]; // Assuming there's only one row
                lecturer.FirstName = dr["FirstName"].ToString();
                lecturer.LastName = dr["LastName"].ToString();
            }

            return lecturer;
        }
    }
}
