using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class SuperviseService
    {
        private SuperviseDao supervisedb;

        public SuperviseService()
        {
            supervisedb = new SuperviseDao();
        }
        public List<Lecturer> GetLecturersIdByActivity(Activity activity)
        {
            List<Lecturer> lecturers = supervisedb.GetLecturersIdByActivity(activity);
            return lecturers;
        }
        public Activity GetByName(string name)
        {
            return supervisedb.GetByName(name);
        }
        public Lecturer GetLecturerByid(int Id)
        {
            return supervisedb.GetLecturerByid(Id);
        }
        public void DeleteSupervisor(Lecturer lecturer,Activity activity)
        {
            supervisedb.DeleteSupervisor(lecturer,activity);
        }
        public void AddSupervisor(Lecturer lecturer, Activity activity)
        {
            supervisedb.AddSupervisor(lecturer, activity);
        }
    }
}
