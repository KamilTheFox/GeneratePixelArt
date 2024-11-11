namespace GeneratePixelArt
{
    partial class Tree
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
            this.label1 = new System.Windows.Forms.Label();
            this.TypeBlockWood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeBlockLaves = new System.Windows.Forms.ComboBox();
            this.generate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.rangeBranchCount = new System.Windows.Forms.TextBox();
            this.rangeBranchCountLabel = new System.Windows.Forms.Label();
            this.rangeBranchLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rangeLeavesScale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Тип блока для дерева";
            // 
            // TypeBlockWood
            // 
            this.TypeBlockWood.FormattingEnabled = true;
            this.TypeBlockWood.Location = new System.Drawing.Point(11, 28);
            this.TypeBlockWood.Name = "TypeBlockWood";
            this.TypeBlockWood.Size = new System.Drawing.Size(168, 21);
            this.TypeBlockWood.TabIndex = 14;
            this.TypeBlockWood.SelectedIndexChanged += new System.EventHandler(this.TypeBlockWood_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Тип блока для Листвы";
            // 
            // TypeBlockLaves
            // 
            this.TypeBlockLaves.FormattingEnabled = true;
            this.TypeBlockLaves.Location = new System.Drawing.Point(11, 71);
            this.TypeBlockLaves.Name = "TypeBlockLaves";
            this.TypeBlockLaves.Size = new System.Drawing.Size(168, 21);
            this.TypeBlockLaves.TabIndex = 16;
            this.TypeBlockLaves.SelectedIndexChanged += new System.EventHandler(this.TypeBlockLaves_SelectedIndexChanged);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(15, 292);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(164, 23);
            this.generate.TabIndex = 18;
            this.generate.Text = "СГЕНЕРИРОВАТЬ";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Высота";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(11, 112);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(168, 20);
            this.height.TabIndex = 20;
            // 
            // rangeBranchCount
            // 
            this.rangeBranchCount.Location = new System.Drawing.Point(11, 152);
            this.rangeBranchCount.Name = "rangeBranchCount";
            this.rangeBranchCount.Size = new System.Drawing.Size(168, 20);
            this.rangeBranchCount.TabIndex = 22;
            // 
            // rangeBranchCountLabel
            // 
            this.rangeBranchCountLabel.AutoSize = true;
            this.rangeBranchCountLabel.Location = new System.Drawing.Point(12, 135);
            this.rangeBranchCountLabel.Name = "rangeBranchCountLabel";
            this.rangeBranchCountLabel.Size = new System.Drawing.Size(98, 13);
            this.rangeBranchCountLabel.TabIndex = 21;
            this.rangeBranchCountLabel.Text = "Количество веток";
            // 
            // rangeBranchLength
            // 
            this.rangeBranchLength.Location = new System.Drawing.Point(11, 192);
            this.rangeBranchLength.Name = "rangeBranchLength";
            this.rangeBranchLength.Size = new System.Drawing.Size(168, 20);
            this.rangeBranchLength.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Длина веток";
            // 
            // rangeLeavesScale
            // 
            this.rangeLeavesScale.Location = new System.Drawing.Point(11, 232);
            this.rangeLeavesScale.Name = "rangeLeavesScale";
            this.rangeLeavesScale.Size = new System.Drawing.Size(168, 20);
            this.rangeLeavesScale.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Размер листвы";
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 327);
            this.Controls.Add(this.rangeLeavesScale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rangeBranchLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rangeBranchCount);
            this.Controls.Add(this.rangeBranchCountLabel);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeBlockLaves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeBlockWood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tree";
            this.Text = "TreeGenerate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeBlockWood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeBlockLaves;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox rangeBranchCount;
        private System.Windows.Forms.Label rangeBranchCountLabel;
        private System.Windows.Forms.TextBox rangeBranchLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rangeLeavesScale;
        private System.Windows.Forms.Label label4;
    }
}