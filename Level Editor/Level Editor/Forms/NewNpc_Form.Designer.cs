namespace Level_Editor.Forms
{
    partial class NewNpc_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Browse_Sprite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPortrait = new System.Windows.Forms.TextBox();
            this.textBoxSprite = new System.Windows.Forms.TextBox();
            this.Browse_Portrait = new System.Windows.Forms.Button();
            this.None = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericPatrolHeight = new System.Windows.Forms.NumericUpDown();
            this.numericPatrolWidth = new System.Windows.Forms.NumericUpDown();
            this.numericPatrolY = new System.Windows.Forms.NumericUpDown();
            this.numericPatrolX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.RadioButton();
            this.Up_To_Down = new System.Windows.Forms.RadioButton();
            this.Left_To_Right = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Create_Npc = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse_Sprite
            // 
            this.Browse_Sprite.Location = new System.Drawing.Point(168, 16);
            this.Browse_Sprite.Name = "Browse_Sprite";
            this.Browse_Sprite.Size = new System.Drawing.Size(75, 23);
            this.Browse_Sprite.TabIndex = 0;
            this.Browse_Sprite.Text = "Browse";
            this.Browse_Sprite.UseVisualStyleBackColor = true;
            this.Browse_Sprite.Click += new System.EventHandler(this.Browse_Sprite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPortrait);
            this.groupBox1.Controls.Add(this.textBoxSprite);
            this.groupBox1.Controls.Add(this.Browse_Portrait);
            this.groupBox1.Controls.Add(this.Browse_Sprite);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sprite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Portrait";
            // 
            // textBoxPortrait
            // 
            this.textBoxPortrait.Location = new System.Drawing.Point(52, 49);
            this.textBoxPortrait.Name = "textBoxPortrait";
            this.textBoxPortrait.Size = new System.Drawing.Size(110, 20);
            this.textBoxPortrait.TabIndex = 2;
            // 
            // textBoxSprite
            // 
            this.textBoxSprite.Location = new System.Drawing.Point(52, 18);
            this.textBoxSprite.Name = "textBoxSprite";
            this.textBoxSprite.Size = new System.Drawing.Size(110, 20);
            this.textBoxSprite.TabIndex = 2;
            // 
            // Browse_Portrait
            // 
            this.Browse_Portrait.Location = new System.Drawing.Point(168, 47);
            this.Browse_Portrait.Name = "Browse_Portrait";
            this.Browse_Portrait.Size = new System.Drawing.Size(75, 23);
            this.Browse_Portrait.TabIndex = 0;
            this.Browse_Portrait.Text = "Browse";
            this.Browse_Portrait.UseVisualStyleBackColor = true;
            this.Browse_Portrait.Click += new System.EventHandler(this.Browse_Portrait_Click);
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Location = new System.Drawing.Point(6, 37);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(51, 17);
            this.None.TabIndex = 2;
            this.None.TabStop = true;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericPatrolHeight);
            this.groupBox2.Controls.Add(this.numericPatrolWidth);
            this.groupBox2.Controls.Add(this.numericPatrolY);
            this.groupBox2.Controls.Add(this.numericPatrolX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Box);
            this.groupBox2.Controls.Add(this.Up_To_Down);
            this.groupBox2.Controls.Add(this.Left_To_Right);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.None);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patrol Options";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // numericPatrolHeight
            // 
            this.numericPatrolHeight.Location = new System.Drawing.Point(210, 85);
            this.numericPatrolHeight.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericPatrolHeight.Name = "numericPatrolHeight";
            this.numericPatrolHeight.Size = new System.Drawing.Size(35, 20);
            this.numericPatrolHeight.TabIndex = 22;
            this.numericPatrolHeight.ValueChanged += new System.EventHandler(this.numericPatrolHeight_ValueChanged);
            // 
            // numericPatrolWidth
            // 
            this.numericPatrolWidth.Location = new System.Drawing.Point(159, 85);
            this.numericPatrolWidth.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericPatrolWidth.Name = "numericPatrolWidth";
            this.numericPatrolWidth.Size = new System.Drawing.Size(35, 20);
            this.numericPatrolWidth.TabIndex = 21;
            this.numericPatrolWidth.ValueChanged += new System.EventHandler(this.numericPatrolWidth_ValueChanged);
            // 
            // numericPatrolY
            // 
            this.numericPatrolY.Location = new System.Drawing.Point(210, 34);
            this.numericPatrolY.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericPatrolY.Name = "numericPatrolY";
            this.numericPatrolY.Size = new System.Drawing.Size(35, 20);
            this.numericPatrolY.TabIndex = 20;
            this.numericPatrolY.ValueChanged += new System.EventHandler(this.numericPatrolY_ValueChanged);
            // 
            // numericPatrolX
            // 
            this.numericPatrolX.Location = new System.Drawing.Point(159, 34);
            this.numericPatrolX.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericPatrolX.Name = "numericPatrolX";
            this.numericPatrolX.Size = new System.Drawing.Size(35, 20);
            this.numericPatrolX.TabIndex = 16;
            this.numericPatrolX.ValueChanged += new System.EventHandler(this.numericPatrolX_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // Box
            // 
            this.Box.AutoSize = true;
            this.Box.BackColor = System.Drawing.SystemColors.Control;
            this.Box.Location = new System.Drawing.Point(85, 37);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(43, 17);
            this.Box.TabIndex = 10;
            this.Box.TabStop = true;
            this.Box.Text = "Box";
            this.Box.UseVisualStyleBackColor = false;
            // 
            // Up_To_Down
            // 
            this.Up_To_Down.AutoSize = true;
            this.Up_To_Down.Location = new System.Drawing.Point(6, 83);
            this.Up_To_Down.Name = "Up_To_Down";
            this.Up_To_Down.Size = new System.Drawing.Size(82, 17);
            this.Up_To_Down.TabIndex = 4;
            this.Up_To_Down.TabStop = true;
            this.Up_To_Down.Text = "Up to Down";
            this.Up_To_Down.UseVisualStyleBackColor = true;
            this.Up_To_Down.CheckedChanged += new System.EventHandler(this.Up_To_Down_CheckedChanged);
            // 
            // Left_To_Right
            // 
            this.Left_To_Right.AutoSize = true;
            this.Left_To_Right.Location = new System.Drawing.Point(6, 60);
            this.Left_To_Right.Name = "Left_To_Right";
            this.Left_To_Right.Size = new System.Drawing.Size(83, 17);
            this.Left_To_Right.TabIndex = 4;
            this.Left_To_Right.TabStop = true;
            this.Left_To_Right.Text = "Left to Right";
            this.Left_To_Right.UseVisualStyleBackColor = true;
            this.Left_To_Right.CheckedChanged += new System.EventHandler(this.Left_To_Right_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patrol Type";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG files |*.png|All files|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonRight);
            this.groupBox3.Controls.Add(this.numericHeight);
            this.groupBox3.Controls.Add(this.radioButtonLeft);
            this.groupBox3.Controls.Add(this.numericX);
            this.groupBox3.Controls.Add(this.radioButtonDown);
            this.groupBox3.Controls.Add(this.numericWidth);
            this.groupBox3.Controls.Add(this.radioButtonUp);
            this.groupBox3.Controls.Add(this.numericY);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Npc Options";
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonRight.Location = new System.Drawing.Point(65, 61);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(50, 17);
            this.radioButtonRight.TabIndex = 26;
            this.radioButtonRight.TabStop = true;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.UseVisualStyleBackColor = false;
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(210, 83);
            this.numericHeight.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(35, 20);
            this.numericHeight.TabIndex = 24;
            this.numericHeight.ValueChanged += new System.EventHandler(this.numericHeight_ValueChanged);
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(65, 84);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLeft.TabIndex = 25;
            this.radioButtonLeft.TabStop = true;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(159, 32);
            this.numericX.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(35, 20);
            this.numericX.TabIndex = 15;
            this.numericX.ValueChanged += new System.EventHandler(this.numericX_ValueChanged);
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(6, 84);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDown.TabIndex = 24;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "Down";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(159, 83);
            this.numericWidth.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(35, 20);
            this.numericWidth.TabIndex = 23;
            this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(6, 61);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonUp.TabIndex = 23;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Up";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(210, 32);
            this.numericY.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(35, 20);
            this.numericY.TabIndex = 7;
            this.numericY.ValueChanged += new System.EventHandler(this.numericY_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Orientation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Width";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(46, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(110, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name";
            // 
            // Create_Npc
            // 
            this.Create_Npc.Location = new System.Drawing.Point(12, 335);
            this.Create_Npc.Name = "Create_Npc";
            this.Create_Npc.Size = new System.Drawing.Size(128, 22);
            this.Create_Npc.TabIndex = 5;
            this.Create_Npc.Text = "Create Npc";
            this.Create_Npc.UseVisualStyleBackColor = true;
            this.Create_Npc.Click += new System.EventHandler(this.Create_Npc_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(146, 335);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(128, 22);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewNpc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 369);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Create_Npc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewNpc_Form";
            this.Text = "NewNpc_Form";
            this.Load += new System.EventHandler(this.NewNpc_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPatrolX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Browse_Sprite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Browse_Portrait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPortrait;
        private System.Windows.Forms.TextBox textBoxSprite;
        private System.Windows.Forms.RadioButton None;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Up_To_Down;
        private System.Windows.Forms.RadioButton Left_To_Right;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton Box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Create_Npc;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericPatrolHeight;
        private System.Windows.Forms.NumericUpDown numericPatrolWidth;
        private System.Windows.Forms.NumericUpDown numericPatrolY;
        private System.Windows.Forms.NumericUpDown numericPatrolX;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
    }
}