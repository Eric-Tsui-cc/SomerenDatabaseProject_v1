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

                room.RoomNumber = (int)dr["roomnumber"];
                room.BuildingNumber = (int)dr["buildingnumber"];
                room.RoomType = dr["roomtype"].ToString();
                room.FloorNumber = (int)dr["floornumber"];
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
