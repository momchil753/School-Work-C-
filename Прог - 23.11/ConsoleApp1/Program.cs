using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            //2
            if (age >= 18)
            {
                Console.WriteLine($"Ти си пълнолетен. Имаш навършени 18 години.");
            }

            else
            {
                Console.WriteLine($"Ти си непълнолетен. Имаш навършени {age} години.");
            }

            int x = int.Parse(Console.ReadLine());

            //3
            while (x <= 10)
            {
                x += 1;
            }

            //4
            string[] colors = { "Green", "Blue", "Red" };

            //5
            colors[1] = "Yellow";

            //6
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            //7
            string[] five_els = new string[5];

            //8
            TextReturningFunction();

            //9
            HelloFunction("Momkata");

            //10
            SumNumbersFunction(2, 3);
        }

        public static void TextReturningFunction()
        {
            Console.WriteLine("Im am a function");
        }

        public static void HelloFunction(string name)
        {
            Console.WriteLine($"ZDR {name}");
        }

        public static int SumNumbersFunction(int num_1, int num_2)
        {
            int result = num_1 + num_2;
            return result;
        }
    }
}
