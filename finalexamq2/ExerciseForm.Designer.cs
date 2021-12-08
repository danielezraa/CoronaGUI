namespace finalexamq2
{
    partial class ExerciseForm
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
            this.bodyLB = new System.Windows.Forms.Label();
            this.questionsLB = new System.Windows.Forms.Label();
            this.questionCounterLB = new System.Windows.Forms.Label();
            this.nextBN = new System.Windows.Forms.Button();
            this.truefalsePL = new System.Windows.Forms.Panel();
            this.falseRB = new System.Windows.Forms.RadioButton();
            this.trueRB = new System.Windows.Forms.RadioButton();
            this.multichoicePL = new System.Windows.Forms.Panel();
            this.multi3RB = new System.Windows.Forms.RadioButton();
            this.multi2RB = new System.Windows.Forms.RadioButton();
            this.multi1RB = new System.Windows.Forms.RadioButton();
            this.truefalsePL.SuspendLayout();
            this.multichoicePL.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyLB
            // 
            this.bodyLB.AutoSize = true;
            this.bodyLB.Location = new System.Drawing.Point(39, 101);
            this.bodyLB.Name = "bodyLB";
            this.bodyLB.Size = new System.Drawing.Size(30, 13);
            this.bodyLB.TabIndex = 0;
            this.bodyLB.Text = "body";
            // 
            // questionsLB
            // 
            this.questionsLB.AutoSize = true;
            this.questionsLB.Location = new System.Drawing.Point(238, 37);
            this.questionsLB.Name = "questionsLB";
            this.questionsLB.Size = new System.Drawing.Size(57, 13);
            this.questionsLB.TabIndex = 1;
            this.questionsLB.Text = "Questions:";
            // 
            // questionCounterLB
            // 
            this.questionCounterLB.AutoSize = true;
            this.questionCounterLB.Location = new System.Drawing.Point(291, 37);
            this.questionCounterLB.Name = "questionCounterLB";
            this.questionCounterLB.Size = new System.Drawing.Size(30, 13);
            this.questionCounterLB.TabIndex = 2;
            this.questionCounterLB.Text = "0/10";
            // 
            // nextBN
            // 
            this.nextBN.Location = new System.Drawing.Point(136, 413);
            this.nextBN.Name = "nextBN";
            this.nextBN.Size = new System.Drawing.Size(75, 23);
            this.nextBN.TabIndex = 3;
            this.nextBN.Text = "Next";
            this.nextBN.UseVisualStyleBackColor = true;
            this.nextBN.Click += new System.EventHandler(this.nextBN_Click);
            // 
            // truefalsePL
            // 
            this.truefalsePL.Controls.Add(this.falseRB);
            this.truefalsePL.Controls.Add(this.trueRB);
            this.truefalsePL.Location = new System.Drawing.Point(42, 297);
            this.truefalsePL.Name = "truefalsePL";
            this.truefalsePL.Size = new System.Drawing.Size(279, 100);
            this.truefalsePL.TabIndex = 5;
            this.truefalsePL.Visible = false;
            // 
            // falseRB
            // 
            this.falseRB.AutoSize = true;
            this.falseRB.Location = new System.Drawing.Point(158, 33);
            this.falseRB.Name = "falseRB";
            this.falseRB.Size = new System.Drawing.Size(50, 17);
            this.falseRB.TabIndex = 1;
            this.falseRB.TabStop = true;
            this.falseRB.Text = "False";
            this.falseRB.UseVisualStyleBackColor = true;
            // 
            // trueRB
            // 
            this.trueRB.AutoSize = true;
            this.trueRB.Location = new System.Drawing.Point(51, 33);
            this.trueRB.Name = "trueRB";
            this.trueRB.Size = new System.Drawing.Size(47, 17);
            this.trueRB.TabIndex = 0;
            this.trueRB.TabStop = true;
            this.trueRB.Text = "True";
            this.trueRB.UseVisualStyleBackColor = true;
            // 
            // multichoicePL
            // 
            this.multichoicePL.Controls.Add(this.multi3RB);
            this.multichoicePL.Controls.Add(this.multi2RB);
            this.multichoicePL.Controls.Add(this.multi1RB);
            this.multichoicePL.Location = new System.Drawing.Point(42, 271);
            this.multichoicePL.Name = "multichoicePL";
            this.multichoicePL.Size = new System.Drawing.Size(279, 136);
            this.multichoicePL.TabIndex = 6;
            this.multichoicePL.Visible = false;
            // 
            // multi3RB
            // 
            this.multi3RB.AutoSize = true;
            this.multi3RB.Location = new System.Drawing.Point(26, 61);
            this.multi3RB.Name = "multi3RB";
            this.multi3RB.Size = new System.Drawing.Size(66, 17);
            this.multi3RB.TabIndex = 0;
            this.multi3RB.TabStop = true;
            this.multi3RB.Text = "Answer3";
            this.multi3RB.UseVisualStyleBackColor = true;
            // 
            // multi2RB
            // 
            this.multi2RB.AutoSize = true;
            this.multi2RB.Location = new System.Drawing.Point(26, 38);
            this.multi2RB.Name = "multi2RB";
            this.multi2RB.Size = new System.Drawing.Size(66, 17);
            this.multi2RB.TabIndex = 0;
            this.multi2RB.TabStop = true;
            this.multi2RB.Text = "Answer2";
            this.multi2RB.UseVisualStyleBackColor = true;
            // 
            // multi1RB
            // 
            this.multi1RB.AutoSize = true;
            this.multi1RB.Location = new System.Drawing.Point(26, 15);
            this.multi1RB.Name = "multi1RB";
            this.multi1RB.Size = new System.Drawing.Size(66, 17);
            this.multi1RB.TabIndex = 0;
            this.multi1RB.TabStop = true;
            this.multi1RB.Text = "Answer1";
            this.multi1RB.UseVisualStyleBackColor = true;
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 474);
            this.Controls.Add(this.multichoicePL);
            this.Controls.Add(this.truefalsePL);
            this.Controls.Add(this.nextBN);
            this.Controls.Add(this.questionCounterLB);
            this.Controls.Add(this.questionsLB);
            this.Controls.Add(this.bodyLB);
            this.Name = "ExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExerciseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExerciseForm_FormClosing);
            this.truefalsePL.ResumeLayout(false);
            this.truefalsePL.PerformLayout();
            this.multichoicePL.ResumeLayout(false);
            this.multichoicePL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bodyLB;
        private System.Windows.Forms.Label questionsLB;
        private System.Windows.Forms.Label questionCounterLB;
        private System.Windows.Forms.Button nextBN;
        private System.Windows.Forms.Panel truefalsePL;
        private System.Windows.Forms.RadioButton falseRB;
        private System.Windows.Forms.RadioButton trueRB;
        private System.Windows.Forms.Panel multichoicePL;
        private System.Windows.Forms.RadioButton multi3RB;
        private System.Windows.Forms.RadioButton multi2RB;
        private System.Windows.Forms.RadioButton multi1RB;
    }
}