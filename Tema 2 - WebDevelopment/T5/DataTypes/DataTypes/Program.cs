using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            String text = "This is a String";
            int age = 20;
            DateTime now = DateTime.Now;

            double amount = 0;

            String text2 = text + " a second String " + age + now + amount;

            String text3 = string.Format("The age is {0}, the time is {1}, and the amount is {2}", age, now, amount);

            String text4 = $"The age is {age}, the time is {now}, and the amount is {amount}";


            char sampleChar = 'C';
            char[] arrayChar = text4.ToCharArray();

            amount = (double)10 / (double)3;

            DateTime dateTime = new DateTime(2000, 1, 1);

            var timestamp1 = now - dateTime;

            Console.WriteLine(timestamp1.Days);

            string test = "15";

            string booleanValue = "True";

            bool isTrue = bool.Parse(booleanValue);

            age = int.Parse(test);

            Console.ReadKey();

        }
    }
}
