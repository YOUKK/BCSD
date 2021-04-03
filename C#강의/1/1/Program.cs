using System;

namespace _01Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.ATT = 300;
            NewPlayer.Fight();
        }
    }
}

class Player
{
    public int ATT = 0;
    int HP = 0;

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
}