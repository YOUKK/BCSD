using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 100;

			// switch는 ==연산만 가능
			switch (a)
			{
				case 0:
					Console.WriteLine("a는 0이다");
					break;
				case 1:
					Console.WriteLine("a는 1이다");
					break;
				case 100:
					Console.WriteLine("a는 100이다");
					break;
				default: // else의 역할을 한다.
					Console.WriteLine("모든 조건이 맞지 않는다.");
					break;
			}

			int Left = 10;
			int Right = 20;

			switch (Left==Right)
			{
				case true:
					Console.WriteLine("true");
					break;
				case false:
					Console.WriteLine("false");
					break;
				default:
					break;
			}
		}
	}
}
