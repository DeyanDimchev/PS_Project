using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        private string username;        
        private string password;
        public string name;
        public string secondName;
        public string lastName;
        public string faculty;
        public string field;
        public string qualification;
        public string status;
        public string facultyNum;
        public int year;
        public int stream;
        public int group;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public Student() { }
        
        public Student(string name, string secondName, 
            string lastName, string faculty, string field,
            string qualification, string status, string facultyNum,
            int year, int stream, int group)
        {
            this.name = name;
            this.secondName = secondName;
            this.lastName = lastName;
            this.faculty = faculty;
            this.field = field;
            this.qualification = qualification;
            this.status = status;
            this.facultyNum = facultyNum;
            this.year = year;
            this.stream = stream;
            this.group = group;
        }


    }
}
