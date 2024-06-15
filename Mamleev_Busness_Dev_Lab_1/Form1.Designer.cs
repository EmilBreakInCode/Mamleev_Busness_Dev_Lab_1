namespace Mamleev_Busness_Dev_Lab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            PointsNumericUpDown = new NumericUpDown();
            TensitionNumericUpDown = new NumericUpDown();
            FontButton = new Button();
            GraphicButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            fontDialog1 = new FontDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PointsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TensitionNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(249, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 231);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PointsNumericUpDown
            // 
            PointsNumericUpDown.Location = new Point(123, 70);
            PointsNumericUpDown.Name = "PointsNumericUpDown";
            PointsNumericUpDown.Size = new Size(120, 23);
            PointsNumericUpDown.TabIndex = 1;
            // 
            // TensitionNumericUpDown
            // 
            TensitionNumericUpDown.DecimalPlaces = 1;
            TensitionNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            TensitionNumericUpDown.Location = new Point(123, 99);
            TensitionNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            TensitionNumericUpDown.Name = "TensitionNumericUpDown";
            TensitionNumericUpDown.Size = new Size(120, 23);
            TensitionNumericUpDown.TabIndex = 2;
            // 
            // FontButton
            // 
            FontButton.Location = new Point(112, 249);
            FontButton.Name = "FontButton";
            FontButton.Size = new Size(131, 23);
            FontButton.TabIndex = 3;
            FontButton.Text = "Выбрать шрифт";
            FontButton.UseVisualStyleBackColor = true;
            FontButton.Click += FontButton_Click;
            // 
            // GraphicButton
            // 
            GraphicButton.Location = new Point(112, 278);
            GraphicButton.Name = "GraphicButton";
            GraphicButton.Size = new Size(131, 23);
            GraphicButton.TabIndex = 4;
            GraphicButton.Text = "Нарисовать график";
            GraphicButton.UseVisualStyleBackColor = true;
            GraphicButton.Click += GraphicButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(641, 307);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(451, 22);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 6;
            label1.Text = "График";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 7;
            label2.Text = "Число точек =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 99);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 8;
            label3.Text = "Упругость =";
            // 
            // fontDialog1
            // 
            fontDialog1.ShowColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(GraphicButton);
            Controls.Add(FontButton);
            Controls.Add(TensitionNumericUpDown);
            Controls.Add(PointsNumericUpDown);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "График функции";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PointsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TensitionNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown PointsNumericUpDown;
        private NumericUpDown TensitionNumericUpDown;
        private Button FontButton;
        private Button GraphicButton;
        private Button ExitButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontDialog fontDialog1;
    }
}
