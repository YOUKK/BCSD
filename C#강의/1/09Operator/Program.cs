using System;

class Player
{
    public int Plus(int _Left, int _Right)
    {
        return _Left + _Right;
    }
}

namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            int Result = 0;
            int Left = 7;
            int Right = 3;

            Result = NewPlayer.Plus(Left, Right);
            Result = Left + Right;
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right;
            Result = Left % Right;

            Console.WriteLine(NewPlayer.Plus(10, 20));

            bool BResult = true;
            BResult = false;

            BResult = Left > Right;
            BResult = Left < Right;
            BResult = Left >= Right;
            BResult = Left <= Right;
            BResult = Left == Right;
            BResult = Left != Right;

            // bool 논리 연산자
            BResult = !true;
            BResult = !false;

            BResult = true && false; //AND
            BResult = true && true && false; 
            BResult = true || false; // OR
            BResult = true || false || false;
            BResult = true ^ false; // XOR

            // 축약 연산자
            Result = 0;
            Result += 10;
            Result /= 10;
            Result *= 10;
        }
    }
}