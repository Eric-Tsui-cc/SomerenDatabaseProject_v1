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
            string query = "SELECT roomnumber, buildingnumber, roomtype, floornumber FROM ROOM";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadRooms(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadRooms(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room();

                // Check if the value is DBNull before casting
                room.RoomNumber = dr["roomnumber"] != DBNull.Value ? Convert.ToInt32(dr["roomnumber"]) : 0;
                room.BuildingNumber = dr["buildingnumber"] != DBNull.Value ? Convert.ToInt32(dr["buildingnumber"]) : 0;
                room.RoomType = dr["roomtype"] != DBNull.Value ? dr["roomtype"].ToString() : string.Empty;
                room.FloorNumber = dr["floornumber"] != DBNull.Value ? Convert.ToInt32(dr["floornumber"]) : 0;

                rooms.Add(room);
            }
            return rooms;
        }
    }
}
