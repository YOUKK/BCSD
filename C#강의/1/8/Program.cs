using System;

class Player
{
    private int AT;
    private int HP;
    private int LV = 1;

    public void SetHP(int _HP)
    {
        HP = _HP;
    }

    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }

    public int DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }

    public int GetLv()
    {
        return LV;
    }
}

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.SetHP(100);

            NewPlayer.Damage1(10);
            NewPlayer.Damage1(20);
            NewPlayer.Damage2(10, 20);
            Console.WriteLine(NewPlayer.DamageToHPReturn(10));

            Console.WriteLine(NewPlayer.GetLv());
        }
    }
}