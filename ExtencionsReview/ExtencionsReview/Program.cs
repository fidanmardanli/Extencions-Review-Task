using System;


namespace ExtencionsReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello!";
            string name = "Fidash";
            name.CheckDigit();
            var result = Extentions.CheckDigit(word);
            var result1 = word.CheckString(@"\d");
            var result2 = name.CheckString(@"[A-Z]");
            Console.WriteLine(result1);
            Console.WriteLine(name);

            Car car = new Car();
            Car.Speed = 600;

            Console.WriteLine(Car.ShowSpeed());

            Car car1 = new Car();
            Car car2 = new Car();

            Person person1 = new Person();
            Person person2 = new Person();


            int num1 = 15;
            int num2 = 25;
            int num3 = 35;

            Console.WriteLine(num1.SumNumber(25));

        }
    }
}