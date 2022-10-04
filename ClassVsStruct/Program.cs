using System;

namespace ClassVsStruct
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Player p1 = new Player{} (p1.Health = 60, p1.Armor = 40); //Ponto 2 do exercicio
            Player p2 = p1;

            DupHealth(ref p1);

            Console.WriteLine($"Player 1 -> Health = {p1.Health}, {p1.Armor}");
            Console.WriteLine($"Player 2 -> Health = {p2.Health}, {p2.Armor}");
        }

        private static void DupHealth (ref Player player) //ref altera os valores, anteriormente não pq player é struct (cópia) tipo de valor
        {

            player.Health *= 2;
        }
    }
}
