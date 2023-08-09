using System;

namespace Want2Learn.StringsCharsDateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "New Test message";

            //строки - массив чаров
            for (int i = 0; i < message.Length; i++)
            {
                char temp = message[i];
                Console.WriteLine(temp);
            }

            //Массив массивов
            string[] messages = { "", "Hello, world", "Artem", "Test message" };
            for (int i = 0; i < messages.Length; i++)
            {
                Console.WriteLine(messages[i]);

                for (int j = 0; j < messages[i].Length; j++)
                {
                    Console.WriteLine(messages[i][j]);
                }
            }

            string checkedEmptyString = "";
            string checkedNullString = null;
            bool isNullOrEmpty = string.IsNullOrEmpty(checkedEmptyString);
            Console.WriteLine(isNullOrEmpty);
            isNullOrEmpty = string.IsNullOrEmpty(checkedNullString);
            Console.WriteLine(isNullOrEmpty);
            string notNullString = "qq";
            isNullOrEmpty = string.IsNullOrEmpty(notNullString);
            Console.WriteLine(isNullOrEmpty);

            if (string.IsNullOrEmpty("asqs"))
            {

            }
            string.IsNullOrWhiteSpace("   ");

            string firstName = "Artem";
            string lastName = "Lipinskii";
            string greetings = string.Format("Hello, {0} {1}", lastName, firstName);
            Console.WriteLine(greetings);

            string emptyString = string.Empty;

            string result = message.ToLower();
            Console.WriteLine(result);
            Console.WriteLine(message);
            message = message.ToUpper();
            Console.WriteLine(result);
            Console.WriteLine(message);

            char someChar = 'a';
            someChar = char.ToUpper(someChar);
            Console.WriteLine(someChar);

            //char.IsDigit(someChar) 
            //char.IsUpper(someChar);
            //char.IsWhiteSpace(someChar);
            //char.IsPunctuation(someChar);
            //char.IsLetter(someChar);

            string[] words = message.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            string newMessage = message.Replace("S","");
            Console.WriteLine(newMessage);

            bool hasCharA = message.Contains('A');
            Console.WriteLine(hasCharA);
            string subString = message.Substring(3);
            Console.WriteLine(subString);
            subString = message.Substring(4, 9);
            Console.WriteLine(subString);

            char[] charArray = { 'q', 'w', 'e', 's' };
            string strFromCharArray = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                strFromCharArray += charArray[i];
            }

            //Этот вариант лучше
            strFromCharArray = new string(charArray);

            char[] newCharArray = message.ToCharArray();
        }
    }
}
