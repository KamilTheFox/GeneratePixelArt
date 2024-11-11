namespace GeneratePixelArt
{
    partial class PixelArtMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OpenBitMap = new System.Windows.Forms.Button();
            this.SaveArt = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.interpolationMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compositingQuality = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.smoothingMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pixelOffsetMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeDithering = new System.Windows.Forms.ComboBox();
            this.rotateToZ = new System.Windows.Forms.CheckBox();
            this.isInverter = new System.Windows.Forms.CheckBox();
            this.Generators = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(589, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // OpenBitMap
            // 
            this.OpenBitMap.Location = new System.Drawing.Point(13, 13);
            this.OpenBitMap.Name = "OpenBitMap";
            this.OpenBitMap.Size = new System.Drawing.Size(167, 23);
            this.OpenBitMap.TabIndex = 2;
            this.OpenBitMap.Text = "ОТКРЫТЬ ИЗОБРАЖЕНИЕ";
            this.OpenBitMap.UseVisualStyleBackColor = true;
            this.OpenBitMap.Click += new System.EventHandler(this.OpenBitMap_Click);
            // 
            // SaveArt
            // 
            this.SaveArt.Location = new System.Drawing.Point(13, 95);
            this.SaveArt.Name = "SaveArt";
            this.SaveArt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveArt.Size = new System.Drawing.Size(167, 23);
            this.SaveArt.TabIndex = 3;
            this.SaveArt.Text = "СОХРАНИТЬ";
            this.SaveArt.UseVisualStyleBackColor = true;
            this.SaveArt.Click += new System.EventHandler(this.SaveArt_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(13, 66);
            this.Convert.Name = "Convert";
            this.Convert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Convert.Size = new System.Drawing.Size(167, 23);
            this.Convert.TabIndex = 4;
            this.Convert.Text = "КОНВЕРТИРОВАТЬ";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(13, 40);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(82, 20);
            this.Width.TabIndex = 5;
            this.Width.Text = "Width";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(94, 40);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(86, 20);
            this.Height.TabIndex = 6;
            this.Height.Text = "Height";
            // 
            // interpolationMode
            // 
            this.interpolationMode.FormattingEnabled = true;
            this.interpolationMode.Location = new System.Drawing.Point(11, 140);
            this.interpolationMode.Name = "interpolationMode";
            this.interpolationMode.Size = new System.Drawing.Size(168, 21);
            this.interpolationMode.TabIndex = 8;
            this.interpolationMode.SelectedIndexChanged += new System.EventHandler(this.interpolationMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "InterpolationMode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CompositingQuality";
            // 
            // compositingQuality
            // 
            this.compositingQuality.FormattingEnabled = true;
            this.compositingQuality.Location = new System.Drawing.Point(11, 183);
            this.compositingQuality.Name = "compositingQuality";
            this.compositingQuality.Size = new System.Drawing.Size(168, 21);
            this.compositingQuality.TabIndex = 14;
            this.compositingQuality.SelectedIndexChanged += new System.EventHandler(this.compositingQuality_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "SmoothingMode";
            // 
            // smoothingMode
            // 
            this.smoothingMode.FormattingEnabled = true;
            this.smoothingMode.Location = new System.Drawing.Point(11, 226);
            this.smoothingMode.Name = "smoothingMode";
            this.smoothingMode.Size = new System.Drawing.Size(168, 21);
            this.smoothingMode.TabIndex = 16;
            this.smoothingMode.SelectedIndexChanged += new System.EventHandler(this.smoothingMode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PixelOffsetMode";
            // 
            // pixelOffsetMode
            // 
            this.pixelOffsetMode.FormattingEnabled = true;
            this.pixelOffsetMode.Location = new System.Drawing.Point(11, 269);
            this.pixelOffsetMode.Name = "pixelOffsetMode";
            this.pixelOffsetMode.Size = new System.Drawing.Size(168, 21);
            this.pixelOffsetMode.TabIndex = 18;
            this.pixelOffsetMode.SelectedIndexChanged += new System.EventHandler(this.pixelOffsetMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "TypeDithering";
            // 
            // typeDithering
            // 
            this.typeDithering.FormattingEnabled = true;
            this.typeDithering.Location = new System.Drawing.Point(11, 312);
            this.typeDithering.Name = "typeDithering";
            this.typeDithering.Size = new System.Drawing.Size(168, 21);
            this.typeDithering.TabIndex = 20;
            this.typeDithering.SelectedIndexChanged += new System.EventHandler(this.typeDithering_SelectedIndexChanged);
            // 
            // rotateToZ
            // 
            this.rotateToZ.AutoSize = true;
            this.rotateToZ.Location = new System.Drawing.Point(11, 340);
            this.rotateToZ.Name = "rotateToZ";
            this.rotateToZ.Size = new System.Drawing.Size(161, 17);
            this.rotateToZ.TabIndex = 22;
            this.rotateToZ.Text = "Повернуть на плоскость Z";
            this.rotateToZ.UseVisualStyleBackColor = true;
            // 
            // isInverter
            // 
            this.isInverter.AutoSize = true;
            this.isInverter.Location = new System.Drawing.Point(11, 363);
            this.isInverter.Name = "isInverter";
            this.isInverter.Size = new System.Drawing.Size(104, 17);
            this.isInverter.TabIndex = 23;
            this.isInverter.Text = "Инвертировать";
            this.isInverter.UseVisualStyleBackColor = true;
            // 
            // Generators
            // 
            this.Generators.Location = new System.Drawing.Point(11, 388);
            this.Generators.Name = "Generators";
            this.Generators.Size = new System.Drawing.Size(168, 23);
            this.Generators.TabIndex = 24;
            this.Generators.Text = "Генераторы";
            this.Generators.UseVisualStyleBackColor = true;
            this.Generators.Click += new System.EventHandler(this.TreeGenerate_Click);
            // 
            // PixelArtMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 427);
            this.Controls.Add(this.Generators);
            this.Controls.Add(this.isInverter);
            this.Controls.Add(this.rotateToZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeDithering);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pixelOffsetMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smoothingMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compositingQuality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interpolationMode);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.SaveArt);
            this.Controls.Add(this.OpenBitMap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PixelArtMenu";
            this.Text = "GeneratorPixelArt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button OpenBitMap;
        private System.Windows.Forms.Button SaveArt;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.ComboBox interpolationMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox compositingQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox smoothingMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pixelOffsetMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeDithering;
        private System.Windows.Forms.CheckBox rotateToZ;
        private System.Windows.Forms.CheckBox isInverter;
        private System.Windows.Forms.Button Generators;
    }
}

