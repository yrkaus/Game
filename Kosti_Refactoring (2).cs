using System;
using System.Collections.Generic;
// создать класс, добавить таблицу, добавить игрока, вівести результат, сохранить результат.
// + придумать свою игру, придумати правила гри, напитсати блок схему, яка логіка, написати діаграму класів і варіанти використання програми, описати як користувач буде взаємодіяти з ціє грою. 


namespace Lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.MixCards();
            _ = new Gamer();            // Таблица игроков

            while (true)
            {
                Console.Write("Введите имя игрока: ");
                var name = Console.ReadLine();
                int cardSum = 0;

                if (name.Length == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(name);// добавить игрока
                    Console.WriteLine("Игрок успешно зарегестрирован!");
                    Console.WriteLine(name);
                }

                while (true)
                {
                    Console.WriteLine("Хочешь взять карту?\nЕсли да, то напиши Yes, если нет, то напиши No");

                    if (Console.ReadLine() == "Yes")
                    {
                        Card card = deck.GetCard();
                        cardSum += card.value;

                        if (cardSum > 21)
                        {
                            Console.WriteLine(cardSum);// Сохранить результат
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(cardSum);// Сохранить результат
                        break;
                    }
                }
            }
            int cardSum2 = 0;
            Console.WriteLine(Console.ReadLine(), "Получил баллов: ", cardSum2);// вывод результатов
        }
    }

    public class Gamer // Класс игрок
    {
        public string Name;
        public int cardSum;

        public Gamer()
        {
        }

        /*        public Gamer(int cardSum, string Name)
                {
                    this.cardSum = cardSum;
                    this.Name = Name;
                    Console.WriteLine(Name, cardSum);
        */
    }
}


public class Card
{
    public int value;
    public string name;
    public string suit;

    public Card(int value, string name, string suit)
    {
        this.value = value;
        this.name = name;
        this.suit = suit;
    }
}

public class Deck
{
    private string[] _suits = new string[] { "Bubna", "Chirva", "Crest", "Pika" };
    public List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();

        for (int j = 0; j < _suits.Length; j++)
        {
            for (int i = 2; i <= 10; i++)
            {
                Card card = new Card(i, i.ToString(), _suits[j]);
                cards.Add(card);
            }
        }
    }

    public Card GetCard()
    {
        Random random = new Random();
        int index = random.Next(0, cards.Count);
        return cards[index];
    }

    public void MixCards()
    {
        Random random = new Random();
        int length = random.Next();

        for (int i = 0; i < 100; i++)
        {
            random = new Random();
            int index1 = random.Next(0, cards.Count);
            random = new Random();
            int index2 = random.Next(0, cards.Count);

            Card temp = cards[index2];
            cards[index2] = cards[index1];
            cards[index1] = temp;
        }
    }
}

