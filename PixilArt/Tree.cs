using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiggerPixelArt
{
    public class Tree
    {
        public int height = 10;
        public int rangeBranchCount = 8;
        public int rangeBranchLength = 8;
        public int rangeLeavesScale = 7;
        public BlockType Wood { get; set; } = BlockType.Wood;
        public BlockType Leaves { get; set; } = BlockType.Leaves;

        public static BlockInfo[] GetSphere(int Radius, byte type, bool isFlatUp)
        {
            List<BlockInfo> blocks = new List<BlockInfo>();

            for (int x = -Radius - 1; x < Radius + 1; x++)
                for (int y = -Radius - 1; y < Radius + 1; y++)
                    for (int z = -Radius - 1; z < Radius + 1; z++)
                    {
                        if (isFlatUp && z < -1)
                            continue;
                        if ((int)MyIntVect.Distance(new MyIntVect(x, y, z), MyIntVect.zero) == Radius)
                        {
                            blocks.Add(new BlockInfo(type, 0, x, y, z));
                        }
                    }

            return blocks.ToArray();
        }
        public List<BlockInfo> Generate()
        {
            Random rand = new Random();
            List<BlockInfo> build = new List<BlockInfo>();
            for (int h = 0; h < height; h++)
            {
                build.Add(BlockInfo.DefaultKind((byte)Wood, new MyIntVect(0, 0, h)));
            }
            int countBranch = rand.Next(2, 2 + rangeBranchCount);
            List<MyIntVect> PointCenterLaves = new List<MyIntVect>() { new MyIntVect(0, 0, height - 1) };
            for (int branch = 0; branch < countBranch; branch++)
            {
                int heightFirst = rand.Next(3, height + 1);
                MyIntVect point = new MyIntVect(rand.Next(-rangeBranchLength, rangeBranchLength + 1), rand.Next(-rangeBranchLength, rangeBranchLength + 1), heightFirst);
                PointCenterLaves.Add(point);
                build.AddRange(GetLine(point, new MyIntVect(0, 0, heightFirst - 2), Wood));
            }
            foreach (MyIntVect pointLaves in PointCenterLaves)
            {
                int radius = rand.Next(3, rangeLeavesScale);
                List<BlockInfo> blocks = GetSphere(radius, (byte)Leaves, true).ToList();
                blocks.ForEach(block =>
                {
                    block.x += pointLaves.x;
                    block.y += pointLaves.y;
                    block.z += pointLaves.z - radius / 4;
                });
                blocks.ForEach(block =>
                {
                    block.BlockKind = (byte)((BlockKind[])Enum.GetValues(typeof(BlockKind)))[rand.Next(20)];
                });
                for (int i = 0; i < rand.Next(blocks.Count); i++)
                    blocks.RemoveAt(rand.Next(blocks.Count));

                build.AddRange(blocks.ToArray());
            }
            return build.Select(block => new BlockInfo(block.BlockType, block.BlockKind, block.x, block.z, block.y)).ToList();
        }
        public static BlockInfo[] GetLine(MyIntVect vect1, MyIntVect vect2, BlockType type)
        {
            int distance = (int)MyIntVect.Distance(vect1, vect2) + 1;

            BlockInfo[] blocks = new BlockInfo[distance];

            for (int i = 0; i < blocks.Length; i++)
            {
                MyIntVect vector = MyIntVect.Lerp(vect1.NormalizedVector3(), vect2.NormalizedVector3(), i / (float)blocks.Length);

                blocks[i] = new BlockInfo(vector) { BlockType = (byte)type, BlockKind = 0 };
            }
            return blocks;
        }
    }
}
