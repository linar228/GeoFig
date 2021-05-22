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
            this.label2 = new System.Windows.Forms.Label();
            this.Point3 = new System.Windows.Forms.Button();
            this.Point2 = new System.Windows.Forms.Button();
            this.Point1 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Board = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Figure";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Point3);
            this.panel1.Controls.Add(this.Point2);
            this.panel1.Controls.Add(this.Point1);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 114);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Draw mouse line and triangle";
            // 
            // Point3
            // 
            this.Point3.Location = new System.Drawing.Point(510, 86);
            this.Point3.Name = "Point3";
            this.Point3.Size = new System.Drawing.Size(75, 23);
            this.Point3.TabIndex = 21;
            this.Point3.Text = "Point 3";
            this.Point3.UseVisualStyleBackColor = true;
            this.Point3.Click += new System.EventHandler(this.Point3_Click);
            // 
            // Point2
            // 
            this.Point2.Location = new System.Drawing.Point(510, 57);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(75, 23);
            this.Point2.TabIndex = 20;
            this.Point2.Text = "Point 2";
            this.Point2.UseVisualStyleBackColor = true;
            this.Point2.Click += new System.EventHandler(this.Point2_Click);
            // 
            // Point1
            // 
            this.Point1.Location = new System.Drawing.Point(510, 30);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(75, 23);
            this.Point1.TabIndex = 19;
            this.Point1.Text = "Point 1";
            this.Point1.UseVisualStyleBackColor = true;
            this.Point1.Click += new System.EventHandler(this.Point1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(176, 57);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(394, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Open";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(394, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(213, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mouse Rectangle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mouse Circle";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseDown);
            this.radioButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseUp);
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.SystemColors.Window;
            this.Board.Location = new System.Drawing.Point(7, 126);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(782, 315);
            this.Board.TabIndex = 15;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            this.Board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Point3;
        private System.Windows.Forms.Button Point2;
        private System.Windows.Forms.Button Point1;
    }
}

