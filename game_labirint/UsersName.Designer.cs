
namespace game_labirint
{
    partial class FormUsersName
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSaveUserName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(113, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(341, 56);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonSaveUserName
            // 
            this.buttonSaveUserName.BackColor = System.Drawing.Color.Maroon;
            this.buttonSaveUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUserName.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveUserName.Location = new System.Drawing.Point(113, 265);
            this.buttonSaveUserName.Name = "buttonSaveUserName";
            this.buttonSaveUserName.Size = new System.Drawing.Size(336, 104);
            this.buttonSaveUserName.TabIndex = 1;
            this.buttonSaveUserName.Text = "Сохранить";
            this.buttonSaveUserName.UseVisualStyleBackColor = false;
            this.buttonSaveUserName.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUsersName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::game_labirint.Properties.Resources.fone2;
            this.ClientSize = new System.Drawing.Size(560, 455);
            this.Controls.Add(this.buttonSaveUserName);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormUsersName";
            this.Text = "Введите имя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSaveUserName;
    }
}