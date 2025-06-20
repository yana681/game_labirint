
namespace game_labirint
{
    partial class FormMenu
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
            this.buttonTableScore = new System.Windows.Forms.Button();
            this.buttonLevelHard = new System.Windows.Forms.Button();
            this.buttonLevellEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 199);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            // 
            // buttonTableScore
            // 
            this.buttonTableScore.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonTableScore.FlatAppearance.BorderSize = 0;
            this.buttonTableScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonTableScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.buttonTableScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableScore.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTableScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTableScore.Location = new System.Drawing.Point(488, 576);
            this.buttonTableScore.Name = "buttonTableScore";
            this.buttonTableScore.Size = new System.Drawing.Size(350, 120);
            this.buttonTableScore.TabIndex = 1;
            this.buttonTableScore.Text = "Таблица рекордов";
            this.buttonTableScore.UseVisualStyleBackColor = false;
            this.buttonTableScore.Click += new System.EventHandler(this.buttonTableScore_Click);
            // 
            // buttonLevelHard
            // 
            this.buttonLevelHard.BackColor = System.Drawing.Color.Maroon;
            this.buttonLevelHard.FlatAppearance.BorderSize = 0;
            this.buttonLevelHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.buttonLevelHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonLevelHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelHard.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevelHard.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLevelHard.Location = new System.Drawing.Point(488, 402);
            this.buttonLevelHard.Name = "buttonLevelHard";
            this.buttonLevelHard.Size = new System.Drawing.Size(350, 120);
            this.buttonLevelHard.TabIndex = 3;
            this.buttonLevelHard.Text = "УРОВЕНЬ:\r\nПрофи";
            this.buttonLevelHard.UseVisualStyleBackColor = false;
            this.buttonLevelHard.Click += new System.EventHandler(this.buttonLevelHard_Click);
            // 
            // buttonLevellEasy
            // 
            this.buttonLevellEasy.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonLevellEasy.FlatAppearance.BorderSize = 0;
            this.buttonLevellEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.buttonLevellEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.buttonLevellEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevellEasy.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevellEasy.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLevellEasy.Location = new System.Drawing.Point(488, 233);
            this.buttonLevellEasy.Name = "buttonLevellEasy";
            this.buttonLevellEasy.Size = new System.Drawing.Size(350, 120);
            this.buttonLevellEasy.TabIndex = 2;
            this.buttonLevellEasy.Text = "УРОВЕНЬ:\r\nНовичок ";
            this.buttonLevellEasy.UseVisualStyleBackColor = false;
            this.buttonLevellEasy.Click += new System.EventHandler(this.buttonLevellEasy_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::game_labirint.Properties.Resources.fon_igra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 803);
            this.Controls.Add(this.buttonLevelHard);
            this.Controls.Add(this.buttonLevellEasy);
            this.Controls.Add(this.buttonTableScore);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабиринт с Буквами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTableScore;
        private System.Windows.Forms.Button buttonLevelHard;
        private System.Windows.Forms.Button buttonLevellEasy;
    }
}