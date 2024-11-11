namespace GeneratePixelArt
{
    partial class GeneratorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorsForm));
            this.treeGenerator = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plane = new System.Windows.Forms.CheckBox();
            this.celindr = new System.Windows.Forms.CheckBox();
            this.NameGroup = new System.Windows.Forms.Label();
            this.sphere = new System.Windows.Forms.CheckBox();
            this.rotates = new System.Windows.Forms.CheckBox();
            this.spherePanel = new System.Windows.Forms.Panel();
            this.TypeBlock = new System.Windows.Forms.ComboBox();
            this.generateSphere = new System.Windows.Forms.Button();
            this.radiusTextSphere = new System.Windows.Forms.TextBox();
            this.fillSphere = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.planePanel = new System.Windows.Forms.Panel();
            this.FillPlane = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PlaneZ = new System.Windows.Forms.TextBox();
            this.PlaneY = new System.Windows.Forms.TextBox();
            this.PlaneX = new System.Windows.Forms.TextBox();
            this.TypeBlockPlane = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.celindrPanel = new System.Windows.Forms.Panel();
            this.fillCelindr = new System.Windows.Forms.CheckBox();
            this.HeightCelindr = new System.Windows.Forms.TextBox();
            this.generateCelindr = new System.Windows.Forms.Button();
            this.TypeBlockCelindr = new System.Windows.Forms.ComboBox();
            this.radiusCelindr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rotateMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSpoof = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.spoof = new System.Windows.Forms.CheckBox();
            this.rotX = new System.Windows.Forms.CheckBox();
            this.rotY = new System.Windows.Forms.CheckBox();
            this.rotZ = new System.Windows.Forms.CheckBox();
            this.rot90 = new System.Windows.Forms.CheckBox();
            this.ReadBuild = new System.Windows.Forms.Button();
            this.SaveRotate = new System.Windows.Forms.Button();
            this.BlockTypeSpoof = new System.Windows.Forms.ComboBox();
            this.BlockTypeSpoof2 = new System.Windows.Forms.ComboBox();
            this.SaveSpoof = new System.Windows.Forms.Button();
            this.ReadSpoof = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.spherePanel.SuspendLayout();
            this.planePanel.SuspendLayout();
            this.celindrPanel.SuspendLayout();
            this.rotateMenu.SuspendLayout();
            this.panelSpoof.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeGenerator
            // 
            this.treeGenerator.Location = new System.Drawing.Point(3, 21);
            this.treeGenerator.Name = "treeGenerator";
            this.treeGenerator.Size = new System.Drawing.Size(118, 23);
            this.treeGenerator.TabIndex = 0;
            this.treeGenerator.Text = "Деревья";
            this.treeGenerator.UseVisualStyleBackColor = true;
            this.treeGenerator.Click += new System.EventHandler(this.startGenerateTree);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.spoof);
            this.panel1.Controls.Add(this.plane);
            this.panel1.Controls.Add(this.celindr);
            this.panel1.Controls.Add(this.NameGroup);
            this.panel1.Controls.Add(this.rotates);
            this.panel1.Controls.Add(this.treeGenerator);
            this.panel1.Controls.Add(this.sphere);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 174);
            this.panel1.TabIndex = 1;
            // 
            // plane
            // 
            this.plane.AutoSize = true;
            this.plane.Location = new System.Drawing.Point(8, 96);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(112, 17);
            this.plane.TabIndex = 4;
            this.plane.Text = "Прямоугольники";
            this.plane.UseVisualStyleBackColor = true;
            // 
            // celindr
            // 
            this.celindr.AutoSize = true;
            this.celindr.Location = new System.Drawing.Point(8, 73);
            this.celindr.Name = "celindr";
            this.celindr.Size = new System.Drawing.Size(78, 17);
            this.celindr.TabIndex = 5;
            this.celindr.Text = "Целиндры";
            this.celindr.UseVisualStyleBackColor = true;
            // 
            // NameGroup
            // 
            this.NameGroup.AutoSize = true;
            this.NameGroup.Location = new System.Drawing.Point(22, 5);
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.Size = new System.Drawing.Size(68, 13);
            this.NameGroup.TabIndex = 1;
            this.NameGroup.Text = "Генераторы";
            // 
            // sphere
            // 
            this.sphere.AutoSize = true;
            this.sphere.Location = new System.Drawing.Point(8, 50);
            this.sphere.Name = "sphere";
            this.sphere.Size = new System.Drawing.Size(61, 17);
            this.sphere.TabIndex = 2;
            this.sphere.Text = "Сферы";
            this.sphere.UseVisualStyleBackColor = true;
            // 
            // rotates
            // 
            this.rotates.AutoSize = true;
            this.rotates.Location = new System.Drawing.Point(8, 122);
            this.rotates.Name = "rotates";
            this.rotates.Size = new System.Drawing.Size(77, 17);
            this.rotates.TabIndex = 3;
            this.rotates.Text = "Повороты";
            this.rotates.UseVisualStyleBackColor = true;
            // 
            // spherePanel
            // 
            this.spherePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.spherePanel.Controls.Add(this.TypeBlock);
            this.spherePanel.Controls.Add(this.generateSphere);
            this.spherePanel.Controls.Add(this.radiusTextSphere);
            this.spherePanel.Controls.Add(this.fillSphere);
            this.spherePanel.Controls.Add(this.label1);
            this.spherePanel.Location = new System.Drawing.Point(153, 12);
            this.spherePanel.Name = "spherePanel";
            this.spherePanel.Size = new System.Drawing.Size(126, 126);
            this.spherePanel.TabIndex = 6;
            // 
            // TypeBlock
            // 
            this.TypeBlock.FormattingEnabled = true;
            this.TypeBlock.Location = new System.Drawing.Point(4, 73);
            this.TypeBlock.Name = "TypeBlock";
            this.TypeBlock.Size = new System.Drawing.Size(119, 21);
            this.TypeBlock.TabIndex = 17;
            this.TypeBlock.SelectedIndexChanged += new System.EventHandler(this.TypeBlock_SelectedIndexChanged);
            // 
            // generateSphere
            // 
            this.generateSphere.Location = new System.Drawing.Point(4, 100);
            this.generateSphere.Name = "generateSphere";
            this.generateSphere.Size = new System.Drawing.Size(119, 23);
            this.generateSphere.TabIndex = 4;
            this.generateSphere.Text = "Сгенерировать";
            this.generateSphere.UseVisualStyleBackColor = true;
            this.generateSphere.Click += new System.EventHandler(this.generateSphere_Click);
            // 
            // radiusTextSphere
            // 
            this.radiusTextSphere.Location = new System.Drawing.Point(4, 50);
            this.radiusTextSphere.Name = "radiusTextSphere";
            this.radiusTextSphere.Size = new System.Drawing.Size(119, 20);
            this.radiusTextSphere.TabIndex = 3;
            this.radiusTextSphere.Text = "Радиус: ";
            this.radiusTextSphere.TextChanged += new System.EventHandler(this.radiusTextSphere_TextChanged);
            // 
            // fillSphere
            // 
            this.fillSphere.AutoSize = true;
            this.fillSphere.Location = new System.Drawing.Point(4, 26);
            this.fillSphere.Name = "fillSphere";
            this.fillSphere.Size = new System.Drawing.Size(95, 17);
            this.fillSphere.TabIndex = 2;
            this.fillSphere.Text = "Заполненный";
            this.fillSphere.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сферы";
            // 
            // planePanel
            // 
            this.planePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.planePanel.Controls.Add(this.FillPlane);
            this.planePanel.Controls.Add(this.button1);
            this.planePanel.Controls.Add(this.PlaneZ);
            this.planePanel.Controls.Add(this.PlaneY);
            this.planePanel.Controls.Add(this.PlaneX);
            this.planePanel.Controls.Add(this.TypeBlockPlane);
            this.planePanel.Controls.Add(this.label3);
            this.planePanel.Location = new System.Drawing.Point(153, 12);
            this.planePanel.Name = "planePanel";
            this.planePanel.Size = new System.Drawing.Size(126, 167);
            this.planePanel.TabIndex = 7;
            // 
            // FillPlane
            // 
            this.FillPlane.AutoSize = true;
            this.FillPlane.Location = new System.Drawing.Point(8, 44);
            this.FillPlane.Name = "FillPlane";
            this.FillPlane.Size = new System.Drawing.Size(80, 17);
            this.FillPlane.TabIndex = 23;
            this.FillPlane.Text = "Заполнить";
            this.FillPlane.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlaneZ
            // 
            this.PlaneZ.Location = new System.Drawing.Point(6, 119);
            this.PlaneZ.Name = "PlaneZ";
            this.PlaneZ.Size = new System.Drawing.Size(119, 20);
            this.PlaneZ.TabIndex = 22;
            this.PlaneZ.Text = "Z: ";
            this.PlaneZ.TextChanged += new System.EventHandler(this.PnaneZ_TextChanged);
            // 
            // PlaneY
            // 
            this.PlaneY.Location = new System.Drawing.Point(6, 93);
            this.PlaneY.Name = "PlaneY";
            this.PlaneY.Size = new System.Drawing.Size(119, 20);
            this.PlaneY.TabIndex = 21;
            this.PlaneY.Text = "Y: ";
            this.PlaneY.TextChanged += new System.EventHandler(this.PlaneY_TextChanged);
            // 
            // PlaneX
            // 
            this.PlaneX.Location = new System.Drawing.Point(5, 67);
            this.PlaneX.Name = "PlaneX";
            this.PlaneX.Size = new System.Drawing.Size(119, 20);
            this.PlaneX.TabIndex = 20;
            this.PlaneX.Text = "X: ";
            this.PlaneX.TextChanged += new System.EventHandler(this.PlaneX_TextChanged);
            // 
            // TypeBlockPlane
            // 
            this.TypeBlockPlane.FormattingEnabled = true;
            this.TypeBlockPlane.Location = new System.Drawing.Point(4, 21);
            this.TypeBlockPlane.Name = "TypeBlockPlane";
            this.TypeBlockPlane.Size = new System.Drawing.Size(119, 21);
            this.TypeBlockPlane.TabIndex = 18;
            this.TypeBlockPlane.SelectedIndexChanged += new System.EventHandler(this.TypeBlockPlane_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Прямоугольники";
            // 
            // celindrPanel
            // 
            this.celindrPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.celindrPanel.Controls.Add(this.fillCelindr);
            this.celindrPanel.Controls.Add(this.HeightCelindr);
            this.celindrPanel.Controls.Add(this.generateCelindr);
            this.celindrPanel.Controls.Add(this.TypeBlockCelindr);
            this.celindrPanel.Controls.Add(this.radiusCelindr);
            this.celindrPanel.Controls.Add(this.label4);
            this.celindrPanel.Location = new System.Drawing.Point(153, 12);
            this.celindrPanel.Name = "celindrPanel";
            this.celindrPanel.Size = new System.Drawing.Size(126, 152);
            this.celindrPanel.TabIndex = 7;
            // 
            // fillCelindr
            // 
            this.fillCelindr.AutoSize = true;
            this.fillCelindr.Location = new System.Drawing.Point(4, 21);
            this.fillCelindr.Name = "fillCelindr";
            this.fillCelindr.Size = new System.Drawing.Size(95, 17);
            this.fillCelindr.TabIndex = 18;
            this.fillCelindr.Text = "Заполненный";
            this.fillCelindr.UseVisualStyleBackColor = true;
            // 
            // HeightCelindr
            // 
            this.HeightCelindr.Location = new System.Drawing.Point(4, 70);
            this.HeightCelindr.Name = "HeightCelindr";
            this.HeightCelindr.Size = new System.Drawing.Size(119, 20);
            this.HeightCelindr.TabIndex = 19;
            this.HeightCelindr.Text = "Высота: ";
            this.HeightCelindr.TextChanged += new System.EventHandler(this.HeightCelindr_TextChanged);
            // 
            // generateCelindr
            // 
            this.generateCelindr.Location = new System.Drawing.Point(3, 123);
            this.generateCelindr.Name = "generateCelindr";
            this.generateCelindr.Size = new System.Drawing.Size(120, 23);
            this.generateCelindr.TabIndex = 18;
            this.generateCelindr.Text = "Сгенерировать";
            this.generateCelindr.UseVisualStyleBackColor = true;
            this.generateCelindr.Click += new System.EventHandler(this.generateCelindr_Click);
            // 
            // TypeBlockCelindr
            // 
            this.TypeBlockCelindr.FormattingEnabled = true;
            this.TypeBlockCelindr.Location = new System.Drawing.Point(4, 96);
            this.TypeBlockCelindr.Name = "TypeBlockCelindr";
            this.TypeBlockCelindr.Size = new System.Drawing.Size(119, 21);
            this.TypeBlockCelindr.TabIndex = 18;
            this.TypeBlockCelindr.SelectedIndexChanged += new System.EventHandler(this.TypeBlockCelindr_SelectedIndexChanged);
            // 
            // radiusCelindr
            // 
            this.radiusCelindr.Location = new System.Drawing.Point(4, 44);
            this.radiusCelindr.Name = "radiusCelindr";
            this.radiusCelindr.Size = new System.Drawing.Size(119, 20);
            this.radiusCelindr.TabIndex = 18;
            this.radiusCelindr.Text = "Радиус: ";
            this.radiusCelindr.TextChanged += new System.EventHandler(this.radiusCelindr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Целиндры";
            // 
            // rotateMenu
            // 
            this.rotateMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rotateMenu.Controls.Add(this.SaveRotate);
            this.rotateMenu.Controls.Add(this.ReadBuild);
            this.rotateMenu.Controls.Add(this.rot90);
            this.rotateMenu.Controls.Add(this.rotZ);
            this.rotateMenu.Controls.Add(this.rotY);
            this.rotateMenu.Controls.Add(this.rotX);
            this.rotateMenu.Controls.Add(this.label2);
            this.rotateMenu.Location = new System.Drawing.Point(153, 12);
            this.rotateMenu.Name = "rotateMenu";
            this.rotateMenu.Size = new System.Drawing.Size(126, 167);
            this.rotateMenu.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Повороты";
            // 
            // panelSpoof
            // 
            this.panelSpoof.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSpoof.Controls.Add(this.SaveSpoof);
            this.panelSpoof.Controls.Add(this.BlockTypeSpoof2);
            this.panelSpoof.Controls.Add(this.ReadSpoof);
            this.panelSpoof.Controls.Add(this.BlockTypeSpoof);
            this.panelSpoof.Controls.Add(this.label6);
            this.panelSpoof.Location = new System.Drawing.Point(152, 12);
            this.panelSpoof.Name = "panelSpoof";
            this.panelSpoof.Size = new System.Drawing.Size(126, 167);
            this.panelSpoof.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Замена";
            // 
            // spoof
            // 
            this.spoof.AutoSize = true;
            this.spoof.Location = new System.Drawing.Point(8, 145);
            this.spoof.Name = "spoof";
            this.spoof.Size = new System.Drawing.Size(98, 17);
            this.spoof.TabIndex = 6;
            this.spoof.Text = "Замена блока";
            this.spoof.UseVisualStyleBackColor = true;
            // 
            // rotX
            // 
            this.rotX.AutoSize = true;
            this.rotX.Location = new System.Drawing.Point(8, 53);
            this.rotX.Name = "rotX";
            this.rotX.Size = new System.Drawing.Size(33, 17);
            this.rotX.TabIndex = 7;
            this.rotX.Text = "X";
            this.rotX.UseVisualStyleBackColor = true;
            // 
            // rotY
            // 
            this.rotY.AutoSize = true;
            this.rotY.Location = new System.Drawing.Point(8, 73);
            this.rotY.Name = "rotY";
            this.rotY.Size = new System.Drawing.Size(33, 17);
            this.rotY.TabIndex = 8;
            this.rotY.Text = "Y";
            this.rotY.UseVisualStyleBackColor = true;
            // 
            // rotZ
            // 
            this.rotZ.AutoSize = true;
            this.rotZ.Location = new System.Drawing.Point(8, 93);
            this.rotZ.Name = "rotZ";
            this.rotZ.Size = new System.Drawing.Size(33, 17);
            this.rotZ.TabIndex = 9;
            this.rotZ.Text = "Z";
            this.rotZ.UseVisualStyleBackColor = true;
            // 
            // rot90
            // 
            this.rot90.AutoSize = true;
            this.rot90.Location = new System.Drawing.Point(8, 116);
            this.rot90.Name = "rot90";
            this.rot90.Size = new System.Drawing.Size(42, 17);
            this.rot90.TabIndex = 10;
            this.rot90.Text = "90*";
            this.rot90.UseVisualStyleBackColor = true;
            // 
            // ReadBuild
            // 
            this.ReadBuild.Location = new System.Drawing.Point(3, 24);
            this.ReadBuild.Name = "ReadBuild";
            this.ReadBuild.Size = new System.Drawing.Size(120, 23);
            this.ReadBuild.TabIndex = 11;
            this.ReadBuild.Text = "Выбрать постройку";
            this.ReadBuild.UseVisualStyleBackColor = true;
            this.ReadBuild.Click += new System.EventHandler(this.ReadBuild_Click);
            // 
            // SaveRotate
            // 
            this.SaveRotate.Location = new System.Drawing.Point(4, 132);
            this.SaveRotate.Name = "SaveRotate";
            this.SaveRotate.Size = new System.Drawing.Size(120, 23);
            this.SaveRotate.TabIndex = 12;
            this.SaveRotate.Text = "Сохранить";
            this.SaveRotate.UseVisualStyleBackColor = true;
            this.SaveRotate.Click += new System.EventHandler(this.SaveRotate_Click);
            // 
            // BlockTypeSpoof
            // 
            this.BlockTypeSpoof.FormattingEnabled = true;
            this.BlockTypeSpoof.Location = new System.Drawing.Point(3, 51);
            this.BlockTypeSpoof.Name = "BlockTypeSpoof";
            this.BlockTypeSpoof.Size = new System.Drawing.Size(119, 21);
            this.BlockTypeSpoof.TabIndex = 25;
            // 
            // BlockTypeSpoof2
            // 
            this.BlockTypeSpoof2.FormattingEnabled = true;
            this.BlockTypeSpoof2.Location = new System.Drawing.Point(3, 78);
            this.BlockTypeSpoof2.Name = "BlockTypeSpoof2";
            this.BlockTypeSpoof2.Size = new System.Drawing.Size(119, 21);
            this.BlockTypeSpoof2.TabIndex = 26;
            // 
            // SaveSpoof
            // 
            this.SaveSpoof.Location = new System.Drawing.Point(3, 105);
            this.SaveSpoof.Name = "SaveSpoof";
            this.SaveSpoof.Size = new System.Drawing.Size(120, 23);
            this.SaveSpoof.TabIndex = 14;
            this.SaveSpoof.Text = "Сохранить";
            this.SaveSpoof.UseVisualStyleBackColor = true;
            this.SaveSpoof.Click += new System.EventHandler(this.SaveSpoof_Click);
            // 
            // ReadSpoof
            // 
            this.ReadSpoof.Location = new System.Drawing.Point(3, 24);
            this.ReadSpoof.Name = "ReadSpoof";
            this.ReadSpoof.Size = new System.Drawing.Size(120, 23);
            this.ReadSpoof.TabIndex = 13;
            this.ReadSpoof.Text = "Выбрать постройку";
            this.ReadSpoof.UseVisualStyleBackColor = true;
            this.ReadSpoof.Click += new System.EventHandler(this.ReadSpoof_Click);
            // 
            // GeneratorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(288, 315);
            this.Controls.Add(this.panelSpoof);
            this.Controls.Add(this.rotateMenu);
            this.Controls.Add(this.planePanel);
            this.Controls.Add(this.celindrPanel);
            this.Controls.Add(this.spherePanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeneratorsForm";
            this.Text = "GeneratorsForm";
            this.Load += new System.EventHandler(this.GeneratorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spherePanel.ResumeLayout(false);
            this.spherePanel.PerformLayout();
            this.planePanel.ResumeLayout(false);
            this.planePanel.PerformLayout();
            this.celindrPanel.ResumeLayout(false);
            this.celindrPanel.PerformLayout();
            this.rotateMenu.ResumeLayout(false);
            this.rotateMenu.PerformLayout();
            this.panelSpoof.ResumeLayout(false);
            this.panelSpoof.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button treeGenerator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox plane;
        private System.Windows.Forms.CheckBox celindr;
        private System.Windows.Forms.CheckBox rotates;
        private System.Windows.Forms.Label NameGroup;
        private System.Windows.Forms.CheckBox sphere;
        private System.Windows.Forms.Panel spherePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel planePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel celindrPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox radiusTextSphere;
        private System.Windows.Forms.CheckBox fillSphere;
        private System.Windows.Forms.Button generateSphere;
        private System.Windows.Forms.ComboBox TypeBlock;
        private System.Windows.Forms.CheckBox fillCelindr;
        private System.Windows.Forms.TextBox HeightCelindr;
        private System.Windows.Forms.Button generateCelindr;
        private System.Windows.Forms.ComboBox TypeBlockCelindr;
        private System.Windows.Forms.TextBox radiusCelindr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PlaneZ;
        private System.Windows.Forms.TextBox PlaneY;
        private System.Windows.Forms.TextBox PlaneX;
        private System.Windows.Forms.ComboBox TypeBlockPlane;
        private System.Windows.Forms.CheckBox FillPlane;
        private System.Windows.Forms.Panel rotateMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox spoof;
        private System.Windows.Forms.Panel panelSpoof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveRotate;
        private System.Windows.Forms.Button ReadBuild;
        private System.Windows.Forms.CheckBox rot90;
        private System.Windows.Forms.CheckBox rotZ;
        private System.Windows.Forms.CheckBox rotY;
        private System.Windows.Forms.CheckBox rotX;
        private System.Windows.Forms.ComboBox BlockTypeSpoof;
        private System.Windows.Forms.ComboBox BlockTypeSpoof2;
        private System.Windows.Forms.Button SaveSpoof;
        private System.Windows.Forms.Button ReadSpoof;
    }
}