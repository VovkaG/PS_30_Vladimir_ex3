using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {

        private string username;
        private string password;
        private string error;

        public static UserRoles currentUserRole { get; private set; }

        public static string currentUserUsername { get; private set; }
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError onError;

        public LoginValidation(string username, string password, ActionOnError onError) {
            this.username = username;
            this.password = password;
            this.onError = new ActionOnError(onError);
        }

        public Boolean validateUserInput(ref User user1) {

            Boolean emptyUsername;
            emptyUsername = username.Equals(String.Empty);
            if (emptyUsername) {
                error = "Username not specified";
                onError(error);
                return false;
            }

            Boolean shortUsername;
            shortUsername = username.Length < 5;
            if (shortUsername) {
                error = "Username too short";
                onError(error);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            Boolean emptyPassword;
            emptyPassword = password.Equals(String.Empty);
            if (emptyPassword)
            {
                error = "Password not specified";
                onError(error);
                return false;
            }

            Boolean shortPassword;
            shortPassword = password.Length < 5;
            if (shortPassword)
            {
                error = "Password too short";
                onError(error);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            user1 = UserData.IsUserPassCorrect(username, password);
            if (user1 != null)
            {
                currentUserRole = (UserRoles)user1.role;
                currentUserUsername = username;
                Logger.LogActivity("Successful Login");
                return true;
            }
            else
            {
                error = "Not such user found!";
                onError(error);
                currentUserUsername = null;
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
        }

        
    }
}
