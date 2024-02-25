using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	internal class AccScr : Screen
	{
		Screen pScreen;

		public AccScr(Screen _pScreen)
			: base(_pScreen.X, _pScreen.Y - 2, false)
		{
			pScreen = _pScreen;
		}

		public void SetAccTile()
		{
			for (int y = 0; y < tile.Count; y++)
			{
				for (int x = 0; x < tile[y].Count; x++)
				{
					//pScreen과 screen은 1칸 차이가 난다. 
					pScreen.SetTile(x, y + 1, tile[y][x]);
				}
			}
		}

		public void DestroyCheck()
		{
			for (int y = tile.Count - 1; y > 0; y--)
			{
				for (int x = 0; x < tile[y].Count; x++)
				{
					// 하나라도 빈칸이 있으면 
					bool isFull = false;
					if (tile[y][x] == "□")
					{
						break; 				
					}

					if (x == X - 1) 
						isFull = true;

					if (isFull == true)
					{
						List<string> newLine = new List<string>(); 
						
						for (int i = 0; i < X; i++)
						{
							newLine.Add("□"); 
						}
												 
						tile.RemoveAt(tile.Count - 1);
						tile.Insert(0, newLine);

						y = tile.Count - 1;
					}
				}
			}
		}  // public void DestroyCheck()

	} // internal class AccScr : Screen 
} // namespace Tetris
