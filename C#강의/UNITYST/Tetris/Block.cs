using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOCKDIR
{
    T,
    R,
    B,
    L,
}

enum BLOCKTYPE
{
    BT_I,
    BT_L,
    BT_J,
    BT_Z,
    BT_S,
    BT_T,
    BT_O,
}

 partial class Block
 {
    int X = 0;
    int Y = 0;
    List<List<string>> BlockData = new List<List<string>>();

    TETRISSCREEN Screen = null;

    public Block(TETRISSCREEN _Screen)
    {
        Screen = _Screen;

        for(int y = 0; y < 4; ++y)
        {
            BlockData.Add(new List<string>());
        }

    }

    private void Input()
    {
        if (false == Console.KeyAvailable)
        {
            return;
        }

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.S:
                Y += 1;
                break;
            default:
                break;
        }
    }
    public void Move()
    {
        
        Input();
        Screen.SetBlock(Y, X, "■");
    }
 }