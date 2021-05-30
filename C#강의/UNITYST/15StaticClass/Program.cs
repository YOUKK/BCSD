using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static 3종류
// 정적 클래스
// 정적 멤버함수
// 정적 멤버변수

// 정적 클래스란
// 정적 멤버변수와 정적 멤버함수만을 가질 수 있는 클래스이다.
static class StaticClass
{
    int TEST = 100; // 오류
}
class Player
{
    // 메인 함수의 위치는 문법적으로 어디에 있건 상관없다.
    static void Main(string[] args)
    {
        Console.WriteLine("ㅇㅇㅇ");
    }
}

namespace _15StaticClass
{
    class Program
    {
       
    }
}
