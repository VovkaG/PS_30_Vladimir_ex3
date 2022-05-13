using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();
        static private ICollection<string> logFileLines;

        public static void LogActivity(string activity) {
            string activityLine = DateTime.Now + ";" + LoginValidation.currentUserUsername + ";" + LoginValidation.currentUserRole + ";" + activity;
            currentSessionActivities.Add(activityLine);
            string fileName = "test.txt";
            if (File.Exists(fileName)) {

                File.AppendAllText(fileName, activityLine + "\n");
            }
        }

        static public IEnumerable<string> GetCurrentSessionActivity(string filter)
        {
            List<string> filteredActivities = (from activity in currentSessionActivities where activity.Contains(filter) select activity).ToList();
            return filteredActivities;
        }

        static public IEnumerable<string> GetFileContent()
        {

            return logFileLines;
        }

    }
}
