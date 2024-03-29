﻿namespace DVT_2020_L03_OpenGL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label_track = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonSaveImg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButtonSpin = new System.Windows.Forms.RadioButton();
            this.radioButtonCube = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Dot = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownRZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.UpDownCout = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Fov = new System.Windows.Forms.NumericUpDown();
            this.checkBox_dot = new System.Windows.Forms.CheckBox();
            this.checkBox_voxel = new System.Windows.Forms.CheckBox();
            this.checkBox_plane = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fov)).BeginInit();
            this.SuspendLayout();
            // 
            // label_track
            // 
            this.label_track.AutoSize = true;
            this.label_track.Location = new System.Drawing.Point(268, 166);
            this.label_track.Name = "label_track";
            this.label_track.Size = new System.Drawing.Size(13, 13);
            this.label_track.TabIndex = 74;
            this.label_track.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "X";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(16, 145);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(265, 45);
            this.trackBar1.TabIndex = 70;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonSaveImg
            // 
            this.buttonSaveImg.Location = new System.Drawing.Point(12, 372);
            this.buttonSaveImg.Name = "buttonSaveImg";
            this.buttonSaveImg.Size = new System.Drawing.Size(131, 26);
            this.buttonSaveImg.TabIndex = 69;
            this.buttonSaveImg.Text = "Сохранить картинку";
            this.buttonSaveImg.UseVisualStyleBackColor = true;
            this.buttonSaveImg.Click += new System.EventHandler(this.buttonSaveImg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Направление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Положение";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            // 
            // radioButtonSpin
            // 
            this.radioButtonSpin.AutoSize = true;
            this.radioButtonSpin.Location = new System.Drawing.Point(75, 19);
            this.radioButtonSpin.Name = "radioButtonSpin";
            this.radioButtonSpin.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSpin.TabIndex = 39;
            this.radioButtonSpin.TabStop = true;
            this.radioButtonSpin.Text = "Спирали";
            this.radioButtonSpin.UseVisualStyleBackColor = true;
            // 
            // radioButtonCube
            // 
            this.radioButtonCube.AutoSize = true;
            this.radioButtonCube.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCube.Name = "radioButtonCube";
            this.radioButtonCube.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCube.TabIndex = 38;
            this.radioButtonCube.TabStop = true;
            this.radioButtonCube.Text = "Куб";
            this.radioButtonCube.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Dot);
            this.groupBox2.Controls.Add(this.radioButtonSpin);
            this.groupBox2.Controls.Add(this.radioButtonCube);
            this.groupBox2.Location = new System.Drawing.Point(17, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 44);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фигура";
            // 
            // radioButton_Dot
            // 
            this.radioButton_Dot.AutoSize = true;
            this.radioButton_Dot.Location = new System.Drawing.Point(169, 19);
            this.radioButton_Dot.Name = "radioButton_Dot";
            this.radioButton_Dot.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Dot.TabIndex = 40;
            this.radioButton_Dot.TabStop = true;
            this.radioButton_Dot.Text = "Точка";
            this.radioButton_Dot.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Z";
            // 
            // numericUpDownRZ
            // 
            this.numericUpDownRZ.DecimalPlaces = 3;
            this.numericUpDownRZ.Location = new System.Drawing.Point(96, 277);
            this.numericUpDownRZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownRZ.Name = "numericUpDownRZ";
            this.numericUpDownRZ.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRZ.TabIndex = 64;
            // 
            // numericUpDownRY
            // 
            this.numericUpDownRY.DecimalPlaces = 3;
            this.numericUpDownRY.Location = new System.Drawing.Point(96, 245);
            this.numericUpDownRY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownRY.Name = "numericUpDownRY";
            this.numericUpDownRY.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRY.TabIndex = 63;
            // 
            // numericUpDownRX
            // 
            this.numericUpDownRX.DecimalPlaces = 3;
            this.numericUpDownRX.Location = new System.Drawing.Point(96, 213);
            this.numericUpDownRX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownRX.Name = "numericUpDownRX";
            this.numericUpDownRX.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRX.TabIndex = 62;
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.DecimalPlaces = 3;
            this.numericUpDownZ.Location = new System.Drawing.Point(27, 277);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownZ.TabIndex = 61;
            this.numericUpDownZ.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 3;
            this.numericUpDownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownY.Location = new System.Drawing.Point(27, 245);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownY.TabIndex = 60;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 3;
            this.numericUpDownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownX.Location = new System.Drawing.Point(27, 213);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownX.TabIndex = 59;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 44);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 26);
            this.buttonSave.TabIndex = 55;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 44);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(131, 26);
            this.buttonLoad.TabIndex = 54;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // UpDownCout
            // 
            this.UpDownCout.Location = new System.Drawing.Point(150, 17);
            this.UpDownCout.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.UpDownCout.Name = "UpDownCout";
            this.UpDownCout.Size = new System.Drawing.Size(120, 20);
            this.UpDownCout.TabIndex = 53;
            this.UpDownCout.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(131, 26);
            this.buttonGenerate.TabIndex = 52;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // openGLControl1
            // 
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(297, 12);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(600, 400);
            this.openGLControl1.TabIndex = 75;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl1_MouseDown);
            this.openGLControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl1_MouseMove);
            this.openGLControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Угол обзора";
            // 
            // numericUpDown_Fov
            // 
            this.numericUpDown_Fov.Location = new System.Drawing.Point(95, 303);
            this.numericUpDown_Fov.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numericUpDown_Fov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Fov.Name = "numericUpDown_Fov";
            this.numericUpDown_Fov.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_Fov.TabIndex = 76;
            this.numericUpDown_Fov.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // checkBox_dot
            // 
            this.checkBox_dot.AutoSize = true;
            this.checkBox_dot.Checked = true;
            this.checkBox_dot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_dot.Location = new System.Drawing.Point(17, 122);
            this.checkBox_dot.Name = "checkBox_dot";
            this.checkBox_dot.Size = new System.Drawing.Size(56, 17);
            this.checkBox_dot.TabIndex = 78;
            this.checkBox_dot.Text = "Точки";
            this.checkBox_dot.UseVisualStyleBackColor = true;
            // 
            // checkBox_voxel
            // 
            this.checkBox_voxel.AutoSize = true;
            this.checkBox_voxel.Location = new System.Drawing.Point(102, 122);
            this.checkBox_voxel.Name = "checkBox_voxel";
            this.checkBox_voxel.Size = new System.Drawing.Size(69, 17);
            this.checkBox_voxel.TabIndex = 79;
            this.checkBox_voxel.Text = "Воксили";
            this.checkBox_voxel.UseVisualStyleBackColor = true;
            // 
            // checkBox_plane
            // 
            this.checkBox_plane.AutoSize = true;
            this.checkBox_plane.Location = new System.Drawing.Point(200, 122);
            this.checkBox_plane.Name = "checkBox_plane";
            this.checkBox_plane.Size = new System.Drawing.Size(81, 17);
            this.checkBox_plane.TabIndex = 80;
            this.checkBox_plane.Text = "Плоскость";
            this.checkBox_plane.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.checkBox_plane);
            this.Controls.Add(this.checkBox_voxel);
            this.Controls.Add(this.checkBox_dot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Fov);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.label_track);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonSaveImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownRZ);
            this.Controls.Add(this.numericUpDownRY);
            this.Controls.Add(this.numericUpDownRX);
            this.Controls.Add(this.numericUpDownZ);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.UpDownCout);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Щербинин Григорий 201-325";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_track;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonSaveImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButtonSpin;
        private System.Windows.Forms.RadioButton radioButtonCube;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownRZ;
        private System.Windows.Forms.NumericUpDown numericUpDownRY;
        private System.Windows.Forms.NumericUpDown numericUpDownRX;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.NumericUpDown UpDownCout;
        private System.Windows.Forms.Button buttonGenerate;
        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.RadioButton radioButton_Dot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Fov;
        private System.Windows.Forms.CheckBox checkBox_dot;
        private System.Windows.Forms.CheckBox checkBox_voxel;
        private System.Windows.Forms.CheckBox checkBox_plane;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

