using System.Security.Cryptography;

namespace _3_Программы
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Введите желаемую задачу: \n 1. Игра 'Угадай число' \n 2. Таблица умножения \n 3. Вывод делителей чисел \n 4. Выход ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали угадай число");
                        v();
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали таблицу умножения");
                        t();
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали вывод делителей числа");
                        d();
                        break;
                
                        Console.WriteLine("Ошибка! Вы ввели неверный номер операции. \nПожалуйста введите номер операции заново!");
                        break;

                }

            } while (a != 4);
        }
        static void v()
        {
            Random ran = new Random();


            int value = ran.Next(0, 100);
            int i = value;
            int a;
            do
            {
                Console.WriteLine("Введите число");
                a = int.Parse(Console.ReadLine());
                if (i != a)
                {
                    if (i > a)
                    {
                        Console.WriteLine("Загаданное число больше");
                    }
                    if (i < a)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }
                }
                else
                {
                    Console.WriteLine("Отлично, вы нашли загаданное число");
                }
            }
            while (a != value);


        }
        static void t()
        {
            int[,] multitable = new int[9, 10];
            Console.WriteLine("Таблица умножения: ");
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    multitable[x, y] = (x + 1) * y;
                }
            }
            for (int x = 0; x < 9; x++)
            { 
                for (int y = 1; y < 10; y++)
                {
                    Console.Write(multitable[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void d()
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.Write($"{i} ");
                }

            }
            Console.WriteLine();
        }
    }
}
  