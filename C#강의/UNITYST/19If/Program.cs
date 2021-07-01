using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// if는 조건문
// Ctrl + R + R 누르면 이름 바꾸기 할 수 있다

namespace _19If
{
	class Program
	{
		static void Main(string[] args)
		{
			int Test = 100;

			if(Test == 100)
			{
				Console.WriteLine("Test는 100이다.");
			}

			int ElseIfTest = 10;

			if(ElseIfTest == 100)
			{
				Console.WriteLine("ElseIfTest는 100이다");
			}
			else if(ElseIfTest == 10)
			{
				// 위의 조건이 false일 때 아래조건으로 들어온다.
				Console.WriteLine("ElseIfTest는 10이다");
			}

			int ElseTest = 5;

			if(ElseTest == 10)
			{
				Console.WriteLine("ElseTest는 10이다");
			}
			else if(ElseTest == 100)
			{
				Console.WriteLine("ElseTest는 100이다");
			}
			else
			{
				Console.WriteLine("연계된 모든 조건이 거짓이다.");
			}
		}
	}
}
