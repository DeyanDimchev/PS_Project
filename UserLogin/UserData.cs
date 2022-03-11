using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        static private List<User> _testUsers = new();

        static public List<User> TestUsers
        {
            get {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
       
        static private void ResetTestUserData()
        {
            if (!_testUsers.Any())
            {
                User testUser1 = new User();
                testUser1.username = "ddimchev";
                testUser1.password = "123456";
                testUser1.fac_no = "501219028";
                testUser1.role = 1;
                testUser1.created = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                testUser1.validUntil = new DateTime();
                testUser1.validUntil = DateTime.MaxValue;
                _testUsers.Add(testUser1);


                User testUser2 = new User();
                testUser2.username = "dgocov";
                testUser2.password = "654321";
                testUser2.fac_no = "501219029";
                testUser2.role = 4;
                testUser2.created = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                testUser2.validUntil = new DateTime();
                testUser2.validUntil = DateTime.MaxValue;
                _testUsers.Add(testUser2);

                User testUser3 = new User();
                testUser3.username = "divanov";
                testUser3.password = "123456avcs";
                testUser3.fac_no = "501219030";
                testUser3.role = 4;
                testUser3.created = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                testUser3.validUntil = new DateTime();
                testUser3.validUntil = DateTime.MaxValue;
                _testUsers.Add(testUser3);
            }
        }
        
        static public User isUserPassCorrect(string username,string password)
        {
            ResetTestUserData();
            User userToBeLogged = ((User)(from user in _testUsers where 
                         user.username == username 
                         && user.password == password 
                         select user));
            if (userToBeLogged != null)
                return userToBeLogged;
            return null;
        }

        static public void SetUserActiveTo(string username, DateTime validity)
        {
            foreach(User user in _testUsers)
            {
                if (user.username == username)
                {
                    user.validUntil = validity;
                    Logger.LogActivity("Changed validity of " + username);
                }
            }
        }

        static public void AssignUserRole(string username, UserRoles role)
        {
            foreach (User user in _testUsers)
            {
                if (user.username == username)
                {
                    user.role = (int)role;
                    Logger.LogActivity("Changed role of  " + username);
                }
            }
        }

        static public void displayUsers()
        {
            foreach(User u in _testUsers)
            {
                Console.WriteLine("\nusername: " + u.username);
                Console.WriteLine("fac.no.: " + u.fac_no);
                Console.Write("role: ");
                switch (u.role)
                {
                    case 0:
                        Console.WriteLine("anonymous");
                        break;
                    case 1:
                        Console.WriteLine("admin");
                        break;
                    case 2:
                        Console.WriteLine("inspector");
                        break;
                    case 3:
                        Console.WriteLine("professor");
                        break;
                    case 4:
                        Console.WriteLine("student");
                        break;
                }
            }
        }
    }
}
