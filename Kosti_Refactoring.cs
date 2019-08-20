using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Coube p1 = new Coube();
            p1.Cast();
            Coube2 p2 = new Coube2();
            p2.Cast2();

            Console.WriteLine("Результат кубика 1: {0}", p1);

            Console.WriteLine("Добро пожаловать в Игру Кости!");

            while (true)
            {
                Console.WriteLine("Введите количество игроков: ");
                int namenumber = Console.Read();
                if (namenumber == 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите имя огрока: ");
                    var name = Console.ReadLine();

                    if (name.Length == 0)
                    {
                        Console.WriteLine("Вы успешно зарегистрированы");
                    }
                    else
                    {

                    }

                }


            }
        }


        public class Coube
        {
            public void Cast()
            {
                Random random = new Random();
                int coube = random.Next(1, 6);
                Console.WriteLine(coube);
            }
        }
        public class Coube2
        {
            public void Cast2()
            {
                Random random = new Random();
                int coube = random.Next(1, 6);
                Console.WriteLine(coube);
            }
        }
        public class Geymer
        {
            public string geymer;
        }
    }
}
