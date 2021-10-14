using System;
using System.Collections.Generic;

namespace oop_lesson5_eightball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Eight Ball ###\n");

            var answerList = new List<string>();

            answerList.Add("It is certain");
            answerList.Add("It is decidedly so");
            answerList.Add("Withou a doubt");
            answerList.Add("Yes definitely");
            answerList.Add("You might rely on it");
            answerList.Add("As I see it, yes");
            answerList.Add("Most likely");
            answerList.Add("Outlook good");
            answerList.Add("Yes");
            answerList.Add("Signs point to yes");
            answerList.Add("Reply hazy, try again");
            answerList.Add("Ask again later");
            answerList.Add("Better not tell you now");
            answerList.Add("Cannot predict now");
            answerList.Add("Concentrate and ask again");
            answerList.Add("Don't count on it");
            answerList.Add("My reply is no");
            answerList.Add("My sources say no");
            answerList.Add("Outlook not so good");
            answerList.Add("Very doubtful");

            var random = new Random();

            while (true)
            {

                Console.WriteLine("\n--- Ask the Magic Eight Ball a question ---\n");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                //Random number from 0 to 19 -> total number of answer = 20
                var answerNumber = (random.Next(0, 19));
                Console.WriteLine(answerList[answerNumber]);


            }
        }
    }
}
