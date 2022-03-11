using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    static class StudentData
    {
    
        static private List<Student> _testStudents = new();
        static public List<Student> TestStudents
        {
            get
            {
                if (!_testStudents.Any())
                {
                    Student student = new Student("Deyan", "Dimitrov", "Dimchev",
                        "FKST", "ITI", "Bachelor's", "active", "501219028", 4, 9, 36);
                    _testStudents.Add(student);
                }
                return _testStudents;
            }

            set
            {
                if (!_testStudents.Any())
                {
                    Student student = new Student("Deyan", "Dimitrov", "Dimchev",
                        "FKST", "ITI", "Bachelor's", "active", "501219028", 4, 9, 36);
                    _testStudents.Add(student);
                }
            }
        }
    }
}
