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
    public partial class NewWarp_Form : Form
    {
        string filePath;

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
                filePath = textBoxSourceMap.Text;
            }
        }

        private void numericX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericY_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTargetMap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Target_Map_Click(object sender, EventArgs e)
        {

        }

        private void playerY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericTargetY_ValueChanged(object sender, EventArgs e)
        {

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
        }

        private void numericTargetX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Create_Warp_Click(object sender, EventArgs e)
        {

        }

        private void NewWarp_Form_Load(object sender, EventArgs e)
        {

        }
    }
}