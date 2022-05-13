using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        Student GetStudentDataByUser(UserLogin.User user)
        {
            Student student = new Student();
            if (user.facNum == null || !user.facNum.Equals(user.facNum))
            {
                Console.WriteLine("No such student with this fac number!");
                return null;
            }
            return (from s in StudentData.TestStudents where s.facNum == user.facNum select s).First();
        }
    }
}
