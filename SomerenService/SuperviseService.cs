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
        public Lecturer GetLectureName(string name)
        {
            Lecturer lecturer = supervisedb.GetLecturerNameById(name);
            return lecturer;
        }
    }
}
