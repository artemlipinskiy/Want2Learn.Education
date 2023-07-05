using System;

namespace Want2Learn.ClassStructEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "ALipinskiy";
            string password = "Qwerty1234";
            int age = 26;

            string login2 = "VAkseniko";
            string password2 = "Qwerty1wasd4";
            int age2 = 27;

            User user1 = new User();
            user1.age = 26;
            user1.login = "ALipinskiy";
            user1.password = "Qwerty1234";

            User user2 = new User();
            user2.age = 27;
            user2.login = "VAkseniko";
            user2.password = "Qwerty1wasd4";

            Console.WriteLine($"{user1.login} {user1.password} {user1.age}");
            //Так выводить объекты в консоль нельзя
            Console.WriteLine(user2);
            Console.WriteLine($"{user2.login} {user2.password} {user2.age}");

            Point3D point1 = new Point3D();
            point1.positionX = 2;
            point1.positionY = 4;
            point1.positionZ = 5;
            Console.WriteLine(point1);
            Console.WriteLine($"X = {point1.positionX} Y = {point1.positionY} Z = {point1.positionZ}");


            Point3D point2 = new Point3D();
            point2.positionX = 12;
            point2.positionY = 14;
            point2.positionZ = 15;
            Console.WriteLine($"X = {point2.positionX} Y = {point2.positionY} Z = {point2.positionZ}");

            //Ссылочное присваивание
            user1 = user2;
            user2.login = "YVoitkova";
            Console.WriteLine(user1.login);
            Console.WriteLine(user2.login);

            //Значимое
            point1 = point2;
            point2.positionX = 666;
            Console.WriteLine(point1.positionX);
            Console.WriteLine(point2.positionX);

            //user1 = null;

            User user3 = new User();
            Console.WriteLine(user3.login);
            Console.WriteLine(user3.password);
            Console.WriteLine(user3.age);

            if (user1.age > user2.age)
            {
                Console.WriteLine("User1 старше");
            }

            Size size1 = Size.M;
            if (size1 == Size.S)
            {
                Console.WriteLine("Size: small");
            }
            Console.WriteLine(size1);
            Console.WriteLine((int)size1);

            Size size2 = (Size)3;
            Console.WriteLine(size2);

            User user4 = new User();
            Console.WriteLine($"{user4.login} {user4.password} {user4.age}");
            string loginU5 = "KrotovAD"; 
            User user5 = new User(loginU5);
            Console.WriteLine($"{user5.login} {user5.password} {user5.age}");

            User user6 = new User("Login", "Password6", 23);
            Console.WriteLine($"{user6.login} {user6.password} {user6.age}");

        }
    }

}
