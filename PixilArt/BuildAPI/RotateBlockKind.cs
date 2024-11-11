using DiggerPixelArt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAPI
{
    public static class RotateBlockKind
    {
		private static BlockKind DublXYZ(BlockKind K, int[] vs)
		{
			if (vs.Length == 4)
			{
				if ((int)K == vs[0] || (int)K == vs[1])
				{
					K = (BlockKind)vs[2];
				}
				else if ((int)K == vs[2] || (int)K == vs[3])
				{
					K = (BlockKind)vs[0];
				}
				return K;
			}
			if (vs.Length == 16)
			{
				if ((int)K == vs[0] || (int)K == vs[1] || (int)K == vs[2] || (int)K == vs[3])
				{
					K = (BlockKind)vs[4];
				}
				else if ((int)K == vs[4] || (int)K == vs[5] || (int)K == vs[6] || (int)K == vs[7])
				{
					return (BlockKind)vs[0];
				}
				if ((int)K == vs[8] || (int)K == vs[9] || (int)K == vs[10] || (int)K == vs[11])
				{
					K = (BlockKind)vs[12];
				}
				else if ((int)K == vs[12] || (int)K == vs[13] || (int)K == vs[14] || (int)K == vs[15])
				{
					K = (BlockKind)vs[8];
				}
				return K;
			}
			if (vs.Length != 8)
			{
				throw new ArgumentOutOfRangeException(string.Format("Error. BlockKind {0} vs.Length != 8", K));
			}
			if ((int)K == vs[0] || (int)K == vs[1] || (int)K == vs[2] || (int)K == vs[3])
			{
				K = (BlockKind)vs[4];
			}
			else if ((int)K == vs[4] || (int)K == vs[5] || (int)K == vs[6] || (int)K == vs[7])
			{
				K = (BlockKind)vs[0];
			}
			return K;
		}
		public static BlockKind RotateKind(this BlockKind K, bool x, bool y, bool z, bool w90, bool Q = false, bool W = false)
		{
			if (Q)
			{
				K = DublXYZ(K, new int[]
				{
			84,
			212,
			208,
			80,
			79,
			207,
			211,
			83
				});
				K = DublXYZ(K, new int[]
				{
			72,
			204,
			200,
			76,
			197,
			197,
			69,
			69
				});
				K = DublXYZ(K, new int[]
				{
			73,
			205,
			201,
			77,
			195,
			195,
			67,
			67
				});
				K = DublXYZ(K, new int[]
				{
			70,
			198,
			202,
			74,
			196,
			196,
			68,
			68
				});
				K = DublXYZ(K, new int[]
				{
			71,
			199,
			203,
			75,
			194,
			194,
			66,
			66
				});
				K = DublXYZ(K, new int[]
				{
			45,
			134,
			134,
			173,
			31,
			42,
			159,
			170
				});
				if (K == BlockKind.DiagonalNorth || K == BlockKind.DiagonalOnWallNorthTop || K == (BlockKind)172)
				{
					K = BlockKind.DiagonalOnWallNorthLeft;
				}
				else if (K == BlockKind.DiagonalOnWallNorthLeft || K == BlockKind.DiagonalOnWallEastRight || K == (BlockKind)162 || K == (BlockKind)171)
				{
					K = BlockKind.DiagonalNorth;
				}
				if (K == BlockKind.DiagonalSouth || K == BlockKind.DiagonalOnWallSouthTop || K == (BlockKind)168)
				{
					K = BlockKind.DiagonalOnWallEastLeft;
				}
				else if (K == BlockKind.DiagonalOnWallEastLeft || K == BlockKind.DiagonalOnWallSouthRight || K == (BlockKind)166 || K == (BlockKind)163)
				{
					K = BlockKind.DiagonalSouth;
				}
				if (K == (BlockKind)133 || K == (BlockKind)169 || K == BlockKind.DiagonalOnWallSouthBottom)
				{
					K = BlockKind.DiagonalOnWallSouthLeft;
				}
				else if (K == BlockKind.DiagonalOnWallSouthLeft || K == (BlockKind)130 || K == (BlockKind)158 || K == (BlockKind)167)
				{
					K = (BlockKind)133;
				}
				if (K == BlockKind.DiagonalEast || K == BlockKind.DiagonalOnWallWestTop || K == (BlockKind)160)
				{
					K = BlockKind.DiagonalOnWallEastBottom;
				}
				else if (K == BlockKind.DiagonalOnWallEastBottom || K == (BlockKind)165 || K == (BlockKind)131 || K == BlockKind.DiagonalOnWallWestRight)
				{
					K = BlockKind.DiagonalEast;
				}
				if (K == (BlockKind)148 || K == BlockKind.QuarterOnWallWest)
				{
					K = BlockKind.Quarter;
				}
				else if (K == BlockKind.Quarter)
				{
					K = BlockKind.QuarterOnWallWest;
				}
				if (K == (BlockKind)145 || K == BlockKind.QuarterOnWallEast)
				{
					K = (BlockKind)144;
				}
				else if (K == (BlockKind)144)
				{
					K = BlockKind.QuarterOnWallEast;
				}
				if (K == (BlockKind)141 || K == BlockKind.HalfWallWest)
				{
					K = BlockKind.Half;
				}
				else if (K == BlockKind.Half)
				{
					K = BlockKind.HalfWallWest;
				}
				if (K == (BlockKind)142 || K == BlockKind.HalfWallEast)
				{
					K = (BlockKind)129;
				}
				else if (K == (BlockKind)129)
				{
					K = BlockKind.HalfWallEast;
				}
				if (K == BlockKind.ThirdOnWallWest)
				{
					K = BlockKind.Third;
				}
				else if (K == BlockKind.Third)
				{
					K = BlockKind.ThirdOnWallWest;
				}
				if (K == BlockKind.ThirdOnWallEast)
				{
					K = (BlockKind)153;
				}
				else if (K == (BlockKind)153)
				{
					K = BlockKind.ThirdOnWallEast;
				}
			}
			if (w90)
			{
				if (K == BlockKind.DiagonalOnWallEastLeft || K == BlockKind.DiagonalOnWallSouthRight || K == (BlockKind)163 || K == (BlockKind)166)
				{
					K = BlockKind.DiagonalOnWallWestLeft;
				}
				else if (K == BlockKind.DiagonalOnWallWestLeft || K == BlockKind.DiagonalOnWallNorthRight || K == (BlockKind)159 || K == (BlockKind)170)
				{
					K = BlockKind.DiagonalOnWallEastLeft;
				}
				if (K == BlockKind.FenceOnWallSouthNorth)
				{
					K = BlockKind.FenceOnWallEastWest;
				}
				else if (K == BlockKind.FenceOnWallEastWest)
				{
					K = BlockKind.FenceOnWallSouthNorth;
				}
				if (K == (BlockKind)137)
				{
					K = (BlockKind)135;
				}
				else if (K == (BlockKind)135)
				{
					K = (BlockKind)137;
				}
				if (K == (BlockKind)138)
				{
					K = (BlockKind)136;
				}
				else if (K == (BlockKind)136)
				{
					K = (BlockKind)138;
				}
				if (K == BlockKind.DiagonalWest || K == (BlockKind)164 || K == BlockKind.DiagonalOnWallEastTop)
				{
					K = BlockKind.DiagonalNorth;
				}
				else if (K == BlockKind.DiagonalNorth || K == (BlockKind)172 || K == BlockKind.DiagonalOnWallNorthTop)
				{
					K = BlockKind.DiagonalWest;
				}
				if (K == BlockKind.DiagonalEast || K == (BlockKind)160 || K == BlockKind.DiagonalOnWallWestTop)
				{
					K = BlockKind.DiagonalSouth;
				}
				else if (K == BlockKind.DiagonalSouth || K == (BlockKind)168 || K == BlockKind.DiagonalOnWallSouthTop)
				{
					K = BlockKind.DiagonalEast;
				}
				if (K == BlockKind.DiagonalOnWallEastBottom || K == (BlockKind)131 || K == (BlockKind)165)
				{
					K = BlockKind.DiagonalOnWallNorthBottom;
				}
				else if (K == BlockKind.DiagonalOnWallNorthBottom || K == (BlockKind)134 || K == (BlockKind)173)
				{
					K = BlockKind.DiagonalOnWallEastBottom;
				}
				if (K == (BlockKind)161 || K == (BlockKind)132 || K == BlockKind.DiagonalOnWallWestBottom)
				{
					K = BlockKind.DiagonalOnWallSouthBottom;
				}
				else if (K == BlockKind.DiagonalOnWallSouthBottom || K == (BlockKind)133 || K == (BlockKind)169)
				{
					K = BlockKind.DiagonalOnWallWestBottom;
				}
				if (K == BlockKind.FenceEast || K == (BlockKind)195)
				{
					K = BlockKind.FenceNorth;
				}
				else if (K == BlockKind.FenceNorth || K == (BlockKind)196)
				{
					K = BlockKind.FenceEast;
				}
				if (K == (BlockKind)190)
				{
					K = (BlockKind)193;
				}
				else if (K == (BlockKind)193)
				{
					K = (BlockKind)190;
				}
				if (K == BlockKind.CornerSouth)
				{
					K = BlockKind.CornerEast;
				}
				else if (K == BlockKind.CornerEast)
				{
					K = BlockKind.CornerSouth;
				}
				if (K == (BlockKind)216)
				{
					K = (BlockKind)217;
				}
				else if (K == (BlockKind)217)
				{
					K = (BlockKind)216;
				}
				if (K == BlockKind.CornerStairSouth)
				{
					K = BlockKind.CornerStairNorth;
				}
				else if (K == BlockKind.CornerStairNorth)
				{
					K = BlockKind.CornerStairSouth;
				}
				if (K == BlockKind.WestFenceWest || K == (BlockKind)202 || K == (BlockKind)198 || K == BlockKind.EastFenceWest)
				{
					K = BlockKind.SouthFenceEast;
				}
				else if (K == BlockKind.SouthFenceEast || K == (BlockKind)211 || K == (BlockKind)207 || K == BlockKind.NorthFenceEast)
				{
					K = BlockKind.WestFenceWest;
				}
				if (K == BlockKind.WestFenceEast || K == (BlockKind)203 || K == (BlockKind)199 || K == BlockKind.EastFenceEast)
				{
					K = BlockKind.SouthFenceWest;
				}
				else if (K == BlockKind.SouthFenceWest || K == (BlockKind)210 || K == (BlockKind)206 || K == BlockKind.NorthFenceWest)
				{
					K = BlockKind.WestFenceEast;
				}
				if (K == BlockKind.WestFenceSouth || K == (BlockKind)205 || K == (BlockKind)201 || K == BlockKind.EastFenceSouth)
				{
					K = BlockKind.SouthFenceNorth;
				}
				else if (K == BlockKind.SouthFenceNorth || K == (BlockKind)212 || K == (BlockKind)208 || K == BlockKind.NorthFenceNorth)
				{
					K = BlockKind.WestFenceSouth;
				}
				if (K == BlockKind.WestFenceNorth || K == (BlockKind)204 || K == (BlockKind)200 || K == BlockKind.EastFenceNorth)
				{
					K = BlockKind.SouthFenceSouth;
				}
				else if (K == BlockKind.SouthFenceSouth || K == (BlockKind)213 || K == (BlockKind)209 || K == BlockKind.NorthFenceSouth)
				{
					K = BlockKind.WestFenceNorth;
				}
				if (K == BlockKind.StairEast)
				{
					K = BlockKind.StairSouth;
				}
				else if (K == BlockKind.StairSouth)
				{
					K = BlockKind.StairEast;
				}
				if (K == BlockKind.StairWest)
				{
					K = BlockKind.StairNorth;
				}
				else if (K == BlockKind.StairNorth)
				{
					K = BlockKind.StairWest;
				}
				if (K == BlockKind.QuarterOnWallWest || K == (BlockKind)148)
				{
					K = BlockKind.QuarterOnWallNorth;
				}
				else if (K == BlockKind.QuarterOnWallNorth || K == (BlockKind)146)
				{
					K = BlockKind.QuarterOnWallWest;
				}
				if (K == BlockKind.QuarterOnWallEast || K == (BlockKind)145)
				{
					K = BlockKind.QuarterOnWallSouth;
				}
				else if (K == BlockKind.QuarterOnWallSouth || K == (BlockKind)147)
				{
					K = BlockKind.QuarterOnWallEast;
				}
				if (K == (BlockKind)142 || K == BlockKind.HalfWallWest)
				{
					K = BlockKind.HalfWallNorth;
				}
				else if (K == BlockKind.HalfWallNorth || K == (BlockKind)139)
				{
					K = BlockKind.HalfWallWest;
				}
				if (K == BlockKind.HalfWallEast || K == (BlockKind)141)
				{
					K = BlockKind.HalfWallSouth;
				}
				else if (K == BlockKind.HalfWallSouth || K == (BlockKind)140)
				{
					K = BlockKind.HalfWallEast;
				}
				if (K == BlockKind.ThirdOnWallEast)
				{
					K = BlockKind.ThirdOnWallSouth;
				}
				else if (K == BlockKind.ThirdOnWallSouth)
				{
					K = BlockKind.ThirdOnWallEast;
				}
				if (K == BlockKind.ThirdOnWallWest)
				{
					K = BlockKind.ThirdOnWallNorth;
				}
				else if (K == BlockKind.ThirdOnWallNorth)
				{
					K = BlockKind.ThirdOnWallWest;
				}
			}
			if (x)
			{
				if (K == BlockKind.DiagonalOnWallSouthLeft || K == BlockKind.DiagonalOnWallWestRight || K == (BlockKind)167 || K == (BlockKind)158)
				{
					K = BlockKind.DiagonalOnWallEastLeft;
				}
				else if (K == BlockKind.DiagonalOnWallEastLeft || K == BlockKind.DiagonalOnWallSouthRight || K == (BlockKind)163 || K == (BlockKind)166)
				{
					K = BlockKind.DiagonalOnWallSouthLeft;
				}
				if (K == BlockKind.DiagonalOnWallWestLeft || K == BlockKind.DiagonalOnWallNorthRight || K == (BlockKind)159 || K == (BlockKind)170)
				{
					K = BlockKind.DiagonalOnWallNorthLeft;
				}
				else if (K == BlockKind.DiagonalOnWallNorthLeft || K == BlockKind.DiagonalOnWallEastRight || K == (BlockKind)171 || K == (BlockKind)162)
				{
					K = BlockKind.DiagonalOnWallWestLeft;
				}
				if (K == (BlockKind)192)
				{
					K = (BlockKind)193;
				}
				else if (K == (BlockKind)193)
				{
					K = (BlockKind)192;
				}
				if (K == (BlockKind)190)
				{
					K = (BlockKind)191;
				}
				else if (K == (BlockKind)191)
				{
					K = (BlockKind)190;
				}
				if (K == BlockKind.CornerEast)
				{
					K = BlockKind.CornerWest;
				}
				else if (K == BlockKind.CornerWest)
				{
					K = BlockKind.CornerEast;
				}
				if (K == BlockKind.CornerNorth)
				{
					K = BlockKind.CornerSouth;
				}
				else if (K == BlockKind.CornerSouth)
				{
					K = BlockKind.CornerNorth;
				}
				if (K == BlockKind.NorthFenceSouth || K == (BlockKind)209 || K == (BlockKind)213 || K == BlockKind.SouthFenceSouth)
				{
					K = BlockKind.NorthFenceNorth;
				}
				else if (K == BlockKind.NorthFenceNorth || K == (BlockKind)208 || K == (BlockKind)212 || K == BlockKind.SouthFenceNorth)
				{
					K = BlockKind.NorthFenceSouth;
				}
				if (K == BlockKind.NorthFenceEast || K == (BlockKind)207 || K == (BlockKind)211 || K == BlockKind.SouthFenceEast)
				{
					K = BlockKind.NorthFenceWest;
				}
				else if (K == BlockKind.NorthFenceWest || K == (BlockKind)206 || K == (BlockKind)210 || K == BlockKind.SouthFenceWest)
				{
					K = BlockKind.NorthFenceEast;
				}
				if (K == BlockKind.CornerStairWest)
				{
					K = BlockKind.CornerStairNorth;
				}
				else if (K == BlockKind.CornerStairNorth)
				{
					K = BlockKind.CornerStairWest;
				}
				if (K == (BlockKind)215)
				{
					K = (BlockKind)217;
				}
				else if (K == (BlockKind)217)
				{
					K = (BlockKind)215;
				}
				if (K == (BlockKind)216)
				{
					K = (BlockKind)214;
				}
				else if (K == (BlockKind)214)
				{
					K = (BlockKind)216;
				}
				if (K == BlockKind.CornerStairSouth)
				{
					K = BlockKind.CornerStairEast;
				}
				else if (K == BlockKind.CornerStairEast)
				{
					K = BlockKind.CornerStairSouth;
				}
				if (K == BlockKind.DiagonalOnWallWestBottom || K == (BlockKind)132 || K == (BlockKind)161)
				{
					K = BlockKind.DiagonalOnWallEastBottom;
				}
				else if (K == BlockKind.DiagonalOnWallEastBottom || K == (BlockKind)131 || K == (BlockKind)165)
				{
					K = BlockKind.DiagonalOnWallWestBottom;
				}
				if (K == BlockKind.DiagonalOnWallWestTop || K == (BlockKind)160 || K == BlockKind.DiagonalEast)
				{
					K = BlockKind.DiagonalWest;
				}
				else if (K == BlockKind.DiagonalWest || K == BlockKind.DiagonalOnWallEastTop || K == (BlockKind)164)
				{
					K = BlockKind.DiagonalEast;
				}
				if (K == BlockKind.FenceEast || K == (BlockKind)195)
				{
					K = BlockKind.FenceWest;
				}
				else if (K == BlockKind.FenceWest || K == (BlockKind)194)
				{
					K = BlockKind.FenceEast;
				}
				if (K == BlockKind.FenceNorth || K == (BlockKind)196)
				{
					K = BlockKind.FenceSouth;
				}
				else if (K == BlockKind.FenceSouth || K == (BlockKind)197)
				{
					K = BlockKind.FenceNorth;
				}
				if (K == (BlockKind)138)
				{
					K = (BlockKind)137;
				}
				else if (K == (BlockKind)137)
				{
					K = (BlockKind)138;
				}
				if (K == BlockKind.StairWest)
				{
					K = BlockKind.StairEast;
				}
				else if (K == BlockKind.StairEast)
				{
					K = BlockKind.StairWest;
				}
				if (K == BlockKind.ThirdOnWallEast)
				{
					K = BlockKind.ThirdOnWallWest;
				}
				else if (K == BlockKind.ThirdOnWallWest)
				{
					K = BlockKind.ThirdOnWallEast;
				}
				if (K == BlockKind.HalfWallEast || K == (BlockKind)141)
				{
					K = BlockKind.HalfWallWest;
				}
				else if (K == BlockKind.HalfWallWest || K == (BlockKind)142)
				{
					K = BlockKind.HalfWallEast;
				}
				if (K == BlockKind.QuarterOnWallWest || K == (BlockKind)148)
				{
					K = BlockKind.QuarterOnWallEast;
				}
				else if (K == BlockKind.QuarterOnWallEast || K == (BlockKind)145)
				{
					K = BlockKind.QuarterOnWallWest;
				}
			}
			if (y)
			{
				if (K == BlockKind.DiagonalOnWallSouthLeft || K == BlockKind.DiagonalOnWallWestRight || K == (BlockKind)167 || K == (BlockKind)158)
				{
					K = BlockKind.DiagonalOnWallWestLeft;
				}
				else if (K == BlockKind.DiagonalOnWallWestLeft || K == BlockKind.DiagonalOnWallNorthRight || K == (BlockKind)159 || K == (BlockKind)170)
				{
					K = BlockKind.DiagonalOnWallSouthLeft;
				}
				if (K == BlockKind.DiagonalOnWallEastLeft || K == BlockKind.DiagonalOnWallSouthRight || K == (BlockKind)163 || K == (BlockKind)166)
				{
					K = BlockKind.DiagonalOnWallNorthLeft;
				}
				else if (K == BlockKind.DiagonalOnWallNorthLeft || K == BlockKind.DiagonalOnWallEastRight || K == (BlockKind)171 || K == (BlockKind)162)
				{
					K = BlockKind.DiagonalOnWallEastLeft;
				}
				if (K == BlockKind.CornerSouth)
				{
					K = BlockKind.CornerWest;
				}
				else if (K == BlockKind.CornerWest)
				{
					K = BlockKind.CornerSouth;
				}
				if (K == BlockKind.CornerNorth)
				{
					K = BlockKind.CornerEast;
				}
				else if (K == BlockKind.CornerEast)
				{
					K = BlockKind.CornerNorth;
				}
				if (K == (BlockKind)192)
				{
					K = (BlockKind)190;
				}
				else if (K == (BlockKind)190)
				{
					K = (BlockKind)192;
				}
				if (K == (BlockKind)193)
				{
					K = (BlockKind)191;
				}
				else if (K == (BlockKind)191)
				{
					K = (BlockKind)193;
				}
				if (K == BlockKind.FenceEast || K == (BlockKind)195)
				{
					K = BlockKind.FenceSouth;
				}
				else if (K == BlockKind.FenceSouth || K == (BlockKind)197)
				{
					K = BlockKind.FenceEast;
				}
				if (K == BlockKind.FenceWest || K == (BlockKind)194)
				{
					K = BlockKind.FenceNorth;
				}
				else if (K == BlockKind.FenceNorth || K == (BlockKind)196)
				{
					K = BlockKind.FenceWest;
				}
				if (K == BlockKind.EastFenceEast || K == (BlockKind)199 || K == (BlockKind)203 || K == BlockKind.WestFenceEast)
				{
					K = BlockKind.EastFenceWest;
				}
				else if (K == BlockKind.EastFenceWest || K == (BlockKind)198 || K == (BlockKind)202 || K == BlockKind.WestFenceWest)
				{
					K = BlockKind.EastFenceEast;
				}
				if (K == BlockKind.EastFenceSouth || K == (BlockKind)201 || K == (BlockKind)205 || K == BlockKind.WestFenceSouth)
				{
					K = BlockKind.EastFenceNorth;
				}
				else if (K == BlockKind.EastFenceNorth || K == (BlockKind)200 || K == (BlockKind)204 || K == BlockKind.WestFenceNorth)
				{
					K = BlockKind.EastFenceSouth;
				}
				if (K == (BlockKind)215)
				{
					K = (BlockKind)216;
				}
				else if (K == (BlockKind)216)
				{
					K = (BlockKind)215;
				}
				if (K == (BlockKind)217)
				{
					K = (BlockKind)214;
				}
				else if (K == (BlockKind)214)
				{
					K = (BlockKind)217;
				}
				if (K == BlockKind.CornerStairEast)
				{
					K = BlockKind.CornerStairNorth;
				}
				else if (K == BlockKind.CornerStairNorth)
				{
					K = BlockKind.CornerStairEast;
				}
				if (K == BlockKind.CornerStairWest)
				{
					K = BlockKind.CornerStairSouth;
				}
				else if (K == BlockKind.CornerStairSouth)
				{
					K = BlockKind.CornerStairWest;
				}
				if (K == BlockKind.DiagonalNorth || K == BlockKind.DiagonalOnWallNorthTop || K == (BlockKind)172)
				{
					K = BlockKind.DiagonalSouth;
				}
				else if (K == BlockKind.DiagonalSouth || K == BlockKind.DiagonalOnWallSouthTop || K == (BlockKind)168)
				{
					K = BlockKind.DiagonalNorth;
				}
				if (K == BlockKind.DiagonalOnWallSouthBottom || K == (BlockKind)133 || K == (BlockKind)169)
				{
					K = BlockKind.DiagonalOnWallNorthBottom;
				}
				else if (K == BlockKind.DiagonalOnWallNorthBottom || K == (BlockKind)134 || K == (BlockKind)173)
				{
					K = BlockKind.DiagonalOnWallSouthBottom;
				}
				if (K == (BlockKind)135)
				{
					K = (BlockKind)136;
				}
				else if (K == (BlockKind)136)
				{
					K = (BlockKind)135;
				}
				if (K == BlockKind.StairNorth)
				{
					K = BlockKind.StairSouth;
				}
				else if (K == BlockKind.StairSouth)
				{
					K = BlockKind.StairNorth;
				}
				if (K == BlockKind.ThirdOnWallNorth)
				{
					K = BlockKind.ThirdOnWallSouth;
				}
				else if (K == BlockKind.ThirdOnWallSouth)
				{
					K = BlockKind.ThirdOnWallNorth;
				}
				if (K == BlockKind.HalfWallSouth || K == (BlockKind)140)
				{
					K = BlockKind.HalfWallNorth;
				}
				else if (K == BlockKind.HalfWallNorth || K == (BlockKind)139)
				{
					K = BlockKind.HalfWallSouth;
				}
				if (K == BlockKind.QuarterOnWallSouth || K == (BlockKind)147)
				{
					K = BlockKind.QuarterOnWallNorth;
				}
				else if (K == BlockKind.QuarterOnWallNorth || K == (BlockKind)146)
				{
					K = BlockKind.QuarterOnWallSouth;
				}
			}
			if (z)
			{
				if (K == (BlockKind)192)
				{
					K = BlockKind.CornerNorth;
				}
				else if (K == BlockKind.CornerNorth)
				{
					K = (BlockKind)192;
				}
				if (K == (BlockKind)190)
				{
					K = BlockKind.CornerEast;
				}
				else if (K == BlockKind.CornerEast)
				{
					K = (BlockKind)190;
				}
				if (K == (BlockKind)191)
				{
					K = BlockKind.CornerWest;
				}
				else if (K == BlockKind.CornerWest)
				{
					K = (BlockKind)191;
				}
				if (K == (BlockKind)193)
				{
					K = BlockKind.CornerSouth;
				}
				else if (K == BlockKind.CornerSouth)
				{
					K = (BlockKind)193;
				}
				if (K == BlockKind.CornerStairNorth)
				{
					K = (BlockKind)217;
				}
				else if (K == (BlockKind)217)
				{
					K = BlockKind.CornerStairNorth;
				}
				if (K == BlockKind.CornerStairEast)
				{
					K = (BlockKind)214;
				}
				else if (K == (BlockKind)214)
				{
					K = BlockKind.CornerStairEast;
				}
				if (K == BlockKind.CornerStairSouth)
				{
					K = (BlockKind)216;
				}
				else if (K == (BlockKind)216)
				{
					K = BlockKind.CornerStairSouth;
				}
				if (K == BlockKind.CornerStairWest)
				{
					K = (BlockKind)215;
				}
				else if (K == (BlockKind)215)
				{
					K = BlockKind.CornerStairWest;
				}
				if (K == BlockKind.EastFenceNorth || K == BlockKind.WestFenceNorth || K == (BlockKind)200 || K == (BlockKind)204)
				{
					K = BlockKind.EastFenceWest;
				}
				else if (K == BlockKind.EastFenceWest || K == BlockKind.WestFenceWest || K == (BlockKind)198 || K == (BlockKind)202)
				{
					K = BlockKind.EastFenceNorth;
				}
				if (K == BlockKind.SouthFenceEast || K == BlockKind.NorthFenceEast || K == (BlockKind)207 || K == (BlockKind)211)
				{
					K = (BlockKind)213;
				}
				else if (K == (BlockKind)213 || K == (BlockKind)209 || K == BlockKind.SouthFenceSouth || K == BlockKind.NorthFenceSouth)
				{
					K = BlockKind.SouthFenceEast;
				}
				if (K == BlockKind.WestFenceEast || K == BlockKind.EastFenceEast || K == (BlockKind)203 || K == (BlockKind)199)
				{
					K = BlockKind.WestFenceSouth;
				}
				else if (K == BlockKind.WestFenceSouth || K == BlockKind.EastFenceSouth || K == (BlockKind)205 || K == (BlockKind)201)
				{
					K = BlockKind.WestFenceEast;
				}
				if (K == BlockKind.NorthFenceNorth || K == BlockKind.SouthFenceNorth || K == (BlockKind)212 || K == (BlockKind)208)
				{
					K = BlockKind.SouthFenceWest;
				}
				else if (K == BlockKind.SouthFenceWest || K == (BlockKind)210 || K == (BlockKind)206 || K == BlockKind.NorthFenceWest)
				{
					K = BlockKind.NorthFenceNorth;
				}
				if (K == BlockKind.StairSouth)
				{
					K = (BlockKind)136;
				}
				else if (K == (BlockKind)136)
				{
					K = BlockKind.StairSouth;
				}
				if (K == BlockKind.StairWest)
				{
					K = (BlockKind)137;
				}
				else if (K == (BlockKind)137)
				{
					K = BlockKind.StairWest;
				}
				if (K == BlockKind.StairNorth)
				{
					K = (BlockKind)135;
				}
				else if (K == (BlockKind)135)
				{
					K = BlockKind.StairNorth;
				}
				if (K == BlockKind.StairEast)
				{
					K = (BlockKind)138;
				}
				else if (K == (BlockKind)138)
				{
					K = BlockKind.StairEast;
				}
				if (K == BlockKind.Quarter)
				{
					K = (BlockKind)144;
				}
				else if (K == (BlockKind)144)
				{
					K = BlockKind.Quarter;
				}
				if (K == (BlockKind)129)
				{
					K = BlockKind.Half;
				}
				else if (K == BlockKind.Half)
				{
					K = (BlockKind)129;
				}
				if (K == BlockKind.Third)
				{
					K = (BlockKind)153;
				}
				else if (K == (BlockKind)153)
				{
					K = BlockKind.Third;
				}
				if (K == BlockKind.DiagonalNorth || K == (BlockKind)172 || K == BlockKind.DiagonalOnWallNorthTop)
				{
					K = BlockKind.DiagonalOnWallNorthBottom;
				}
				else if (K == BlockKind.DiagonalOnWallNorthBottom || K == (BlockKind)173 || K == (BlockKind)134)
				{
					K = BlockKind.DiagonalNorth;
				}
				if (K == BlockKind.DiagonalSouth || K == (BlockKind)168 || K == BlockKind.DiagonalOnWallSouthTop)
				{
					K = BlockKind.DiagonalOnWallSouthBottom;
				}
				else if (K == BlockKind.DiagonalOnWallSouthBottom || K == (BlockKind)169 || K == (BlockKind)133)
				{
					K = BlockKind.DiagonalSouth;
				}
				if (K == BlockKind.DiagonalEast || K == (BlockKind)160 || K == BlockKind.DiagonalOnWallWestTop)
				{
					K = BlockKind.DiagonalOnWallWestBottom;
				}
				else if (K == BlockKind.DiagonalOnWallWestBottom || K == (BlockKind)161 || K == (BlockKind)132)
				{
					K = BlockKind.DiagonalEast;
				}
				if (K == BlockKind.DiagonalWest || K == (BlockKind)164 || K == BlockKind.DiagonalOnWallEastTop)
				{
					K = BlockKind.DiagonalOnWallEastBottom;
				}
				else if (K == BlockKind.DiagonalOnWallEastBottom || K == (BlockKind)165 || K == (BlockKind)131)
				{
					K = BlockKind.DiagonalWest;
				}
			}
			return K;
		}

		public static MyIntVect RotateVector(this MyIntVect VectorBlock, MyIntVect VecrorCur, bool x, bool y, bool z, bool w90, bool Q = false, bool W = false)
		{
			if (W)
			{
				int z2 = VectorBlock.z;
				VectorBlock.z = VectorBlock.y;
				VectorBlock.y = z2;
			}
			if (Q)
			{
				int x2 = VectorBlock.x;
				VectorBlock.x = VectorBlock.y;
				VectorBlock.y = x2;
			}
			if (w90)
			{
				int x3 = VectorBlock.x;
				VectorBlock.x = VectorBlock.z;
				VectorBlock.z = x3;
			}
			if (x)
			{
				VectorBlock.x *= -1;
			}
			if (y)
			{
				VectorBlock.z *= -1;
			}
			if (z)
			{
				VectorBlock.y *= -1;
			}
			return VectorBlock + VecrorCur;
		}

	}
}
