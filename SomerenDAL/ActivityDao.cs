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
            //string query = "SELECT Name, CONVERT(date, Date) AS ActivityDate, CONVERT(time, Time) AS ActivityTime FROM ACTIVITY";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            // Create a mock DataTable object
            DataTable mockDataTable = new DataTable();
            mockDataTable.Columns.Add("Name", typeof(string));
            mockDataTable.Columns.Add("ActivityDate", typeof(DateTime));
            mockDataTable.Columns.Add("ActivityTime", typeof(TimeSpan));

            // Add some mock data rows
            mockDataTable.Rows.Add("Meeting", DateTime.Today, new TimeSpan(10, 0, 0)); // Example date and time
            mockDataTable.Rows.Add("Training", DateTime.Today.AddDays(1), new TimeSpan(14, 30, 0)); // Example date and time
                                                                                                    // Add more data rows to simulate real data

            // Call the ReadTables method and return the result
            return ReadTables(mockDataTable);
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
