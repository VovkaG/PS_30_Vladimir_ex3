using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string facNum { get; set; }

        public DateTime created { get; set; }
        public DateTime validUntil { get; set; }

        public UserRoles userRole { get; set; }

        public User(string username, string password, string facNum, DateTime created, DateTime validUntil, UserRoles userRole) { 

            this.username = username;
            this.password = password;
            this.facNum = facNum;
            this.created = created;
            this.validUntil = validUntil;
            this.userRole = userRole;            
        
        }

        public User() { }
    }
}
