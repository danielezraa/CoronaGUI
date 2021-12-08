namespace finalexamq2
{
    partial class MenuForm
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
            this.addnewdataBN = new System.Windows.Forms.Button();
            this.exerciseBN = new System.Windows.Forms.Button();
            this.studyBN = new System.Windows.Forms.Button();
            this.choseLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addnewdataBN
            // 
            this.addnewdataBN.Location = new System.Drawing.Point(196, 220);
            this.addnewdataBN.Name = "addnewdataBN";
            this.addnewdataBN.Size = new System.Drawing.Size(110, 23);
            this.addnewdataBN.TabIndex = 0;
            this.addnewdataBN.Text = "Add new Data";
            this.addnewdataBN.UseVisualStyleBackColor = true;
            this.addnewdataBN.Click += new System.EventHandler(this.addnewdataBN_Click);
            // 
            // exerciseBN
            // 
            this.exerciseBN.Location = new System.Drawing.Point(381, 220);
            this.exerciseBN.Name = "exerciseBN";
            this.exerciseBN.Size = new System.Drawing.Size(75, 23);
            this.exerciseBN.TabIndex = 0;
            this.exerciseBN.Text = "Exercise";
            this.exerciseBN.UseVisualStyleBackColor = true;
            this.exerciseBN.Click += new System.EventHandler(this.exerciseBN_Click);
            // 
            // studyBN
            // 
            this.studyBN.Location = new System.Drawing.Point(498, 220);
            this.studyBN.Name = "studyBN";
            this.studyBN.Size = new System.Drawing.Size(75, 23);
            this.studyBN.TabIndex = 0;
            this.studyBN.Text = "Study";
            this.studyBN.UseVisualStyleBackColor = true;
            this.studyBN.Click += new System.EventHandler(this.studyBN_Click);
            // 
            // choseLB
            // 
            this.choseLB.AutoSize = true;
            this.choseLB.Location = new System.Drawing.Point(297, 87);
            this.choseLB.Name = "choseLB";
            this.choseLB.Size = new System.Drawing.Size(140, 13);
            this.choseLB.TabIndex = 1;
            this.choseLB.Text = "Press any button to procced";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choseLB);
            this.Controls.Add(this.studyBN);
            this.Controls.Add(this.exerciseBN);
            this.Controls.Add(this.addnewdataBN);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainmenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnewdataBN;
        private System.Windows.Forms.Button exerciseBN;
        private System.Windows.Forms.Button studyBN;
        private System.Windows.Forms.Label choseLB;
    }
}