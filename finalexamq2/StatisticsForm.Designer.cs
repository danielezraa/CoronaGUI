namespace finalexamq2
{
    partial class StatisticsForm
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
            this.youscoreLB = new System.Windows.Forms.Label();
            this.scoreLB = new System.Windows.Forms.Label();
            this.wrongTB = new System.Windows.Forms.TextBox();
            this.studyBN = new System.Windows.Forms.Button();
            this.playagainBN = new System.Windows.Forms.Button();
            this.newgameBN = new System.Windows.Forms.Button();
            this.mainmenuBN = new System.Windows.Forms.Button();
            this.showwrongBN = new System.Windows.Forms.Button();
            this.addcontentBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // youscoreLB
            // 
            this.youscoreLB.AutoSize = true;
            this.youscoreLB.Location = new System.Drawing.Point(219, 27);
            this.youscoreLB.Name = "youscoreLB";
            this.youscoreLB.Size = new System.Drawing.Size(63, 13);
            this.youscoreLB.TabIndex = 0;
            this.youscoreLB.Text = "Your Score:";
            // 
            // scoreLB
            // 
            this.scoreLB.AutoSize = true;
            this.scoreLB.Location = new System.Drawing.Point(219, 52);
            this.scoreLB.Name = "scoreLB";
            this.scoreLB.Size = new System.Drawing.Size(33, 13);
            this.scoreLB.TabIndex = 0;
            this.scoreLB.Text = "score";
            // 
            // wrongTB
            // 
            this.wrongTB.Location = new System.Drawing.Point(70, 78);
            this.wrongTB.Multiline = true;
            this.wrongTB.Name = "wrongTB";
            this.wrongTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wrongTB.Size = new System.Drawing.Size(523, 136);
            this.wrongTB.TabIndex = 1;
            this.wrongTB.Visible = false;
            // 
            // studyBN
            // 
            this.studyBN.Location = new System.Drawing.Point(244, 275);
            this.studyBN.Name = "studyBN";
            this.studyBN.Size = new System.Drawing.Size(75, 23);
            this.studyBN.TabIndex = 2;
            this.studyBN.Text = "Study";
            this.studyBN.UseVisualStyleBackColor = true;
            this.studyBN.Click += new System.EventHandler(this.studyBN_Click);
            // 
            // playagainBN
            // 
            this.playagainBN.Location = new System.Drawing.Point(56, 275);
            this.playagainBN.Name = "playagainBN";
            this.playagainBN.Size = new System.Drawing.Size(75, 23);
            this.playagainBN.TabIndex = 2;
            this.playagainBN.Text = "Play Again";
            this.playagainBN.UseVisualStyleBackColor = true;
            this.playagainBN.Click += new System.EventHandler(this.playagainBN_Click);
            // 
            // newgameBN
            // 
            this.newgameBN.Location = new System.Drawing.Point(146, 275);
            this.newgameBN.Name = "newgameBN";
            this.newgameBN.Size = new System.Drawing.Size(75, 23);
            this.newgameBN.TabIndex = 2;
            this.newgameBN.Text = "New Game";
            this.newgameBN.UseVisualStyleBackColor = true;
            this.newgameBN.Click += new System.EventHandler(this.newgameBN_Click);
            // 
            // mainmenuBN
            // 
            this.mainmenuBN.Location = new System.Drawing.Point(347, 262);
            this.mainmenuBN.Name = "mainmenuBN";
            this.mainmenuBN.Size = new System.Drawing.Size(75, 49);
            this.mainmenuBN.TabIndex = 2;
            this.mainmenuBN.Text = "     Exit      (Main Menu)";
            this.mainmenuBN.UseVisualStyleBackColor = true;
            this.mainmenuBN.Click += new System.EventHandler(this.mainmenuBN_Click);
            // 
            // showwrongBN
            // 
            this.showwrongBN.Location = new System.Drawing.Point(55, 68);
            this.showwrongBN.Name = "showwrongBN";
            this.showwrongBN.Size = new System.Drawing.Size(563, 153);
            this.showwrongBN.TabIndex = 2;
            this.showwrongBN.Text = "Show Wrong Answers";
            this.showwrongBN.UseVisualStyleBackColor = true;
            this.showwrongBN.Click += new System.EventHandler(this.showwrongBN_Click);
            // 
            // addcontentBN
            // 
            this.addcontentBN.Location = new System.Drawing.Point(448, 275);
            this.addcontentBN.Name = "addcontentBN";
            this.addcontentBN.Size = new System.Drawing.Size(109, 23);
            this.addcontentBN.TabIndex = 3;
            this.addcontentBN.Text = "Add Content";
            this.addcontentBN.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 428);
            this.Controls.Add(this.addcontentBN);
            this.Controls.Add(this.showwrongBN);
            this.Controls.Add(this.mainmenuBN);
            this.Controls.Add(this.newgameBN);
            this.Controls.Add(this.playagainBN);
            this.Controls.Add(this.studyBN);
            this.Controls.Add(this.wrongTB);
            this.Controls.Add(this.scoreLB);
            this.Controls.Add(this.youscoreLB);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label youscoreLB;
        private System.Windows.Forms.Label scoreLB;
        private System.Windows.Forms.TextBox wrongTB;
        private System.Windows.Forms.Button studyBN;
        private System.Windows.Forms.Button playagainBN;
        private System.Windows.Forms.Button newgameBN;
        private System.Windows.Forms.Button mainmenuBN;
        private System.Windows.Forms.Button showwrongBN;
        private System.Windows.Forms.Button addcontentBN;
    }
}