

namespace Lab3_Oganyan
{
    partial class Form1
    {
        
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
            this.gLControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glControl2 = new OpenTK.GLControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gLControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            this.SuspendLayout();
            // 
            // gLControlBindingSource
            // 
            this.gLControlBindingSource.DataSource = typeof(OpenTK.GLControl);
            // 
            // gLBindingSource
            // 
            this.gLBindingSource.DataSource = typeof(OpenTK.Graphics.ES30.GL);
            // 
            // glControl2
            // 
            this.glControl2.BackColor = System.Drawing.Color.Black;
            this.glControl2.Location = new System.Drawing.Point(5, 141);
            this.glControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl2.Name = "glControl2";
            this.glControl2.Size = new System.Drawing.Size(1223, 721);
            this.glControl2.TabIndex = 0;
            this.glControl2.VSync = false;
            this.glControl2.Load += new System.EventHandler(this.glControl2_Load);
            this.glControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl2_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Выбор объекта";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Coral;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(1033, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(158, 38);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Применить";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Up Wall";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBar1.Location = new System.Drawing.Point(803, 78);
            this.trackBar1.Maximum = 24;
            this.trackBar1.Minimum = -4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(224, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 4;
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBar2.Location = new System.Drawing.Point(825, 19);
            this.trackBar2.Maximum = 5;
            this.trackBar2.Minimum = -5;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(171, 56);
            this.trackBar2.TabIndex = 7;
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBar3.Location = new System.Drawing.Point(1002, 19);
            this.trackBar3.Maximum = 30;
            this.trackBar3.Minimum = -2;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(215, 56);
            this.trackBar3.TabIndex = 8;
            this.trackBar3.Value = 9;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Down Wall";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 87);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 21);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Left Wall";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(121, 33);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 21);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Back Wall";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(121, 60);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(99, 21);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Big Sphere";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(121, 87);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(113, 21);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Small Sphere";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(121, 5);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(93, 21);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Right Wall";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Освещение";
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.SystemColors.ControlText;
            this.trackBar4.Location = new System.Drawing.Point(248, 21);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(165, 56);
            this.trackBar4.TabIndex = 17;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.SystemColors.ControlText;
            this.trackBar5.Location = new System.Drawing.Point(419, 21);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(165, 56);
            this.trackBar5.TabIndex = 18;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.BackColor = System.Drawing.SystemColors.ControlText;
            this.trackBar6.Location = new System.Drawing.Point(339, 78);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(165, 56);
            this.trackBar6.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Настройка цвета объекта";
            // 
            // trackBar7
            // 
            this.trackBar7.BackColor = System.Drawing.Color.Crimson;
            this.trackBar7.Location = new System.Drawing.Point(591, 21);
            this.trackBar7.Minimum = -10;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(215, 56);
            this.trackBar7.TabIndex = 21;
            this.trackBar7.Value = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Коэффицент отражения";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1229, 863);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.glControl2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 3: Трассировка лучей";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gLControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gLControlBindingSource;
        private System.Windows.Forms.BindingSource gLBindingSource;
        private OpenTK.GLControl glControl2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label3;
    }
}

