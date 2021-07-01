using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 while + tab + tab
 for + tab + tab
*/

namespace _17While
{
	class Program
	{
		static void Main(string[] args)
		{
			bool Check  = true;
			while (Check)
			{
				Console.WriteLine("while");
				Check = false;
			}

			do
			{
				Console.WriteLine("do while");
			} while (Check);

			int Count = 0;
			while (Count < 10)
			{
				Count++;
				Console.WriteLine(Count);
			}

			Count = 0;
			do
			{
				Count++;
				Console.WriteLine(Count);
			} while (Count < 10);
		}
	}
}
