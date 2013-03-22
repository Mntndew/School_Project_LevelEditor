using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Level_Editor.Forms
{
    public partial class LoadTileset_Form : Form
    {
        public string filePath = null;
        public int tileWidth, tileHeight;

        public LoadTileset_Form()
        {
            tileWidth = 64;
            tileHeight = 64;
            InitializeComponent();
        }

        private void LoadTileset_Form_Load(object sender, EventArgs e)
        {

        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                filePath = textBox1.Text;
            }
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tile_Width_ValueChanged(object sender, EventArgs e)
        {
            tileWidth = (int)tile_Width.Value;
        }

        private void tile_Height_ValueChanged(object sender, EventArgs e)
        {
            tileHeight = (int)tile_Height.Value;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}