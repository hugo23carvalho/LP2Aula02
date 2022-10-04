using System;

namespace ClassVsStruct
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Player pl = new Player{} (p1.Health = 60, p1.Armor = 40); //Ponto 2 do exercicio
            Player pl = new Player{} (p2.Health = 100, p2.Armor = 100); 

            Console.WriteLine($"Player 1 -> Health = {p1.Health}, {p1.Armor}");
            Console.WriteLine($"Player 2 -> Health = {p2.Health}, {p2.Armor}");
        }
    }
}
