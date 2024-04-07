using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class ParticipantsDao : BaseDao
    {

        public List<Participant> GetAllParticipants()
        {

            string query = "SELECT Studentnumber ,ActivityID FROM Participate";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Participant> ReadTables(DataTable dataTable)
        {
            List<Participant> participants = new List<Participant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participant participant = new Participant()
                {
                    Number = (int)dr["Studentnumber"],
                    ActivityID = (int)dr["ActivityID"],

                };
                participants.Add(participant);
            }
            return participants;
        }


        public void AddStudentToActivity(Participant participant)
        {
            string query = "INSERT INTO [Participate] (StudentNumber,ActivityID) VALUES (@STUDENT_ID, @ACTIVITY_ID);";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int) { Value = participant.Number };
            sqlParameters[1] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = participant.ActivityID };

            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveStudentFromActivity(Participant participant)
        {
            string query = "DELETE FROM [Participate] WHERE StudentNumber = @STUDENT_ID AND ActivityID = @ACTIVITY_ID;";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int) { Value = participant.Number };
            sqlParameters[1] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = participant.ActivityID };

            ExecuteEditQuery(query, sqlParameters);
        }


    }
}
