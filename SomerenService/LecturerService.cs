using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDao teacherdb;

        public LecturerService()
        {
            teacherdb = new LecturerDao();
        }

        public List<Lecturer> GetLecturers()
        {
            List<Lecturer> Lecturers = teacherdb.GetAllLecturers();
            return Lecturers;
        }
        public void AddLecturer(Lecturer lecturer)
        {
            teacherdb.AddLecturer(lecturer);
        }
        public void UpdateLecturer(Lecturer lecturer)
        {
            teacherdb.UpdateLecturer(lecturer);

        }
        public void DeleteStudent(Lecturer lecturer)
        {
            teacherdb.DeleteLecturer(lecturer);

        }
        public Lecturer GetByLecturerID(int lecturerID)
        {
            Lecturer lecturer = teacherdb.GetByLecturerID(lecturerID);
            return lecturer;
        }
    }
}
