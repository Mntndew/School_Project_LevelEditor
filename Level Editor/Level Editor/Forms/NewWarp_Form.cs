using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Level_Editor.Forms
{
    public partial class NewWarp_Form : Form
    {
        public string sourceFilePath;
        string targetFilePath;
        string sourceName;
        string targetName;

        int sourceX, sourceY, width, height;
        int targetX, targetY;

        public NewWarp_Form()
        {
            InitializeComponent();
        }

        private void textBoxSourceMap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Source_Map_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSourceMap.Text = openFileDialog1.FileName;
                sourceFilePath = textBoxSourceMap.Text;
            }
        }

        private void numericX_ValueChanged(object sender, EventArgs e)
        {
            sourceX = (int)numericX.Value * Game1.mapController.tileWidth;
        }

        private void numericY_ValueChanged(object sender, EventArgs e)
        {
            sourceY = (int)numericY.Value * Game1.mapController.tileHeight;
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            width = (int)numericWidth.Value * Game1.mapController.tileWidth;
        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {
            height = (int)numericHeight.Value * Game1.mapController.tileHeight;
        }

        private void textBoxTargetMap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Target_Map_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTargetMap.Text = openFileDialog1.FileName;
                targetFilePath = textBoxTargetMap.Text;
            }
        }

        private void playerY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customY_CheckedChanged(object sender, EventArgs e)
        {
            if (customY.Checked)
            {
                numericTargetY.ReadOnly = false;
            }
            else
                numericTargetY.ReadOnly = true;
        }

        private void numericTargetY_ValueChanged(object sender, EventArgs e)
        {
            if (customY.Checked)
            {
                targetY = (int)numericTargetY.Value * Game1.mapController.tileHeight;
            }
            else
                targetY = -1;
        }

        private void playerX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customX_CheckedChanged(object sender, EventArgs e)
        {
            if (customX.Checked)
            {
                numericTargetX.ReadOnly = false;
            }
            else
                numericTargetX.ReadOnly = true;
        }

        private void numericTargetX_ValueChanged(object sender, EventArgs e)
        {
            if (customX.Checked)
            {
                targetX = (int)numericTargetX.Value * Game1.mapController.tileWidth;
            }
            else
                targetX = -1;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Create_Warp_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            //change the path to the name
            StreamReader reader = new StreamReader(sourceFilePath);
            sourceName = reader.ReadLine();
            reader.Close();

            reader = new StreamReader(targetFilePath);
            targetName = reader.ReadLine();
            reader.Close();

            if (!Directory.Exists(Game1.mapController.map.rootPath + @"Warp\"))
            {
                Directory.CreateDirectory(Game1.mapController.map.rootPath + @"Warp\");
            }
            int index = Directory.GetFiles(Game1.mapController.map.rootPath + @"Warp\").Length;

            StreamWriter writer = new StreamWriter(Game1.mapController.map.rootPath + @"Warp\" + sourceName + "_" + index + ".txt");
            writer.WriteLine(sourceFilePath);
            writer.WriteLine(sourceX);
            writer.WriteLine(sourceY);
            writer.WriteLine(width);
            writer.WriteLine(height);
            writer.WriteLine(targetFilePath);
            writer.WriteLine(targetX);
            writer.WriteLine(targetY);
            writer.Close();
            Game1.hud.LoadWarp();
        }

        private void NewWarp_Form_Load(object sender, EventArgs e)
        {

        }

        private void Source_Enter(object sender, EventArgs e)
        {

        }
    }
}