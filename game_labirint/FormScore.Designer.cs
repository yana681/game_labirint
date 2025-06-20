
namespace game_labirint
{
    partial class FormScore
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
            this.listViewScoreOfUsers = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результаты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewScoreOfUsers
            // 
            this.listViewScoreOfUsers.BackColor = System.Drawing.Color.Linen;
            this.listViewScoreOfUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderScore,
            this.columnHeaderTime});
            this.listViewScoreOfUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewScoreOfUsers.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewScoreOfUsers.HideSelection = false;
            this.listViewScoreOfUsers.Location = new System.Drawing.Point(0, 95);
            this.listViewScoreOfUsers.Name = "listViewScoreOfUsers";
            this.listViewScoreOfUsers.Size = new System.Drawing.Size(614, 588);
            this.listViewScoreOfUsers.TabIndex = 1;
            this.listViewScoreOfUsers.UseCompatibleStateImageBehavior = false;
            this.listViewScoreOfUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 177;
            // 
            // columnHeaderScore
            // 
            this.columnHeaderScore.Text = "Баллы";
            this.columnHeaderScore.Width = 153;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Время";
            this.columnHeaderTime.Width = 155;
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 683);
            this.Controls.Add(this.listViewScoreOfUsers);
            this.Controls.Add(this.label1);
            this.Name = "FormScore";
            this.Text = "Таблица результатов";
            this.Load += new System.EventHandler(this.FormScore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewScoreOfUsers;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderScore;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
    }
}