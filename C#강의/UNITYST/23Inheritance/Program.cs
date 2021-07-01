using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속이란 코드 재활용성을 향상시키기 위한 것

// 방법 : 공통되는 기능을 하는 멤버변수와 멤버함수를 걷어낸다.
// 새로운 클래스에 그 모든 멤버변수와 멤버함수를 넣는다.

// C#에서 클래스 상속은 오직 하나만 가능하다.

// private가 디폴트 / 자식한테까지 쓰게 하려면 protected

class FightUnit
{
	protected int AT = 10;
	protected int HP = 100;

	public void Damage(FightUnit _OtherUnit)
	{
		this.HP -= _OtherUnit.AT;
	}
}

class Player : FightUnit
{
	int Lv = 1;

	void Heal()
	{
		HP = 100;
	}
}

class Monster : FightUnit
{
	int Exp = 10;
}


namespace _23Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Player NewPlayer = new Player();
			Monster NewMonster = new Monster();


			// 플레이어의 부분을 모두 다 포기하겠다.
			// 업캐스팅
			// 자식이 부모형이 되는 것. 그러므로서 자식의 능력은 버린다.
			NewPlayer.Damage(NewMonster);
			NewMonster.Damage(NewPlayer);
		}
	}
}
