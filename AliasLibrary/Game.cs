using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace AliasLibrary
{
    public class Game<T> where T : Team
    {
        public const int qtyWordsByTeam = 8;
        // Масив команд
        public T[] teams;
        // Розмерность масива команд
        // int QuantityOfTeams = 0;
        public Dictionary<int, string> words = new Dictionary<int, string>();

        public Game(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                if (teams == null)
                    teams = new T[quantity];

                teams[i] =  new Team() as T;
            }
        }

        public void WordsDownloader()
        {
            // Загрузка json файла со словами
            var Data = System.IO.File.ReadAllText(@"C:\Users\Heathcliff\source\repos\AliasConsoleApp\AliasLibrary\words.json");
            words = JsonConvert.DeserializeObject<Dictionary<int, string>>(Data);
        }


    }
}
