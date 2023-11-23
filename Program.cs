using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// 1
            // Изчисление на математически операции на правоъгълник

            Console.WriteLine("Въведете стойност на а дължина на правоъгълника: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете стойност на b височина на правоъгълника: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Изберете математическа операция с номериран отговор: ");
            Console.WriteLine("Лице: 1");
            Console.WriteLine("Обиколка: 2");

            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Изчисляване на резултата според избраната операция. ");
            if (operation == 1)
            {
                int result = (a * b);
                Console.WriteLine($"Лицето на правоъгълник със страни а и b е: {result}.");
            }

            else if (operation == 2)
            {
                int result = (2 * a) + (2 * b);
                Console.WriteLine($"Обиколката на правоъгълник със страни а и b е: {result}.");
            }


            ///// 2
            // Изчисляване на дискриминанта на квадратно уравнение

            Console.WriteLine("Въведете стойност на a, b и c на крадратното уравнение: ");

            int first_num_a = int.Parse(Console.ReadLine());
            int first_num_b = int.Parse(Console.ReadLine());
            int first_num_c = int.Parse(Console.ReadLine());

            Console.WriteLine("Изчисляване на дискриминанта D.");

            int D = ((first_num_b * first_num_b) - (4 * first_num_a * first_num_c));

            Console.WriteLine("Проверка дали квадратното уравнение има корени.");

            if (D > 0)
            {
                Console.WriteLine("Квадратното уравнение има 2 различни корена.");
            }

            else if (D == 0)
            {
                Console.WriteLine("Квадратното уравнение има 2 едни и същи корена.");
            }

            else if (D < 0)
            {
                Console.WriteLine("Квадратното уравнение няма корени.");
            }


        }
    }
}
