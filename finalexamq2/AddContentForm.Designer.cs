namespace finalexamq2
{
    partial class AddContentForm
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
            this.titleLB = new System.Windows.Forms.Label();
            this.questionBN = new System.Windows.Forms.Button();
            this.dataBN = new System.Windows.Forms.Button();
            this.backBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Location = new System.Drawing.Point(170, 9);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(221, 13);
            this.titleLB.TabIndex = 0;
            this.titleLB.Text = "Which kind of content would you like to add?";
            // 
            // questionBN
            // 
            this.questionBN.Location = new System.Drawing.Point(332, 61);
            this.questionBN.Name = "questionBN";
            this.questionBN.Size = new System.Drawing.Size(197, 92);
            this.questionBN.TabIndex = 1;
            this.questionBN.Text = "Question";
            this.questionBN.UseVisualStyleBackColor = true;
            this.questionBN.Click += new System.EventHandler(this.questionBN_Click);
            // 
            // dataBN
            // 
            this.dataBN.Location = new System.Drawing.Point(58, 61);
            this.dataBN.Name = "dataBN";
            this.dataBN.Size = new System.Drawing.Size(197, 92);
            this.dataBN.TabIndex = 1;
            this.dataBN.Text = "Data";
            this.dataBN.UseVisualStyleBackColor = true;
            this.dataBN.Click += new System.EventHandler(this.dataBN_Click);
            // 
            // backBN
            // 
            this.backBN.Location = new System.Drawing.Point(21, 160);
            this.backBN.Name = "backBN";
            this.backBN.Size = new System.Drawing.Size(75, 23);
            this.backBN.TabIndex = 7;
            this.backBN.Text = "Back";
            this.backBN.UseVisualStyleBackColor = true;
            this.backBN.Click += new System.EventHandler(this.backBN_Click);
            // 
            // AddContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 195);
            this.Controls.Add(this.backBN);
            this.Controls.Add(this.dataBN);
            this.Controls.Add(this.questionBN);
            this.Controls.Add(this.titleLB);
            this.Name = "AddContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddContentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddContentForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Button questionBN;
        private System.Windows.Forms.Button dataBN;
        private System.Windows.Forms.Button backBN;
    }
}