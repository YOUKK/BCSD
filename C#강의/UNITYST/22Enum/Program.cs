using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의자료형 중 하나
// class 참조형 사용자정의
// struct 값형 사용자정의
// enum 값형 사용자정의

// switch문과 쓰기 좋다.
enum ITEMTYPE
{
	EQUIP,
	POTION,
	QUEST,
	NONESELECT
}

class Item
{
	public ITEMTYPE ItemType = ITEMTYPE.NONESELECT;

	public void PotionTypeSetting()
	{
		ItemType = ITEMTYPE.POTION;
	}
}

namespace _22Enum
{
	class Program
	{
		static void Main(string[] args)
		{
			Item NewItem = new Item();
			// 포션을 만들고 싶으면 이렇게
			NewItem.ItemType = ITEMTYPE.POTION;
			// 포션 만들고 싶을 때 이렇게도 가능
			NewItem.PotionTypeSetting();

			// 값형이다. int라고 생각해도 된다. 

			Console.WriteLine(ITEMTYPE.POTION);
			Console.WriteLine((int)ITEMTYPE.POTION);

			ITEMTYPE Type = ITEMTYPE.POTION;

			switch (Type)
			{
				case ITEMTYPE.EQUIP:
					break;
				case ITEMTYPE.POTION:
					break;
				case ITEMTYPE.QUEST:
					break;
				case ITEMTYPE.NONESELECT:
					break;
				default:
					break;
			}
		}
	}
}
