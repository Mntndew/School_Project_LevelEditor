﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MntnNpc;

namespace Level_Editor.Forms
{
    public partial class NewNpc_Form : Form
    {
        string npcName;
        int x, y, width, height;
        bool up = false, down = false, left = false, right = false;
        string spriteFilePath;
        string portraitFilePath;
        bool patrolNone = false, patrolUpDown = false, patrolLeftRight = false, patrolBox = false;
        int patrolX, patrolY, patrolWidth, patrolHeight;

        public NewNpc_Form()
        {
            InitializeComponent();
        }

        private void Browse_Sprite_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSprite.Text = openFileDialog1.FileName;
                spriteFilePath = textBoxSprite.Text;
            }
        }

        private void Browse_Portrait_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPortrait.Text = openFileDialog1.FileName;
                portraitFilePath = textBoxPortrait.Text;
            }
        }

        private void Create_Npc_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            #region set values to things
            npcName = textBoxName.Text;
            x = (int)numericX.Value;
            y = (int)numericY.Value;
            width = (int)numericWidth.Value;
            height = (int)numericHeight.Value;
            if (radioButtonUp.Checked)
            {
                up = true;
                down = false;
                left = false;
                right = false;
            }
            if (radioButtonDown.Checked)
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }
            if (radioButtonLeft.Checked)
            {
                left = true;
                up = false;
                down = false;
                right = false;
            }
            if (radioButtonRight.Checked)
            {
                right = true;
                up = false;
                down = false;
                left = false;
            }
            spriteFilePath = textBoxSprite.Text;
            portraitFilePath = textBoxPortrait.Text;
            if (None.Checked)
            {
                patrolNone = true;
                patrolLeftRight = false;
                patrolUpDown = false;
                patrolBox = false;
            }
            if (Box.Checked)
            {
                patrolNone = false;
                patrolLeftRight = false;
                patrolUpDown = false;
                patrolBox = true;
            }
            if (Left_To_Right.Checked)
            {
                patrolNone = false;
                patrolLeftRight = true;
                patrolUpDown = false;
                patrolBox = false;
            }
            if (Up_To_Down.Checked)
            {
                patrolNone = false;
                patrolLeftRight = false;
                patrolUpDown = true;
                patrolBox = false;
            }
            patrolX = (int)numericPatrolX.Value;
            patrolY = (int)numericPatrolY.Value;
            patrolWidth = (int)numericPatrolWidth.Value;
            patrolHeight = (int)numericPatrolHeight.Value;
            #endregion

            Npc.CreateNpc(Game1.mapController.map.mapName, npcName, x * Game1.hud.tilesetManager.tileWidth, y * Game1.hud.tilesetManager.tileHeight, width * Game1.hud.tilesetManager.tileWidth, height * Game1.hud.tilesetManager.tileHeight, up, down, left, right,
                spriteFilePath, portraitFilePath, patrolNone, patrolUpDown, patrolLeftRight, patrolBox,
                patrolX * Game1.hud.tilesetManager.tileWidth, patrolY * Game1.hud.tilesetManager.tileHeight, patrolWidth * Game1.hud.tilesetManager.tileWidth, patrolHeight * Game1.hud.tilesetManager.tileHeight, 1);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void None_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Left_To_Right_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Up_To_Down_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void numericX_ValueChanged(object sender, EventArgs e)
        {
            x = (int)numericX.Value;
        }

        private void numericY_ValueChanged(object sender, EventArgs e)
        {
            y = (int)numericY.Value;
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            width = (int)numericWidth.Value;
        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {
            height = (int)numericHeight.Value;
        }

        private void numericPatrolX_ValueChanged(object sender, EventArgs e)
        {
            patrolX = (int)numericPatrolX.Value;
        }

        private void numericPatrolY_ValueChanged(object sender, EventArgs e)
        {
            patrolY = (int)numericPatrolY.Value;
        }

        private void numericPatrolWidth_ValueChanged(object sender, EventArgs e)
        {
            patrolWidth = (int)numericPatrolWidth.Value;
        }

        private void numericPatrolHeight_ValueChanged(object sender, EventArgs e)
        {
            patrolHeight = (int)numericPatrolHeight.Value;
        }
    }
}