using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testUser = new List<User>();

        public static List<User> TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        public static User IsUserPassCorrect(string username, string password)
        {

          
            IEnumerable<User> users = (from user in TestUser
                                       where user.username.Equals(username) && user.password.Equals(user.password)
                                       select user).ToList();

            return users.FirstOrDefault();
        }

        public static void SetUserActiveTo(string username, DateTime dateValidTo) {

            foreach (var user in TestUser) {
                if (username.Equals(user.username)) { 
                    user.validUntil = dateValidTo;
                    Logger.LogActivity("Chnaged expiration date to: " + username);
                }
            }
            
        }

        public static void AssignUserRole(string username, UserRoles newRole) {
            foreach (var user in TestUser) {
                if (username.Equals(user.username)) {
                    user.userRole = newRole;
                    Logger.LogActivity("Changed role of " + username);
                }
            }
        }

        static public void ResetTestUserData() {
            if (_testUser.Count == 0) {

                _testUser.Add(new User());
                _testUser[0].username = "Vladimir";
                _testUser[0].password = "12345";
                _testUser[0].facNum = "121219005";
                _testUser[0].created = DateTime.Now;
                _testUser[0].validUntil = DateTime.MaxValue;
                _testUser[0].userRole = UserRoles.ADMIN;

                _testUser.Add(new User());
                _testUser[1] = new User();
                _testUser[1].username = "Kircho";
                _testUser[1].password = "Kircho";
                _testUser[1].facNum = "121219006";
                _testUser[1].created = DateTime.Now;
                _testUser[1].validUntil = DateTime.MaxValue;
                _testUser[1].userRole = UserRoles.STUDENT;

                _testUser.Add(new User());
                _testUser[2] = new User();
                _testUser[2].username = "Boiko";
                _testUser[2].password = "Boiko";
                _testUser[2].facNum = "121219007";
                _testUser[2].created = DateTime.Now;
                _testUser[2].validUntil = DateTime.MaxValue;
                _testUser[2].userRole = UserRoles.STUDENT;
            }
        }


        
    }

}
