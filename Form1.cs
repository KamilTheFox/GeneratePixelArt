using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiggerPixelArt;

namespace GeneratePixelArt
{
    public partial class Tree : Form
    {
        private DiggerPixelArt.Tree TreeGenerate = new DiggerPixelArt.Tree();

        public List<DiggerPixelArt.BlockInfo> blocks = new List<DiggerPixelArt.BlockInfo>();
        public Tree()
        {
            InitializeComponent();
            TypeBlockWood.Items.AddRange(Enum.GetNames(typeof(BlockType)));
            TypeBlockLaves.Items.AddRange(Enum.GetNames(typeof(BlockType)));

            TypeBlockWood.SelectedItem = TypeBlockWood.Items[(int)TreeGenerate.Wood].ToString();
            TypeBlockLaves.SelectedItem = TypeBlockLaves.Items[(int)TreeGenerate.Leaves].ToString();

            rangeLeavesScale.Text = TreeGenerate.rangeLeavesScale.ToString();
            height.Text = TreeGenerate.height.ToString();
            rangeBranchCount.Text = TreeGenerate.rangeBranchCount.ToString();
            rangeBranchLength.Text = TreeGenerate.rangeBranchLength.ToString();
        }

        private void TypeBlockWood_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeGenerate.Wood = (BlockType)TypeBlockWood.SelectedIndex;
        }

        private void TypeBlockLaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeGenerate.Leaves = (BlockType)TypeBlockLaves.SelectedIndex;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if(int.TryParse(rangeLeavesScale.Text, out int _rangeLeavesScale))
            {
                TreeGenerate.rangeLeavesScale = _rangeLeavesScale;
            }
            if (int.TryParse(height.Text, out int _height))
            {
                TreeGenerate.height = _height;
            }
            if (int.TryParse(rangeBranchCount.Text, out int _rangeBranchCount))
            {
                TreeGenerate.rangeBranchCount = _rangeBranchCount;
            }
            if (int.TryParse(rangeBranchLength.Text, out int _rangeBranchLength))
            {
                TreeGenerate.rangeBranchLength = _rangeBranchLength;
            }
            blocks = TreeGenerate.Generate();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
