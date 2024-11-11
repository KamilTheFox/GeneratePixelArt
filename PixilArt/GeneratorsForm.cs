using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiggerPixelArt;
using BuildAPI;

namespace GeneratePixelArt
{
    public partial class GeneratorsForm : Form
    {
        public List<DiggerPixelArt.BlockInfo> blocks = new List<DiggerPixelArt.BlockInfo>();

        BlockType TypeBlockGenerate = BlockType.Colored1;
        
        public GeneratorsForm()
        {
            InitializeComponent();
            InitializeCheckbBox();
            InitializePanels();
            TypeBlock.Items.AddRange(Enum.GetNames(typeof(BlockType)));
            TypeBlockCelindr.Items.AddRange(Enum.GetNames(typeof(BlockType)));
            BlockTypeSpoof.Items.AddRange(Enum.GetNames(typeof(BlockType)));
            BlockTypeSpoof2.Items.AddRange(Enum.GetNames(typeof(BlockType)));
            TypeBlockPlane.Items.AddRange(Enum.GetNames(typeof(BlockType)));
            SyncTypeBlock();
        }

        private void SyncTypeBlock()
        {
            TypeBlock.SelectedItem = TypeBlock.Items[(int)TypeBlockGenerate].ToString();
            TypeBlockCelindr.SelectedItem = TypeBlock.SelectedItem;
            BlockTypeSpoof.SelectedItem = TypeBlock.SelectedItem;
            TypeBlockPlane.SelectedItem = TypeBlock.SelectedItem;
            BlockTypeSpoof2.SelectedItem = TypeBlock.Items[(int)BlockType.Colored4].ToString();
        }

        GeneratePixelArt.Tree tree = new GeneratePixelArt.Tree();

        private Control[] panels;

        private void InitializePanels()
        {
            panels = new Control[]
            {
                spherePanel,
                celindrPanel,
                rotateMenu,
                planePanel,
                rotateMenu,
                panelSpoof
            };
            panels.ToList().ForEach(panel =>
            {
                panel.Visible = false;
                panel.BackColor = Color.FromArgb(50, Color.Gray);
            });
            panel1.BackColor = Color.FromArgb(50, Color.Gray);
        }

        private CheckBox[] CheckBoxes;

        private void InitializeCheckbBox()
        {
            CheckBoxes = new CheckBox[]
            {
                sphere,
                celindr,
                rotates,
                plane,
                rotates,
                spoof
            };
            for(int i = 0; i < CheckBoxes.Length; i++)
            {
                int index = i;
                CheckBoxes[i].MouseClick += (object sender, MouseEventArgs e) =>
                {
                    ChangeCheck(index);
                    SyncTypeBlock();
                };
            }
        }

        private void ChangeCheck(int selectCheck)
        {
            for (int i = 0; i < CheckBoxes.Length; i++)
            {
                CheckBoxes[i].CheckState = selectCheck == i ? CheckState.Checked : CheckState.Unchecked;
                panels[i].Visible = selectCheck == i;
            }
        }

