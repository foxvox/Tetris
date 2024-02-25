using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	internal class Screen
	{
		protected List<List<string>> tile = new List<List<string>>();

		public int X
		{
			get
			{
				return tile[0].Count; 
			}
		}

		public int Y
		{
			get
			{
				return tile.Count;
			}
		}

		// Console.Clear()와 차이점은 cursor 위치를 reset 해주지는 못하고, tile 메모리 상태만 블록이 없는 상태로 reset 해준다.  	
		public void Clear()
		{
			for (int y = 0; y < tile.Count; y++)
			{
				for (int x = 0; x < tile[y].Count; x++)
				{					
					if (y == 0 || y == tile.Count - 1)
					{
						tile[y][x] = "▣";
						continue; 
					}

					tile[y][x] = "□"; 
				}
			}
		}

		public void SetTile(int _x, int _y, string _type)
		{
			tile[_y][_x] = _type;
		}

		public bool IsTile(int _x, int _y, string _type)
		{
			return tile[_y][_x] == _type; 
		}

		public void Render() 
		{
			for (int y = 0; y < tile.Count; y++)
			{
				for (int x = 0; x < tile[y].Count; x++)
				{
					Console.Write(tile[y][x]);
				}
				Console.WriteLine();
			}
			Task.Delay(300).Wait();
		}

		public Screen(int _x, int _y, bool _wall)
		{
			for (int y = 0; y < _y; y++)
			{
				tile.Add(new List<string>());
				for (int x = 0; x < _x; x++)
				{
					tile[y].Add("□");
				}
			}

			if (!_wall)
				return; 

			for (int i = 0; i < tile[0].Count; i++)
			{
				tile[0][i] = "▣";
			}

			for (int i = 0; i < tile[tile.Count - 1].Count; i++)
			{
				tile[tile.Count - 1][i] = "▣"; 
			}
		}
	} // internal class Screen 
} // namespace Tetris 
