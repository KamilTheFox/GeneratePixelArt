using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DiggerPixelArt
{
    [Serializable]
    public class BlockInfo
    {
        public byte BlockType;
        public byte BlockKind;
        public int x;
        public int y;
        public int z;
        public BlockInfo(byte type, byte kind, int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
            BlockType = type;
            BlockKind = kind;
        }
        public BlockInfo()
        {
            x = 0;
            y = 0;
            z = 0;
            BlockType = 0;
            BlockKind = 0;
        }
        public BlockInfo(MyIntVect vect)
        {
            x = vect.x;
            y = vect.y;
            z = vect.z;
            BlockType = 0;
            BlockKind = 0;
        }
        public static BlockInfo DefaultKind(byte block, MyIntVect vect)
        {
            return new BlockInfo((byte)block, 0, vect.x, vect.y, vect.z);
        }
        public static BlockInfo GetBlock(byte block, byte kind, MyIntVect vect)
        {
            return new BlockInfo((byte)block, (byte)kind, vect.x, vect.y, vect.z);
        }
        public static BlockInfo operator +(BlockInfo block, MyIntVect vector)
        {
            block.x = vector.x;
            block.y = vector.y;
            block.z = vector.z;
            return block;
        }
        public static implicit operator MyIntVect(BlockInfo vector)
        {
            return new MyIntVect(vector.x, vector.y, vector.z);
        }
        public BlockInfo Copy()
        {
            return new BlockInfo(BlockType, BlockKind, x, y, z);
        }
        public override string ToString()
        {
            return $"Type {(byte)BlockType} Type {(byte)BlockKind}";
        }
        public string GetJsonBlock
        {
            get
            {
                return $"{{\"x\":{x},\"y\":{y},\"z\":{z},\"blockType\":{BlockType},\"blockKind\":{BlockKind}}}";
            }

        }
    }
    public static class ExtensionBlockList
    {
        public static List<BlockInfo> GetBlockInfoOfJSON(this string json)
        {
            json = json.Replace(" ", "").Replace("   ", "").Replace("\n", "");
            MatchCollection matches = Regex.Matches(json, @"{(.*?)},");
            List<BlockInfo> blocks = new List<BlockInfo>();
            foreach (Match block in matches)
            {
                string type = Regex.Match(block.Value, @"""blockType"":([0-9]+)").Groups[1].Value;
                string kind = Regex.Match(block.Value, @"""blockKind"":([0-9]+)").Groups[1].Value;
                string x = Regex.Match(block.Value, @"""x"":([0-9]+)").Groups[1].Value;
                string y = Regex.Match(block.Value, @"""y"":([0-9]+)").Groups[1].Value;
                string z = Regex.Match(block.Value, @"""z"":([0-9]+)").Groups[1].Value;
                if (int.TryParse(type, out int blockT) &&
                    int.TryParse(kind, out int blockK) &&
                    int.TryParse(x, out int X) &&
                        int.TryParse(y, out int Y) &&
                    int.TryParse(z, out int Z))
                    blocks.Add(new BlockInfo()
                    {
                        BlockType = (byte)blockT,
                        BlockKind = (byte)blockK,
                        x = X,
                        z = Z,
                        y = Y
                    });
            }
            return blocks;
        }
        public static string GetBlockArrayToJSON(this List<BlockInfo> blocks)
        {
            StringBuilder blocksBuilder = new StringBuilder("[");
            blocks.ForEach(block =>
            {
                blocksBuilder.Append($"{block.GetJsonBlock},");
            });
            blocksBuilder.Remove(blocksBuilder.Length - 1, 1);
            blocksBuilder.Append("]");
            return blocksBuilder.ToString();
        }
        public static MyIntVect GetBlockMax(this List<BlockInfo> blocks)
        {
            return new MyIntVect(
                blocks.Select(block => block.x).Max(), 
                blocks.Select(block => block.y).Max(),
                blocks.Select(block => block.z).Max());
        }
    }
}
