using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ParticipantService
    {
        private ParticipantsDao participantDb;
        public ParticipantService()
        {
            participantDb = new ParticipantsDao();
        }

        public List<Participant> GetParticipants()
        {
            List<Participant> participants = participantDb.GetAllParticipants();
            return participants;
        }

        public List<Participant> FilterParticipantsByActivity(int activityId)
        {
            List<Participant> participants = GetParticipants();

            participants.RemoveAll(participant => participant.ActivityID != activityId); // Use RemoveAll
            return participants;
        }

        public List<string> GetStudentsByParticipantId(List<Participant> participants, List<Student> students)
        {
            List<string> participantNames = new List<string>();
            List<int> participantIds = new List<int>();
            foreach (Participant participant in participants)
            {
                participantIds.Add(participant.Number);
            }


           foreach (Student student in students)
            {
                if (participantIds.Contains(student.Number))
                {
                    participantNames.Add(student.FullName);
                }
            }
            return participantNames;
        }
        public List<string> FilterParticipantsByParticipantNames(List<Participant> participants, List<Student> students)
        {
            List<string> nonParticipantNames = new List<string>();
            List<string> participantNames = new List<string>();
            participantNames = GetStudentsByParticipantId(participants, students);

            foreach (Student student in students)
            {
                nonParticipantNames.Add(student.FullName);
            }
            foreach (string name in participantNames)
            {
                if (nonParticipantNames.Contains(name))
                {
                    nonParticipantNames.Remove(name);
                } 
            }
            return nonParticipantNames;

        }

        public int GetParticipantNumberByName(string name, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FullName == name)
                {
                    return student.Number; 
                }
            }

            return -1; 
        }

        public void CreateNewParticipant(string selectedName, Activity selectedActivity, List<Student> students)
        {
            int participantId = GetParticipantNumberByName(selectedName, students);
            Participant participant = new Participant();
            if (participantId == -1)
            {
                throw new Exception("No Name found");
            }
            else
            {
                participant.Number = participantId;
                participant.ActivityID = selectedActivity.id;
            }
            try
            {
                participantDb.AddStudentToActivity(participant);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Participant not added");

            }
        }
        public void RemoveParticipant(string selectedName, Activity selectedActivity, List<Student> students)
        {
            int participantId = GetParticipantNumberByName(selectedName, students);
            Participant participant = new Participant();
            if (participantId == -1)
            {
                throw new Exception("No Name found");
            }
            else
            {
                participant.Number = participantId;
                participant.ActivityID = selectedActivity.id;
            }
            try
            {
                participantDb.RemoveStudentFromActivity(participant);
            }
            catch (Exception ex)
            {
                throw new Exception("Participant not removed", ex);
            }
        }


    }
}
