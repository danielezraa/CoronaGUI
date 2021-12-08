namespace finalexamq2
{
    partial class StudyForm
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
            this.contentTB = new System.Windows.Forms.TextBox();
            this.topicLB = new System.Windows.Forms.Label();
            this.previousBN = new System.Windows.Forms.Button();
            this.finishBN = new System.Windows.Forms.Button();
            this.nextBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentTB
            // 
            this.contentTB.Location = new System.Drawing.Point(37, 77);
            this.contentTB.Multiline = true;
            this.contentTB.Name = "contentTB";
            this.contentTB.Size = new System.Drawing.Size(330, 206);
            this.contentTB.TabIndex = 0;
            // 
            // topicLB
            // 
            this.topicLB.AutoSize = true;
            this.topicLB.Location = new System.Drawing.Point(34, 32);
            this.topicLB.Name = "topicLB";
            this.topicLB.Size = new System.Drawing.Size(30, 13);
            this.topicLB.TabIndex = 1;
            this.topicLB.Text = "topic";
            // 
            // previousBN
            // 
            this.previousBN.Enabled = false;
            this.previousBN.Location = new System.Drawing.Point(37, 310);
            this.previousBN.Name = "previousBN";
            this.previousBN.Size = new System.Drawing.Size(75, 23);
            this.previousBN.TabIndex = 2;
            this.previousBN.Text = "Previous";
            this.previousBN.UseVisualStyleBackColor = true;
            this.previousBN.Click += new System.EventHandler(this.previousBN_Click);
            // 
            // finishBN
            // 
            this.finishBN.Location = new System.Drawing.Point(151, 310);
            this.finishBN.Name = "finishBN";
            this.finishBN.Size = new System.Drawing.Size(75, 23);
            this.finishBN.TabIndex = 3;
            this.finishBN.Text = "Finish";
            this.finishBN.UseVisualStyleBackColor = true;
            this.finishBN.Click += new System.EventHandler(this.finishBN_Click);
            // 
            // nextBN
            // 
            this.nextBN.Location = new System.Drawing.Point(292, 310);
            this.nextBN.Name = "nextBN";
            this.nextBN.Size = new System.Drawing.Size(75, 23);
            this.nextBN.TabIndex = 4;
            this.nextBN.Text = "Next";
            this.nextBN.UseVisualStyleBackColor = true;
            this.nextBN.Click += new System.EventHandler(this.nextBN_Click);
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 365);
            this.Controls.Add(this.nextBN);
            this.Controls.Add(this.finishBN);
            this.Controls.Add(this.previousBN);
            this.Controls.Add(this.topicLB);
            this.Controls.Add(this.contentTB);
            this.Name = "StudyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudyForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTB;
        private System.Windows.Forms.Label topicLB;
        private System.Windows.Forms.Button previousBN;
        private System.Windows.Forms.Button finishBN;
        private System.Windows.Forms.Button nextBN;
    }
}