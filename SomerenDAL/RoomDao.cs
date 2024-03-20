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
            //string query = "select roomnumber, buildingnumber, roomtype, floornumber from room";
            //sqlparameter[] sqlparameters = new sqlparameter[0];
            //return readrooms(executeselectquery(query, sqlparameters));

            // Create a mock DataTable object
            DataTable mockDataTable = new DataTable();
            mockDataTable.Columns.Add("roomnumber", typeof(int));
            mockDataTable.Columns.Add("buildingnumber", typeof(int));
            mockDataTable.Columns.Add("roomtype", typeof(string));
            mockDataTable.Columns.Add("floornumber", typeof(int));

            // Add some mock data rows
            mockDataTable.Rows.Add(101, 1, "Single", 1);
            mockDataTable.Rows.Add(102, 1, "Double", 2);
            // Add more data rows to simulate real data

            // Call the ReadRooms method and return the result
            return ReadRooms(mockDataTable);
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
