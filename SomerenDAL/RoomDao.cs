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
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT RoomNumber, Building, RoomType, FloorNumber FROM Room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadRooms(ExecuteSelectQuery(query, sqlParameters));

            // Create a mock DataTable object
            /*            DataTable mockDataTable = new DataTable();
                        mockDataTable.Columns.Add("roomnumber", typeof(int));
                        mockDataTable.Columns.Add("buildingnumber", typeof(int));
                        mockDataTable.Columns.Add("roomtype", typeof(string));
                        mockDataTable.Columns.Add("floornumber", typeof(int));

                        // Add some mock data rows
                        mockDataTable.Rows.Add(101, 1, "Single", 1);
                        mockDataTable.Rows.Add(102, 1, "Double", 2);
                        // Add more data rows to simulate real data

                        // Call the ReadRooms method and return the result
                        return ReadRooms(mockDataTable);*/
        }

        private List<Room> ReadRooms(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room();

                room.RoomNumber = dr["RoomNumber"].ToString();
                room.Building = dr["Building"].ToString();
                room.RoomType = (int)dr["RoomType"] ;
                room.FloorNumber = (int)dr["FloorNumber"];
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
