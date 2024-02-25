using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Tetris
{
	internal partial class Block
	{
		int x;
		int y;

		BLOCKDIR blockDir = BLOCKDIR.BD_N; 
		BLOCKTYPE blockType = BLOCKTYPE.BT_T;

		// arr means blockData arry 
		string[][] arr = null; 

		Random rand = new Random();

		// screen 또한 레퍼런스형이란 것을 알 수 있다. 
		Screen screen = null;
		AccScr accScr = null;

		public void SetBlock(BLOCKTYPE _type, BLOCKDIR _dir)
		{
			arr = allBlock[(int)_type][(int)_dir];
		}

		public void SetAccScr()
		{
			for (int j = 0; j < 4; j++)
			{
				for (int i = 0; i < 4; i++)
				{
					if (arr[j][i] == "■")
					{
						accScr.SetTile(x + i, y + j - 1, "■");
					}						
				}
			}
		}

		public int GetWidth()
		{
			int width = 0;			

			for (int j = 0; j < 4; j++)
			{
				int tempWidth = 0;
				for (int i = 0; i < 4; i++)
				{
					if (arr[j][i] == "■")
					{
						tempWidth++;						
					}
				}

				if (tempWidth > width)
				{
					width = tempWidth; 
				}				 
			}
			return width; 
		}

		public int GetHeight()
		{
			int height = 0;

			for (int i = 0; i < 4; i++)
			{
				int tempHeight = 0;
				for (int j = 0; j < 4; j++)
				{
					if (arr[j][i] == "■")
					{
						tempHeight++;
					}
				}

				if (tempHeight > height)
				{
					height = tempHeight;
				}
			}
			return height;
		}

		public int GetMaxSpan()
		{
			int maxSpan;
			int height;
			int width;

			height = GetHeight();
			width = GetWidth();

			maxSpan = height > width ? height : width;

			return maxSpan; 
		}

		public bool CheckRotatable()
		{
			bool check = false;

			int maxSpan = GetMaxSpan(); 

			if (x + maxSpan < screen.X)
			{ check = true; }	

			return check; 
		}

		// 블록을 그리려면 screen 인스턴스가 필요하다. SetBlock, Render 맴버함수 사용해야 함.  
		public Block(Screen _screen, AccScr _accScr) 
		{
			if (_screen == null || _accScr == null) 
				return;			

			x = 4;
			y = 1;
			
			arr = null;
			blockDir = BLOCKDIR.BD_N;
			blockType = BLOCKTYPE.BT_T;
			
			screen = _screen;
			accScr = _accScr;
			
			DataInit();

			Reset();
		}

		public void RandomBlock()
		{			
			blockType = (BLOCKTYPE)rand.Next((int)BLOCKTYPE.BT_I, (int)BLOCKTYPE.BT_MAX); 
			//blockType = BLOCKTYPE.BT_I;
		}

		public void Reset()
		{
			RandomBlock(); 
			x = 4; 
			y = 1;	
			SetBlock(blockType, blockDir);
		}

		public bool CheckDown() 
		{
			for (int j = 0; j < 4; j++)
			{
				for (int i = 0; i < 4; i++)
				{
					if (arr[j][i] == "■")
					{
						if (accScr.Y == y + j || accScr.IsTile(x + i, y + j, "■")) 
						{
							SetAccScr();
							Reset(); 
							return false;
						}
					}
				}
			}

			return true;
		}

		public void Down()
		{
			if (CheckDown() == false)
			{				
				return; 
			}				

			y++;
		} 

		public void Input() 
		{
			// Key가 눌리지 않았으면 return해라. 
			if (!Console.KeyAvailable)
				return;

			//ReadKey 인자로 true를 넣어주면 콘솔창에 누른키를 표시하지 않는다. 
			switch (Console.ReadKey(true).Key)
			{
				case ConsoleKey.A:
					if (x > 0)
						x--; 
					break;
				case ConsoleKey.D:
					int width = GetWidth(); 
					if (x + width < screen.X) 
						x++;
					break;
				case ConsoleKey.S:
					while (CheckDown() == true)
					{
						Down();
					}					
					break;
				case ConsoleKey.Q:	
					if (CheckRotatable() == true)
					{
						blockDir--;
						if (blockDir < 0)
							blockDir = BLOCKDIR.BD_W;
						SetBlock(blockType, blockDir);
					}					
					break; 
				case ConsoleKey.E:
					if (CheckRotatable() == true)
					{
						blockDir++;
						if (blockDir == BLOCKDIR.BD_MAX)
							blockDir = BLOCKDIR.BD_N;
						SetBlock(blockType, blockDir);
					}
					break; 
				case ConsoleKey.W:
					if (CheckRotatable() == true)
					{
						blockDir++;
						if (blockDir == BLOCKDIR.BD_MAX)
							blockDir = BLOCKDIR.BD_N;
						SetBlock(blockType, blockDir);
					}
					break;
				default:
					break;
			}
		}

		public void Move()
		{
			// 기본 움직임
			Down(); 

			Input();		

			// input 값을 적용하고 변경된 위치와 방향을 적용한 블록을 타일에 다시 세팅한다. 
			for (int j = 0; j < 4; j++)
			{
				for (int i = 0; i < 4; i++)
				{
					if (arr[j][i] == "□")
						continue; 

					screen.SetTile(x + i, y + j, arr[j][i]);
				}
			}
		} // public void Move()	

	} // internal partial class Block
}