        private void SaveBuildToFile(List<BlockInfo> blocks)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "JSON Files(*.json)|*.json|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                    System.IO.File.WriteAllText(save.FileName, blocks.GetBlockArrayToJSON());
            }
        }
        
        private void OpenBuildOfJSON()
        {
            blocks.Clear();
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "JSON Files(*.json)|*.json|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                    blocks = System.IO.File.ReadAllText(open.FileName).GetBlockInfoOfJSON();
            }
            if (blocks.Count == 0)
                throw new Exception("Блоки не считались, соре. Видимо формат файла хуевый, я хз");
        }

        private void startGenerateTree(object sender, EventArgs e)
        {
            if (tree.ShowDialog() == DialogResult.OK)
            {
                SaveBuildToFile(tree.blocks);
            }
        }

        private void BuildGenerateToCondition(Vector2 rangeX, Vector2 rangeY, Vector2 rangeZ ,Func<MyIntVect, bool> func)
        {
            blocks.Clear();
            for (int x = (int)rangeX.X; x < rangeX.Y ; x++)
                for (int y = (int)rangeY.X; y < rangeY.Y ; y++)
                    for (int z = (int)rangeZ.X; z < rangeZ.Y; z++)
                    {
                        if(func(new MyIntVect(x,y,z)))
                            blocks.Add(new BlockInfo((byte)TypeBlockGenerate, 0, x, y, z));
                    }
            SaveBuildToFile(blocks);
        }

        private void radiusTextSphere_TextChanged(object sender, EventArgs e)
        {
            if(!radiusTextSphere.Text.Contains("Радиус: "))
            {
                radiusTextSphere.Text = "Радиус: 5";
            }
        }
        private void radiusCelindr_TextChanged(object sender, EventArgs e)
        {
            if (!radiusCelindr.Text.Contains("Радиус: "))
            {
                radiusCelindr.Text = "Радиус: 5";
            }
        }

        private void HeightCelindr_TextChanged(object sender, EventArgs e)
        {
            if (!HeightCelindr.Text.Contains("Высота: "))
            {
                HeightCelindr.Text = "Высота: 5";
            }
        }
        private void PlaneX_TextChanged(object sender, EventArgs e)
        {
            if (!PlaneX.Text.Contains("X: "))
            {
                PlaneX.Text = "X: 5";
            }
        }
        private void PlaneY_TextChanged(object sender, EventArgs e)
        {
            if (!PlaneY.Text.Contains("Y: "))
            {
                PlaneY.Text = "Y: 5";
            }
        }

        private void PnaneZ_TextChanged(object sender, EventArgs e)
        {
            if (!PlaneZ.Text.Contains("Z: "))
            {
                PlaneZ.Text = "Z: 5";
            }
        }


        private void generateSphere_Click(object sender, EventArgs e)
        {
            int radius;
            if (!int.TryParse(radiusTextSphere.Text.Replace("Радиус: ",""), out radius))
            {
                MessageBox.Show("РАДИУС ДОЛЖЕН БЫТЬ ЧИСЛОМ БЛЯТЬ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Vector2 range = new Vector2(-radius - 1, radius + 1);
            BuildGenerateToCondition(range, range, range, (vect) => 
            {
                float distance = Vector3.Distance(vect.GetVector(), Vector3.Zero);
                bool rangeExternal = radius - 1 < distance;
                bool rangeInternal = radius + 1 > distance;

                if(fillSphere.Checked)
                {
                    return rangeInternal;
                }
                return rangeExternal && rangeInternal;
            });
        }



        private void TypeBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeBlockGenerate = (BlockType)TypeBlock.SelectedIndex;
        }
        private void TypeBlockCelindr_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeBlockGenerate = (BlockType)TypeBlockCelindr.SelectedIndex;
        }
        private void BlockTypeCircles_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeBlockGenerate = (BlockType)BlockTypeSpoof.SelectedIndex;
        }
        private void TypeBlockPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeBlockGenerate = (BlockType)TypeBlockPlane.SelectedIndex;
        }

        private void generateCelindr_Click(object sender, EventArgs e)
        {
            int radius;
            if (!int.TryParse(radiusCelindr.Text.Replace("Радиус: ", ""), out radius))
            {
                MessageBox.Show("РАДИУС ДОЛЖЕН БЫТЬ ЧИСЛОМ БЛЯТЬ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int height;
            if (!int.TryParse(HeightCelindr.Text.Replace("Высота: ", ""), out height))
            {
                MessageBox.Show("ВЫСОТА ДОЛЖЕН БЫТЬ ЧИСЛОМ БЛЯТЬ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Vector2 range = new Vector2(-radius - 1, radius + 1);
            BuildGenerateToCondition(range, new Vector2(0, height), range, (vect) =>
            {
                float distance = Vector3.Distance(vect.GetVector(), Vector3.Zero + new Vector3(0, vect.y, 0));
                bool rangeExternal = radius - 1 < distance;
                bool rangeInternal = radius + 1 > distance;

                if (fillSphere.Checked)
                {
                    return rangeInternal;
                }
                return rangeExternal && rangeInternal;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            if (!int.TryParse(PlaneX.Text.Replace("X: ", ""), out x))
            {
                MessageBox.Show("X ДОЛЖЕН БЫТЬ ЧИСЛОМ БЛЯТЬ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(PlaneY.Text.Replace("Y: ", ""), out y))
            {
                MessageBox.Show("Y ДОЛЖЕН БЫТЬ ЧИСЛОМ БЛЯТЬ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(PlaneZ.Text.Replace("Z: ", ""), out z))
            {
                MessageBox.Show("Z ДОЛЖЕН БЫТЬ ЧИСЛОМ БЛЯТЬ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuildGenerateToCondition(new Vector2(0, x), new Vector2(0, y), new Vector2(0, z), (vect) =>
            {
                bool range = vect.x == 0 || vect.x == x - 1 ||
                             vect.y == 0 || vect.y == y - 1 ||
                             vect.z == 0 || vect.z == z - 1;
                return (!FillPlane.Checked && range) || FillPlane.Checked;
            });
        }

        private void GeneratorsForm_Load(object sender, EventArgs e)
        {

        }

        private void ReadBuild_Click(object sender, EventArgs e)
        {
            OpenBuildOfJSON();
        }

        private void SaveRotate_Click(object sender, EventArgs e)
        {
            List<BlockInfo> rotate = blocks.Select((b) =>
            {
                b.BlockKind = (byte)((BlockKind)b.BlockKind).RotateKind(rotX.Checked, rotY.Checked, rotZ.Checked, rot90.Checked);
                return b + ((MyIntVect)b).RotateVector(MyIntVect.zero ,rotX.Checked, rotY.Checked, rotZ.Checked, rot90.Checked);
            }).ToList();
            SaveBuildToFile(rotate);
        }

        private void ReadSpoof_Click(object sender, EventArgs e)
        {
            OpenBuildOfJSON();
        }

        private void SaveSpoof_Click(object sender, EventArgs e)
        {
            List<BlockInfo> spoof = blocks.Select((b) =>
            {
                if(b.BlockType == (byte)(BlockType)BlockTypeSpoof.SelectedIndex)
                {
                    b.BlockType = (byte)(BlockType)BlockTypeSpoof2.SelectedIndex;
                }
                return b;
            }).ToList();
            SaveBuildToFile(spoof);
        }
    }
}
