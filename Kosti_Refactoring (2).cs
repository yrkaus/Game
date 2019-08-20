using System;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
        startGame:
            try
            {
                Console.WriteLine("\n Добро пожаловать в Игру Кости!\n");

            enterpleyer:
                Console.WriteLine("\n Введите количество игроков: \n");
                int geymers = Convert.ToInt32(Console.ReadLine());
                int geymers2 = geymers;
                if (geymers > 1)
                {
                    int i = geymers2;
                    //int s = 1;
                    //int x = 50;

                    for (int p = 1; p < i + 1; p++)
                    {
                    start:
                        Console.WriteLine("Введите имя огрока, и нажмите Enter:");
                        string name = Console.ReadLine();
                        if (name.Length > 0)
                        {
                            Console.WriteLine("\nУважаемый {0}! Вы успешно зарегистрированы\n", name);
                        }
                        else
                        {
                            Console.WriteLine("Вы не ввели имени");
                            goto start;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Минимальное количество Игроков 2");
                    goto enterpleyer;
                }
                Console.WriteLine("Бросаете кости? Если да, нажмите YES, если нет, нажмите NO");
                string yesno = Console.ReadLine();

            CoubeCust:
                if (yesno == "YES")
                {
                    int i = geymers2;
                    for (int p = 1; p < i + 1; p++)
                    {
                        Coube Cast = new Coube();
                        Cast.MethodCast();
                    }
                }
                else
                {
                    Console.WriteLine("\n Лучше выбирите YES\n");
                    string yes = Console.ReadLine();
                    if (yes == "YES")
                    {
                        goto CoubeCust;
                    }
                    else
                    {
                        Console.WriteLine("В этой игре надо бросать кубики!");
                        goto TheEnd;
                    }
                }
            TheEnd:
                Console.WriteLine("\n Спасибо за участие в Игре Кости \n");
            }
            catch
            {
                Console.WriteLine("\n Об этом мы не подумали. Пропробуйте еще! \n");
                goto startGame;
            }
        }
        public class Coube
        {
            string name = Console.ReadLine();
            public void MethodCast()
            {
                Console.WriteLine("{0} Бросайte кубики:", name);
                Random random = new Random();
                int coube = random.Next(1, 6);
                Console.WriteLine("Результат кубика 1: {0}", coube);

                Random random2 = new Random();
                int coube2 = random2.Next(1, 6);
                Console.WriteLine("Результат кубика 2: {0}", coube2);
                int summ = coube + coube2;
                Console.WriteLine("Сумма брошенных кубиков: {0}+{1} = {2}", coube, coube2, summ);
            }
        }
    }
}


//    }
//public class Geymer
//{
//    public void MethodGeymer()
//    {
//        Console.WriteLine("Введите имя огрока: ");
//        string name2 = Console.ReadLine();
//        if (name2.Length > 0)
//        {
//            Console.WriteLine("Вы успешно зарегистрированы");
//        }
//        else
//        {
//            Console.WriteLine("Повторите регистрацию");
//        }
//    }



//}



//    {
//        return;
//    }

//    while (geymers > 49)
//    {
//        Console.WriteLine("Извините, Максимальное количество игроков: 50!");
//    }
//}
//while (geymers > 1)
//{
//    Console.WriteLine("Извините, Минимальное количетсво игроков: 2!");
//}