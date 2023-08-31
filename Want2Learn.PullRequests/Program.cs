using System;

namespace Want2Learn.PullRequests
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetFullName("Lipinskii Artem Dmitrievich");
            DateTime dateTime = new DateTime(1996, 8, 21);
            person.SetBirthday(dateTime);

            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.GetBirthday());

            Console.WriteLine("Today: ");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine(DateTime.Now.AddDays(-1));
            Console.WriteLine();
        }
    }
}
