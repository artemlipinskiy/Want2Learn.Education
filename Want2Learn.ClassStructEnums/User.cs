using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.ClassStructEnums
{
    class User
    {
        //поля
        public string login;
        public string password;
        public int age;

        //конструкторы
        public User()
        {
            login = "Default";
            password = "Default";
            age = 14;
        }

        public User(string newLogin)
        {
            login = newLogin;
            password = "Default";
            age = 14;
        }

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
            age = 14;
        }

        public User(string newLogin, string newPassword, int newAge)
        {
            login = newLogin;
            password = newPassword;
            age = newAge;
        }
    }
}
