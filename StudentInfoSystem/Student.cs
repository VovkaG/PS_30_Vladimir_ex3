using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string faculty { get; set; }
        public string speciality { get; set; }
        public string degree { get; set; }
        public string status { get; set; }
        public string facNum{ get; set; }
        public int course { get; set; }
        public int stream { get; set; }
        public int group { get; set; }

        public Student() { }
        public Student(string firstName, string middleName, string lastName, string faculty, string speciality, string degree, string status, string facultyNumber, int course, int stream, int group)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.faculty = faculty;
            this.speciality = speciality;
            this.degree = degree;
            this.status = status;
            this.facNum = facultyNumber;
            this.course = course;
            this.stream = stream;
            this.group = group;
        }
    }
}
