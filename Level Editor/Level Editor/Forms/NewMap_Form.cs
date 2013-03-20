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
    public partial class NewMap_Form : Form
    {
        public int mapWidth, mapHeight;
        public string mapName = "new map";

        public NewMap_Form()
        {
            mapWidth = 30;
            mapHeight = 30;
            InitializeComponent();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mapWidth = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            mapHeight = (int)numericUpDown2.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mapName = textBox1.Text;
        }
    }
}
