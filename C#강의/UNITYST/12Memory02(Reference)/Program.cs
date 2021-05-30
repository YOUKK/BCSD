using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int AT = 10;
    public int HP = 100;

    public void ATT(Monster _Monster)
    {
        _Monster.HP -= AT;
    }
}
class Monster
{
    public int AT = 10;
    public int HP = 100;

    public void ATT(Player _Player)
    {
        _Player.HP -= AT;
    }
}

namespace _12Memory02_Reference_
{
    class Program
    {
        // 클래스가 객체화된 것은 레퍼런스 형이라 하고
        // int bool 같은 것은 값형이라고 한다
        // 이 값형과 레퍼런스형은 메모리의 위치와 사용법이 다르기 때문에
        // 다르게 동작한다.
        static void Main(string[] args)
        {
            // Monster NewMonster는 스택에 생기고 new Monster(실제 만들어진 몬스터)는 힙에 생긴다
            // 이 레퍼런스는 힙에 생성된 어떠한 메모리의 위치를 가리키는 값이다
            Monster NewMonster = new Monster();
            Player NewPlayer = new Player();

            // .의 의미 : 가리키고 있는 위치의 ATT를 사용하겠다
            // NewMonster.ATT는 스택에 만들어지고 실제 만들어진 Player를 가리킨다
            // (Player NewPlayer가 실제 만들어진 Player를 가리키듯이)
            // 그러므로 실제 만들어진 Player의 값이 변할 수 있다(11강의 value와 다르게)
            NewMonster.ATT(NewPlayer);
            NewPlayer.ATT(NewMonster);
        }
    }
}
// 메인함수에서 Player NewPlayer와 Monster NewMonster의 크기는 주소값의 크기
// 만약 힙에 실제 만들어진 Player의 위치가 50, 실제 만들어진 Monster의 위치가 60이면
// Player NewPlayer의 값 : 50, Monster NewMonster의 값 : 60
// (실제 만들어진 Player, 실제 만들어진 Monster의 크기는 8바이트 이상(int형 변수가 2개 있으니까))