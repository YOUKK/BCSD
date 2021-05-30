using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    // 객체화를 하지 않아도 플레이어의 내부는 내부이므로
    // 접근 제한 지정자의 영향을 받지 않는다.
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    //static public void PVE(Player _Left, Monster _Right)
    //{
    //    _Left.HP -= _Right.AT;
    //    _Right.HP -= _Left.AT;
    //}

    private int AT = 100;
    private int HP = 100;

    public void Damage(int _Damage)
    {
        HP -= 100;
    }

    public void Damage(Player _Other)
    {
        // 자기 자신의 레퍼런스는 자신이 내부에서 모두 public인 상태다.
        HP -= _Other.AT;
    }
}

//public class Monster
//{
//    static public void PVP(Player _Left, Player _Right)
//    {
//        // 다른 클래스의 private는 사용 못함.
//        _Left.HP -= _Right.AT;
//        _Right.HP -= _Left.AT;
//    }
//}

namespace _14StaticFunc
{
    class Program
    {
        // 이것도 클래스에 속한 정적 함수
        // 어떤 클래스에 존재하는 Main의 이름을 가진
        // 정적멤버함수에서부터 C# 프로그램은 시작한다.
        static void Main(string[] args)
        {
            // F12를 누르면 그 클래스로 타고 들어갈 수 있다.
            // WriteLine함수를 보면 Console이라는 객체를 만들지 않고
            // 클래스이름.함수이름 <- 이런식으로 사용하는 것에서
            // WriteLine함수도 정적멤버함수라는 것을 알 수 있다.
            Console.WriteLine("static 함수 배우고 있어요");

            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

            // 마찬가지로 그 클래스에 속하지만
            // 객체를 굳이 만들지 않고도 사용할 수 있는 함수를
            // 정적멤버함수라 한다.
            //Player.PVP(NewPlayer1, NewPlayer2);

            //NewPlayer1.Damage(100);
        }
    }
}