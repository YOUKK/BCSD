using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
	protected string Name = "None";
	protected int AT = 10;
	protected int HP = 50;
	protected int MAXHP = 100;

	//public void SetName(string _Name)
	//{
	//	Name = _Name;
	//}

	public void StatusRender()
	{
		Console.Write(Name);
		Console.WriteLine("--------------");
		Console.Write("공격력 : ");
		Console.WriteLine(AT);
		Console.Write("체력 : ");
		Console.Write(HP);
		Console.Write("/");
		Console.WriteLine(MAXHP);
		Console.WriteLine("--------------------");
	}
}

class Player : FightUnit
{
	

	public void PrintHP()
	{
		Console.WriteLine("");
		Console.Write("현재 플레이어의 HP는 ");
		Console.WriteLine(HP);
		Console.ReadKey();
	}

	public void MaxHeal()
	{
		if (HP >= MAXHP)
		{
			Console.WriteLine("");
			Console.WriteLine("체력이 모두 회복되어있어 회복할 필요가 없습니다.");
			Console.ReadKey();
		}
		else
		{
			this.HP = MAXHP;
			PrintHP();
		}
		return;
	}

	public Player()
	{
		Name = "플레이어";
	}
}

class Monster : FightUnit
{
	public Monster(string _Name)
	{
		Name = _Name;
	}
}

enum STARTSELECT
{
	SELECTTOWN,
	SELECTBATTLE,
	NONESELECT // 에러나 잘못된 선택일 경우
}

namespace TextRpg001
{
	class Program
	{
		static STARTSELECT StartSelect()
		{
			Console.Clear();
			Console.WriteLine("1. 마을");
			Console.WriteLine("2. 배틀");
			Console.WriteLine("어디로가시겠습니까?");

			ConsoleKeyInfo CKI = Console.ReadKey();

			Console.WriteLine("");

			switch (CKI.Key)
			{
				case ConsoleKey.D1:
					Console.WriteLine("마을로 이동합니다.");
					Console.ReadKey();
					return STARTSELECT.SELECTTOWN;
				case ConsoleKey.D2:
					Console.WriteLine("배틀을 시작합니다.");
					Console.ReadKey();
					return STARTSELECT.SELECTBATTLE;
				default:
					Console.WriteLine("잘못된 선택입니다.");
					Console.ReadKey();
					return STARTSELECT.NONESELECT;
			}
		}
		
		static void Town(Player _Player)
		{
			while (true)
			{
				Console.Clear();
				_Player.StatusRender();				
				Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
				Console.WriteLine("1. 체력을 회복한다.");
				Console.WriteLine("2. 무기를 강화한다.");
				Console.WriteLine("3. 마을을 나간다.");

				switch (Console.ReadKey().Key)
				{
					case ConsoleKey.D1:					
						_Player.MaxHeal();
						break;
					case ConsoleKey.D2:
						break;
					case ConsoleKey.D3:
						return;
				}
			}
		}

		static void Battle(Player _Player)
		{
			//Console.WriteLine("아직 개발 중");
			//Console.ReadKey();

			Monster NewMonster = new Monster("몬스터");

			while (true)
			{
				Console.Clear();
				_Player.StatusRender();
				NewMonster.StatusRender();
				Console.ReadKey();
			}
		}

		static void Main(string[] args)
		{
			Player NewPlayer = new Player();

			while (true)
			{
				// 객체화 하지 않고도 쓸 수 있는 함수
				// static 함수
				// 정적멤버변수
				// ReadKey() : 키를 입력해줄 때까지 기다려주는 함수
				//ConsoleKeyInfo KeyInfo = Console.ReadKey();
				//Console.WriteLine(KeyInfo.Key);

				STARTSELECT SelectCheck =  StartSelect();

				switch (SelectCheck)
				{
					case STARTSELECT.SELECTTOWN:
						Town(NewPlayer);
						break;
					case STARTSELECT.SELECTBATTLE:
						Battle(NewPlayer);
						break;
				}
			}
		}
	}
}
