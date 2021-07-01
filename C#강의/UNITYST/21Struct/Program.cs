using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ctrl + Shift + U : 대문자로 변경
struct StructData
{
	// 클래스와 비슷한데 안 되는 것이 있다.
	// 1. = 0 이런 거 안 된다.(리터럴 초기화)
	// 2. 메모리가 값형으로 취급됨.

	public int a;
	public int b;

	public void Func()
	{
		// 이런식으로 초기화 가능
		a = 100;
		b = 100;
	}
}

namespace _21Struct
{
	class Program
	{
		static void Test(StructData _Data)
		{
			_Data.a = 1000;
		}
		static void Main(string[] args)
		{
			StructData NewData = new StructData();

			// 참조형과 값형이 있다.
			// 클래스를 객체화하면 그건 참조형
			// 구조체는 값형

			NewData.a = 10;
			NewData.b = 10;

			// 이걸로 값이 바뀌진 않는다. 구조체는 값형이라...
			Test(NewData);
		}
	}
}
