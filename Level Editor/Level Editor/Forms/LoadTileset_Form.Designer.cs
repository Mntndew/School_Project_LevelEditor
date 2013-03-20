namespace Level_Editor.Forms
{
    partial class LoadTileset_Form
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tile_Height = new System.Windows.Forms.NumericUpDown();
            this.tile_Width = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tile_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG files |*.png|All files|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 1;
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(95, 12);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 20);
            this.browse_button.TabIndex = 2;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(27, 112);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(75, 23);
            this.Load_button.TabIndex = 3;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Location = new System.Drawing.Point(112, 112);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 4;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tile_Height);
            this.groupBox2.Controls.Add(this.tile_Width);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile dimensions";
            // 
            // tile_Height
            // 
            this.tile_Height.Location = new System.Drawing.Point(122, 40);
            this.tile_Height.Name = "tile_Height";
            this.tile_Height.Size = new System.Drawing.Size(36, 20);
            this.tile_Height.TabIndex = 3;
            this.tile_Height.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.tile_Height.ValueChanged += new System.EventHandler(this.tile_Height_ValueChanged);
            // 
            // tile_Width
            // 
            this.tile_Width.Location = new System.Drawing.Point(122, 14);
            this.tile_Width.Name = "tile_Width";
            this.tile_Width.Size = new System.Drawing.Size(36, 20);
            this.tile_Width.TabIndex = 2;
            this.tile_Width.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.tile_Width.ValueChanged += new System.EventHandler(this.tile_Width_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tile height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tile width:";
            // 
            // LoadTileset_Form
            // 
            this.AcceptButton = this.Load_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(199, 141);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadTileset_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Tileset";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoadTileset_Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tile_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile_Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown tile_Height;
        private System.Windows.Forms.NumericUpDown tile_Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}