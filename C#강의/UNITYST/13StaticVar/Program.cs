using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static

class Monster
{
    // 클래스에서 사용 가능하다.
    static int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount += 1;
    }
}

class Player
{
    // static을 붙인 걸 정적 멤버변수라 한다.
    // 정적 멤버변수는 객체화를 하지 않고도 사용할 수 있다.
    // 이 정적 멤버변수는 클래스 이름 만으로 사용할 수 있다.
    public static int PlayerCount = 0;

    public int AT = 10;
    public int HP = 100;
    
    
    public void Setting(int _AT, int _HP)
    {
        PlayerCount = 100;

        AT = _AT;
        HP = _HP;
    }
}

namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 플레이어를 3번 new하면 플레이어가 3개 생긴 것이다.
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;
            // 이런식으로 정적 멤버변수는 객체화를 전혀 하지 않고 사용할 수 있다.
            // 이런 정적 멤버변수는 데이터 영역에 들어가게 된다.
            // 근데 NewPlayer3.PlayerCount 이런식으로 쓸 수는 없다.
            // 그니까 객체들을 통해서 정적 멤버변수를 사용할 수 없다.
            // 근데 클래스 내부에서는 사용이 가능하다.

            // 어떤 클래스에서 공유하고 싶은 값
            // 만약 몬스터 클래스라면 현재 존재하는 모든 몬스터의 수
            // 객체를 아무리 만들어도 정적 멤버는 그 객체와의 관련성은
            // 객체 내부에서 사용할 수 있다 뿐이지 객체의 개수만큼 만들어지는 것은 아니다.
            // 즉 모든 객체가 공유하는 하나의 변수.

            // 이 멤버변수들은 각각 존재한다.
            NewPlayer1.HP = 1010000;
            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            // 모든 객체가 값을 공유할 필요가 있는 데이터를 정의하는데 사용한다.
            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();
        }
    }
}