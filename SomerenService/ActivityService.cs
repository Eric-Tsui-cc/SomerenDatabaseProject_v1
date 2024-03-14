using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activityDao;

        public ActivityService()
        {
            activityDao = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = activityDao.GetAllActivities();
            return activities;
        }
    }
}
