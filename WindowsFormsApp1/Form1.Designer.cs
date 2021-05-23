namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorBut = new System.Windows.Forms.Button();
            this.thicknessBar = new System.Windows.Forms.TrackBar();
            this.Point3 = new System.Windows.Forms.Button();
            this.Point2 = new System.Windows.Forms.Button();
            this.Point1 = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.OpenBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Board = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorLab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Figure";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ColorLab);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ColorBut);
            this.panel1.Controls.Add(this.thicknessBar);
            this.panel1.Controls.Add(this.Point3);
            this.panel1.Controls.Add(this.Point2);
            this.panel1.Controls.Add(this.Point1);
            this.panel1.Controls.Add(this.ClearBut);
            this.panel1.Controls.Add(this.OpenBut);
            this.panel1.Controls.Add(this.SaveBut);
            this.panel1.Controls.Add(this.Rectangle);
            this.panel1.Controls.Add(this.Circle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 114);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Thickness";
            // 
            // ColorBut
            // 
            this.ColorBut.Location = new System.Drawing.Point(486, 31);
            this.ColorBut.Name = "ColorBut";
            this.ColorBut.Size = new System.Drawing.Size(75, 23);
            this.ColorBut.TabIndex = 24;
            this.ColorBut.UseVisualStyleBackColor = true;
            this.ColorBut.Click += new System.EventHandler(this.Color_Click);
            // 
            // thicknessBar
            // 
            this.thicknessBar.Location = new System.Drawing.Point(365, 31);
            this.thicknessBar.Name = "thicknessBar";
            this.thicknessBar.Size = new System.Drawing.Size(104, 45);
            this.thicknessBar.TabIndex = 23;
            this.thicknessBar.Scroll += new System.EventHandler(this.thicknessBar_Scroll);
            // 
            // Point3
            // 
            this.Point3.Location = new System.Drawing.Point(259, 79);
            this.Point3.Name = "Point3";
            this.Point3.Size = new System.Drawing.Size(75, 23);
            this.Point3.TabIndex = 21;
            this.Point3.Text = "Point 3";
            this.Point3.UseVisualStyleBackColor = true;
            this.Point3.Click += new System.EventHandler(this.Point3_Click);
            // 
            // Point2
            // 
            this.Point2.Location = new System.Drawing.Point(259, 50);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(75, 23);
            this.Point2.TabIndex = 20;
            this.Point2.Text = "Point 2";
            this.Point2.UseVisualStyleBackColor = true;
            this.Point2.Click += new System.EventHandler(this.Point2_Click);
            // 
            // Point1
            // 
            this.Point1.Location = new System.Drawing.Point(259, 21);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(75, 23);
            this.Point1.TabIndex = 19;
            this.Point1.Text = "Point 1";
            this.Point1.UseVisualStyleBackColor = true;
            this.Point1.Click += new System.EventHandler(this.Point1_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(378, 79);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(75, 23);
            this.ClearBut.TabIndex = 18;
            this.ClearBut.Text = "Clear";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenBut
            // 
            this.OpenBut.Location = new System.Drawing.Point(486, 86);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(75, 23);
            this.OpenBut.TabIndex = 17;
            this.OpenBut.Text = "Open";
            this.OpenBut.UseVisualStyleBackColor = true;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.Location = new System.Drawing.Point(486, 57);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(75, 23);
            this.SaveBut.TabIndex = 16;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(149, 59);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(74, 17);
            this.Rectangle.TabIndex = 15;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(162, 31);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(51, 17);
            this.Circle.TabIndex = 14;
            this.Circle.TabStop = true;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Circle_MouseDown);
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.SystemColors.Window;
            this.Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Board.Location = new System.Drawing.Point(0, 114);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(800, 336);
            this.Board.TabIndex = 15;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            this.Board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_MouseDown);
            this.Board.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Board_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ColorLab
            // 
            this.ColorLab.AutoSize = true;
            this.ColorLab.Location = new System.Drawing.Point(505, 11);
            this.ColorLab.Name = "ColorLab";
            this.ColorLab.Size = new System.Drawing.Size(31, 13);
            this.ColorLab.TabIndex = 26;
            this.ColorLab.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenBut;
        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.Button Point3;
        private System.Windows.Forms.Button Point2;
        private System.Windows.Forms.Button Point1;
        private System.Windows.Forms.TrackBar thicknessBar;
        private System.Windows.Forms.Button ColorBut;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ColorLab;
    }
}

