using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Dithering;
using DiggerPixelArt;

namespace GeneratePixelArt
{
    public partial class PixelArtMenu : Form
    {
        GeneratorsForm generatorsForm = new GeneratorsForm();
        public static int[] settingsImage =
        {
            (int)InterpolationMode.HighQualityBicubic,
            (int)CompositingQuality.Default,
            (int)SmoothingMode.Default,
            (int)PixelOffsetMode.Default,
            (int)TypeDithering.None,
        };

        private static Bitmap image;

        private static List<DiggerPixelArt.BlockInfo> blocks = new List<DiggerPixelArt.BlockInfo>();

        public PixelArtMenu()
        {
            InitializeComponent();

            interpolationMode.Items.AddRange(Enum.GetNames(typeof(InterpolationMode)));
            compositingQuality.Items.AddRange(Enum.GetNames(typeof(CompositingQuality)));
            smoothingMode.Items.AddRange(Enum.GetNames(typeof(SmoothingMode)));
            pixelOffsetMode.Items.AddRange(Enum.GetNames(typeof(PixelOffsetMode)));
            typeDithering.Items.AddRange(Enum.GetNames(typeof(TypeDithering)));

            interpolationMode.SelectedItem = interpolationMode.Items[settingsImage[0]].ToString();
            compositingQuality.SelectedItem = compositingQuality.Items[settingsImage[1]].ToString();
            smoothingMode.SelectedItem = smoothingMode.Items[settingsImage[2]].ToString();
            pixelOffsetMode.SelectedItem = pixelOffsetMode.Items[settingsImage[3]].ToString();
            typeDithering.SelectedItem = typeDithering.Items[settingsImage[4]].ToString();
        }

        private void OpenBitMap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files(*.BMP;*.JPEG;*.PNG;*.JPG;*.GIF)|*.BMP;*.JPEG;*.PNG;*.JPG;*.GIF|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(open.OpenFile());
                    pictureBox1.Image = image;
                    Height.Text = image.Height.ToString();
                    Width.Text = image.Width.ToString();
                    pictureBox2.Image = null;
                    blocks.Clear();
                }
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if(image == null)
            {
                MessageBox.Show("Хуйню делаешь. Загрузи сначала изображение", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(Width.Text, out int width) && int.TryParse(Height.Text, out int height))
            {
                var tuple = ColorConvert.ConvertRGB(image, width, height);
                blocks = tuple.Item2;
                Bitmap bitmapConvert = tuple.Item1;
                pictureBox2.Image = ColorConvert.Resize(bitmapConvert, bitmapConvert.Width * 4, bitmapConvert.Height * 4);
                return;
            }
            MessageBox.Show("Хуйню делаешь. Или не забил ширину или высоту", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SaveArt_Click(object sender, EventArgs e)
        {
            if(blocks.Count == 0)
            {
                MessageBox.Show("Хуйню делаешь. Загрузи или конвертируй изображение", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "JSON Files(*.json)|*.json|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (rotateToZ.Checked)
                    {
                        blocks = blocks.Select(block =>
                        new DiggerPixelArt.BlockInfo(block.BlockType, block.BlockKind, block.z, block.y, block.x))
                        .ToList();
                    }
                    if (isInverter.Checked)
                    {
                        DiggerPixelArt.MyIntVect maxVect = blocks.GetBlockMax();
                        blocks =
                        blocks.Select(block =>
                        new DiggerPixelArt.BlockInfo(block.BlockType, block.BlockKind, maxVect.x - block.x, block.y, maxVect.z - block.z))
                        .ToList();
                    }
                    System.IO.File.WriteAllText(save.FileName, blocks.GetBlockArrayToJSON());
                }
            }
        }

        private void interpolationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsImage[0] = interpolationMode.SelectedIndex;
        }

        private void compositingQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsImage[1] = compositingQuality.SelectedIndex;
        }

        private void smoothingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsImage[2] = smoothingMode.SelectedIndex;
        }

        private void pixelOffsetMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsImage[3] = pixelOffsetMode.SelectedIndex;
        }

        private void typeDithering_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsImage[4] = typeDithering.SelectedIndex;
        }

        private void TreeGenerate_Click(object sender, EventArgs e)
        {
            generatorsForm.ShowDialog();
        }
    }
}
