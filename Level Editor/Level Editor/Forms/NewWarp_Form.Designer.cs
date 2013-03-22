namespace Level_Editor.Forms
{
    partial class NewWarp_Form
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
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.GroupBox();
            this.Browse_Source_Map = new System.Windows.Forms.Button();
            this.textBoxSourceMap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customY = new System.Windows.Forms.RadioButton();
            this.playerY = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericTargetY = new System.Windows.Forms.NumericUpDown();
            this.xCoordinate = new System.Windows.Forms.GroupBox();
            this.customX = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.playerX = new System.Windows.Forms.RadioButton();
            this.numericTargetX = new System.Windows.Forms.NumericUpDown();
            this.Browse_Target_Map = new System.Windows.Forms.Button();
            this.textBoxTargetMap = new System.Windows.Forms.TextBox();
            this.Create_Warp = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.Source.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTargetY)).BeginInit();
            this.xCoordinate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTargetX)).BeginInit();
            this.SuspendLayout();
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(129, 59);
            this.numericHeight.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(35, 20);
            this.numericHeight.TabIndex = 32;
            this.numericHeight.ValueChanged += new System.EventHandler(this.numericHeight_ValueChanged);
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(6, 59);
            this.numericX.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(35, 20);
            this.numericX.TabIndex = 30;
            this.numericX.ValueChanged += new System.EventHandler(this.numericX_ValueChanged);
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(88, 59);
            this.numericWidth.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(35, 20);
            this.numericWidth.TabIndex = 31;
            this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(47, 59);
            this.numericY.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(35, 20);
            this.numericY.TabIndex = 25;
            this.numericY.ValueChanged += new System.EventHandler(this.numericY_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Width";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Y";
            // 
            // Source
            // 
            this.Source.Controls.Add(this.Browse_Source_Map);
            this.Source.Controls.Add(this.textBoxSourceMap);
            this.Source.Controls.Add(this.label11);
            this.Source.Controls.Add(this.numericHeight);
            this.Source.Controls.Add(this.label12);
            this.Source.Controls.Add(this.numericX);
            this.Source.Controls.Add(this.label10);
            this.Source.Controls.Add(this.numericWidth);
            this.Source.Controls.Add(this.label9);
            this.Source.Controls.Add(this.numericY);
            this.Source.Location = new System.Drawing.Point(12, 12);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(260, 88);
            this.Source.TabIndex = 33;
            this.Source.TabStop = false;
            this.Source.Text = "Source";
            // 
            // Browse_Source_Map
            // 
            this.Browse_Source_Map.Location = new System.Drawing.Point(112, 16);
            this.Browse_Source_Map.Name = "Browse_Source_Map";
            this.Browse_Source_Map.Size = new System.Drawing.Size(75, 23);
            this.Browse_Source_Map.TabIndex = 35;
            this.Browse_Source_Map.Text = "Browse Map";
            this.Browse_Source_Map.UseVisualStyleBackColor = true;
            this.Browse_Source_Map.Click += new System.EventHandler(this.Browse_Source_Map_Click);
            // 
            // textBoxSourceMap
            // 
            this.textBoxSourceMap.Location = new System.Drawing.Point(6, 19);
            this.textBoxSourceMap.Name = "textBoxSourceMap";
            this.textBoxSourceMap.Size = new System.Drawing.Size(100, 20);
            this.textBoxSourceMap.TabIndex = 34;
            this.textBoxSourceMap.TextChanged += new System.EventHandler(this.textBoxSourceMap_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.xCoordinate);
            this.groupBox1.Controls.Add(this.Browse_Target_Map);
            this.groupBox1.Controls.Add(this.textBoxTargetMap);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 194);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customY);
            this.groupBox2.Controls.Add(this.playerY);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericTargetY);
            this.groupBox2.Location = new System.Drawing.Point(6, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 58);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y Coordinate";
            // 
            // customY
            // 
            this.customY.AutoSize = true;
            this.customY.Location = new System.Drawing.Point(97, 32);
            this.customY.Name = "customY";
            this.customY.Size = new System.Drawing.Size(70, 17);
            this.customY.TabIndex = 38;
            this.customY.TabStop = true;
            this.customY.Text = "Custom Y";
            this.customY.UseVisualStyleBackColor = true;
            this.customY.CheckedChanged += new System.EventHandler(this.customY_CheckedChanged);
            // 
            // playerY
            // 
            this.playerY.AutoSize = true;
            this.playerY.Location = new System.Drawing.Point(6, 32);
            this.playerY.Name = "playerY";
            this.playerY.Size = new System.Drawing.Size(64, 17);
            this.playerY.TabIndex = 37;
            this.playerY.TabStop = true;
            this.playerY.Text = "Player Y";
            this.playerY.UseVisualStyleBackColor = true;
            this.playerY.CheckedChanged += new System.EventHandler(this.playerY_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Y";
            // 
            // numericTargetY
            // 
            this.numericTargetY.Location = new System.Drawing.Point(207, 32);
            this.numericTargetY.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericTargetY.Name = "numericTargetY";
            this.numericTargetY.ReadOnly = true;
            this.numericTargetY.Size = new System.Drawing.Size(35, 20);
            this.numericTargetY.TabIndex = 25;
            this.numericTargetY.ValueChanged += new System.EventHandler(this.numericTargetY_ValueChanged);
            // 
            // xCoordinate
            // 
            this.xCoordinate.Controls.Add(this.customX);
            this.xCoordinate.Controls.Add(this.label1);
            this.xCoordinate.Controls.Add(this.playerX);
            this.xCoordinate.Controls.Add(this.numericTargetX);
            this.xCoordinate.Location = new System.Drawing.Point(6, 128);
            this.xCoordinate.Name = "xCoordinate";
            this.xCoordinate.Size = new System.Drawing.Size(248, 60);
            this.xCoordinate.TabIndex = 36;
            this.xCoordinate.TabStop = false;
            this.xCoordinate.Text = "X Coordinate";
            // 
            // customX
            // 
            this.customX.AutoSize = true;
            this.customX.Location = new System.Drawing.Point(97, 34);
            this.customX.Name = "customX";
            this.customX.Size = new System.Drawing.Size(70, 17);
            this.customX.TabIndex = 40;
            this.customX.TabStop = true;
            this.customX.Text = "Custom X";
            this.customX.UseVisualStyleBackColor = true;
            this.customX.CheckedChanged += new System.EventHandler(this.customX_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "X";
            // 
            // playerX
            // 
            this.playerX.AutoSize = true;
            this.playerX.Location = new System.Drawing.Point(6, 34);
            this.playerX.Name = "playerX";
            this.playerX.Size = new System.Drawing.Size(64, 17);
            this.playerX.TabIndex = 39;
            this.playerX.TabStop = true;
            this.playerX.Text = "Player X";
            this.playerX.UseVisualStyleBackColor = true;
            this.playerX.CheckedChanged += new System.EventHandler(this.playerX_CheckedChanged);
            // 
            // numericTargetX
            // 
            this.numericTargetX.Location = new System.Drawing.Point(207, 34);
            this.numericTargetX.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericTargetX.Name = "numericTargetX";
            this.numericTargetX.ReadOnly = true;
            this.numericTargetX.Size = new System.Drawing.Size(35, 20);
            this.numericTargetX.TabIndex = 30;
            this.numericTargetX.ValueChanged += new System.EventHandler(this.numericTargetX_ValueChanged);
            // 
            // Browse_Target_Map
            // 
            this.Browse_Target_Map.Location = new System.Drawing.Point(112, 16);
            this.Browse_Target_Map.Name = "Browse_Target_Map";
            this.Browse_Target_Map.Size = new System.Drawing.Size(75, 23);
            this.Browse_Target_Map.TabIndex = 35;
            this.Browse_Target_Map.Text = "Browse Map";
            this.Browse_Target_Map.UseVisualStyleBackColor = true;
            this.Browse_Target_Map.Click += new System.EventHandler(this.Browse_Target_Map_Click);
            // 
            // textBoxTargetMap
            // 
            this.textBoxTargetMap.Location = new System.Drawing.Point(6, 19);
            this.textBoxTargetMap.Name = "textBoxTargetMap";
            this.textBoxTargetMap.Size = new System.Drawing.Size(100, 20);
            this.textBoxTargetMap.TabIndex = 34;
            this.textBoxTargetMap.TextChanged += new System.EventHandler(this.textBoxTargetMap_TextChanged);
            // 
            // Create_Warp
            // 
            this.Create_Warp.Location = new System.Drawing.Point(12, 306);
            this.Create_Warp.Name = "Create_Warp";
            this.Create_Warp.Size = new System.Drawing.Size(106, 23);
            this.Create_Warp.TabIndex = 37;
            this.Create_Warp.Text = "Create Warp";
            this.Create_Warp.UseVisualStyleBackColor = true;
            this.Create_Warp.Click += new System.EventHandler(this.Create_Warp_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(166, 306);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(106, 23);
            this.Cancel.TabIndex = 38;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewWarp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Create_Warp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Source);
            this.Name = "NewWarp_Form";
            this.Text = "New Warp";
            this.Load += new System.EventHandler(this.NewWarp_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.Source.ResumeLayout(false);
            this.Source.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTargetY)).EndInit();
            this.xCoordinate.ResumeLayout(false);
            this.xCoordinate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTargetX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Source;
        private System.Windows.Forms.Button Browse_Source_Map;
        private System.Windows.Forms.TextBox textBoxSourceMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Browse_Target_Map;
        private System.Windows.Forms.TextBox textBoxTargetMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericTargetX;
        private System.Windows.Forms.NumericUpDown numericTargetY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox xCoordinate;
        private System.Windows.Forms.RadioButton customY;
        private System.Windows.Forms.RadioButton playerY;
        private System.Windows.Forms.RadioButton customX;
        private System.Windows.Forms.RadioButton playerX;
        private System.Windows.Forms.Button Create_Warp;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}