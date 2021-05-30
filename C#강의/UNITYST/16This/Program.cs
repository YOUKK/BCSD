using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this
// 멤버함수에서 멤버변수를 쓴다면 눈에 보이지는 않지만 앞에 this.이 생략된 것이다.
// + static 멤버함수 안에서 일반 멤버변수를 사용하지 못 하는 이유 : 
// static 멤버함수는 객체를 만들지 않아도 쓸 수 있기 때문에 
// 멤버변수를 사용하면 멤버변수 앞에 this.이 없다.

class Player
{

    private int HP = 100;

    //public void Damage(int _Dmg)
    //{
    //    HP -= _Dmg;
    //}
    
    // 위 함수와 아래 함수의 기능은 같다.

    public static void Damage(Player _this, int _Dmg)
    {
        _this.HP -= _Dmg;
    }

    // 정적 멤버변수만을 정적 멤버함수에서 사용할 수 있다.
    private static int StaticTest = 100;

    //public static void PVP(Player _Left, Player _Right)
    //{
    //    // 객체에 영향을 받지 않는 것이
    //    // 정적 멤버함수, 정적 멤버변수
    //    HP = 1000; // 그렇게 때문에 이렇게 못 쓴다.

    //    StaticTest = 50; // 이게 가능
    //}
}

namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            Player.Damage(NewPlayer1, 100);

            // NewPlayer1.Damage(100);
        }
    }
}
