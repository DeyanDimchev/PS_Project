using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
       public Student GetStudentDataByUser(User user) { 
            foreach(Student student in StudentData.TestStudents) {
                if (student.facultyNum == user.fac_no)
                    return student;
            }
            return null;
        }
    }
}
