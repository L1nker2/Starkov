﻿namespace Starkov
{
    partial class Main
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 721);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(51, 469);
            button5.Name = "button5";
            button5.Size = new Size(140, 40);
            button5.TabIndex = 4;
            button5.Text = "О программе";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(51, 423);
            button4.Name = "button4";
            button4.Size = new Size(140, 40);
            button4.TabIndex = 3;
            button4.Text = "Клиенты";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(51, 377);
            button3.Name = "button3";
            button3.Size = new Size(140, 40);
            button3.TabIndex = 2;
            button3.Text = "Квартиры/Дома";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(51, 331);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 1;
            button2.Text = "Сотрудники";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(51, 285);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 0;
            button1.Text = "Контракты";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 721);
            panel2.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 721);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Агенство недвижимости";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}