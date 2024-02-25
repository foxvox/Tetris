using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	internal partial class Block
	{
		List<List<string[][]>> allBlock = new List<List<string[][]>>();

		public void DataInit()
		{
			for (int BT = 0; BT < (int)BLOCKTYPE.BT_MAX; BT++) 
			{
				allBlock.Add(new List<string[][]>());
				for (int BD = 0; BD < (int)BLOCKDIR.BD_MAX; BD++)
				{
					allBlock[BT].Add(null);
				}
			}

			#region BT_I 
			allBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_N] = new string[][] 
			{
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_E] = new string[][]
			{
				new string[] { "□", "□", "□", "□" },
				new string[] { "■", "■", "■", "■" },				
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_S] = new string[][]
			{
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_W] = new string[][]
			{
				new string[] { "□", "□", "□", "□" },
				new string[] { "■", "■", "■", "■" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			#endregion

			#region BT_T 
			allBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_N] = new string[][]
			{
				new string[] { "□", "■", "□", "□" },
				new string[] { "■", "■", "■", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_E] = new string[][]
			{
				new string[] {  "■", "□", "□", "□" },
				new string[] {  "■", "■", "□", "□"  },
				new string[] {  "■", "□", "□", "□" },
				new string[] {  "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_S] = new string[][] 
			{
				new string[] { "□", "□", "□", "□" },
				new string[] { "■", "■", "■", "□" },
				new string[] { "□", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_W] = new string[][] 
			{
				new string[] { "□", "■", "□", "□" },
				new string[] { "■", "■", "□", "□"  },
				new string[] { "□", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			#endregion

			#region BT_L
			allBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_N] = new string[][]
			{
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_E] = new string[][]
			{
				new string[] { "□", "□", "□", "□" },
				new string[] { "■", "■", "■", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_S] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "■", "□", "□" },
				new string[] { "□", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_W] = new string[][]
			{
				new string[] { "□", "□", "■", "□" },
				new string[] { "■", "■", "■", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			#endregion

			#region BT_J
			allBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_N] = new string[][]
			{
				new string[] { "□", "■", "□", "□" },
				new string[] { "□", "■", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_E] = new string[][]
			{
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "■", "■", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_S] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_W] = new string[][]
			{
				new string[] { "□", "□", "□", "□" },
				new string[] { "■", "■", "■", "□" },
				new string[] { "□", "□", "■", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			#endregion

			#region BT_S
			allBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_N] = new string[][]
			{
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_E] = new string[][]
			{
				new string[] { "□", "■", "■", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_S] = new string[][]
			{
				new string[] { "■", "□", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_W] = new string[][]
			{
				new string[] { "□", "■", "■", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			#endregion

			#region BT_Z
			allBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_N] = new string[][]
			{
				new string[] { "□", "■", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_E] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "■", "■", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_S] = new string[][]
			{
				new string[] { "□", "■", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "■", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_W] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "■", "■", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			#endregion

			#region BT_O
			allBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_N] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_E] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_S] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			allBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_W] = new string[][]
			{
				new string[] { "■", "■", "□", "□" },
				new string[] { "■", "■", "□", "□" },
				new string[] { "□", "□", "□", "□" },
				new string[] { "□", "□", "□", "□" }
			};
			#endregion

		} // public void DataInit()
	} // internal partial class Block
}
