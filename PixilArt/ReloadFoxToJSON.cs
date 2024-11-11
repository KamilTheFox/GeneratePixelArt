using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DiggerPixelArt;

namespace GeneratePixelArt.PixilArt
{
    public partial class ReloadFoxToJSON : Form
    {
        public ReloadFoxToJSON()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog open = new OpenFileDialog())
            //{
            //    open.Filter = open.Filter = "FOX Files(*.fox)|*.fox|All files (*.*)|*.*";
            //    if (open.ShowDialog() == DialogResult.OK)
            //    {
            //        using (SaveFileDialog save = new SaveFileDialog())
            //        {
            //            save.Filter = "JSON Files(*.json)|*.json|All files (*.*)|*.*";
            //            if (save.ShowDialog() == DialogResult.OK)
            //            {
            //                FileInfo file = new FileInfo(open.FileName);
            //                string directory = file.Directory.FullName;

            //                FileInfo filesave = new FileInfo(open.FileName);
            //                string directorySave = file.Directory.FullName;

            //                var namesFox = Directory.GetFiles(directory).ToList().Where(name => name.Contains(".fox")).ToList();

            //                namesFox.ForEach(name =>
            //                {
            //                    var filenameThis = new FileInfo(name);
            //                    BlockInfo[] blocks = Configuration.Open<BlockInfo[]>(filenameThis.Directory.FullName, filenameThis.Name);

            //                    var blocksJSON = blocks.ToList().Select(block => new DiggerPixelArt.BlockInfo((byte)block.BlockType, (byte)block.BlockKind, block.x, block.z, block.y)).ToList();

            //                    System.IO.File.WriteAllText(directorySave + "\\" + filenameThis.Name + ".json", blocksJSON.GetBlockArrayToJSON());

            //                });
            //            }
            //        }

            //    }
            //}
        }
    }
}
