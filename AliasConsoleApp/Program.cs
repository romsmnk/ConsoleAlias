using System;
using AliasLibrary;

namespace AliasConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество команд/учасников: ");
            Game<Team> game = new Game<Team>(Convert.ToInt32(Console.ReadLine()));
            game.WordsDownloader();
                        
            int counter = 0;
            int teamCounter = 0;

            foreach (var word in game.words)
            {
                if (counter >= Game<Team>.qtyWordsByTeam)
                {
                    // Переход на следующую команду
                    counter = 0;
                    teamCounter++;
                    if (teamCounter >= game.teams.Length)
                        break;
                    Console.WriteLine("А сейчас время для следующей команды!!!");
                }
                counter++;
                Console.WriteLine($"Слово №{counter}: {word.Value}");

                // запись балов на команду
                Console.WriteLine("Отгадано правильно? Да/Нет");
                if (Console.ReadLine().ToLower() == "да")
                    game.teams[teamCounter].AddPoit();
                else
                    game.teams[teamCounter].WithdrawPoint();
            }
            Console.WriteLine("Игра окончена");
            Console.WriteLine("Счет команд:");
            for (int i = 0; i < game.teams.Length; i++)
            {
                Console.WriteLine(game.teams[i].Scour);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
