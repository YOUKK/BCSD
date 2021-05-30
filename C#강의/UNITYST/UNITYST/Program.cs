using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Console.WriteLine
class Player
{
    int AT;
    int HP;

    public void Test(int _Dmg)
    {
        _Dmg = 1000;
    }
    /*
    public int Test(int _Dmg)
    {
        _Dmg = 1000;
        return _Dmg;
    }
     */
}

namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            int Value = 0;
            NewPlayer.Test(Value);
            Console.WriteLine(Value);
            // Value의 값이 1000이 아니라 0임을 알아야됨
            // _Dmg와 Value는 별개이다.

            /*
             * 이걸 값형의 처리라고 한다
            Value = NewPlayer.Test(Value);
            Console.WriteLine(Value);
            이렇게 해야 1000이 출력된다
            */
        }
    }
}