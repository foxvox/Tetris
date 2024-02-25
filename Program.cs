using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks; 

internal enum BLOCKTYPE 
{
	BT_I, BT_T, BT_L, BT_J, BT_S, BT_Z, BT_O, BT_MAX
}

internal enum BLOCKDIR
{
	BD_N, BD_E, BD_S, BD_W, BD_MAX 
}

namespace Tetris
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Screen newScr = new Screen(10, 22, true);
			AccScr newAccScr = new AccScr(newScr);
			Block newBlock = new Block(newScr, newAccScr); 

			while (true) 
			{
				Console.Clear();				
				newAccScr.SetAccTile();
				newBlock.Move();
				newAccScr.DestroyCheck();
				newScr.Render();				
				newScr.Clear();																				
			}
		}
	}
}
