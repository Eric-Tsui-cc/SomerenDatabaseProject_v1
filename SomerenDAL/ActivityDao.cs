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
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT Name, CONVERT(date, Date) AS ActivityDate, CONVERT(time, Time) AS ActivityTime FROM ACTIVITY";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    Name = dr["Name"].ToString(),
                    Date = Convert.ToDateTime(dr["ActivityDate"]),
                    Time = dr["ActivityTime"].ToString()
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
