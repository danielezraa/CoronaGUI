namespace finalexamq2
{
    partial class AddQuestionForm
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
            this.tfaddBN = new System.Windows.Forms.Button();
            this.titleLB = new System.Windows.Forms.Label();
            this.tfquestionTB = new System.Windows.Forms.TextBox();
            this.qLB = new System.Windows.Forms.Label();
            this.tfimgCB = new System.Windows.Forms.CheckBox();
            this.tfTrueRB = new System.Windows.Forms.RadioButton();
            this.tfcorrectPL = new System.Windows.Forms.Panel();
            this.answerLB = new System.Windows.Forms.Label();
            this.tfFalseRB = new System.Windows.Forms.RadioButton();
            this.mcaddBN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mcquestionTB = new System.Windows.Forms.TextBox();
            this.mcimgCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mccorrectTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mcincorrect1TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mcincorrect2TB = new System.Windows.Forms.TextBox();
            this.backBN = new System.Windows.Forms.Button();
            this.tfcorrectPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // tfaddBN
            // 
            this.tfaddBN.Location = new System.Drawing.Point(129, 331);
            this.tfaddBN.Name = "tfaddBN";
            this.tfaddBN.Size = new System.Drawing.Size(88, 38);
            this.tfaddBN.TabIndex = 0;
            this.tfaddBN.Text = "Add Question";
            this.tfaddBN.UseVisualStyleBackColor = true;
            this.tfaddBN.Click += new System.EventHandler(this.tfaddBN_Click);
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Location = new System.Drawing.Point(88, 34);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(110, 13);
            this.titleLB.TabIndex = 1;
            this.titleLB.Text = "True / False Question";
            // 
            // tfquestionTB
            // 
            this.tfquestionTB.Location = new System.Drawing.Point(91, 77);
            this.tfquestionTB.Name = "tfquestionTB";
            this.tfquestionTB.Size = new System.Drawing.Size(242, 20);
            this.tfquestionTB.TabIndex = 2;
            // 
            // qLB
            // 
            this.qLB.AutoSize = true;
            this.qLB.Location = new System.Drawing.Point(33, 80);
            this.qLB.Name = "qLB";
            this.qLB.Size = new System.Drawing.Size(52, 13);
            this.qLB.TabIndex = 1;
            this.qLB.Text = "Question:";
            // 
            // tfimgCB
            // 
            this.tfimgCB.AutoSize = true;
            this.tfimgCB.Location = new System.Drawing.Point(155, 240);
            this.tfimgCB.Name = "tfimgCB";
            this.tfimgCB.Size = new System.Drawing.Size(46, 17);
            this.tfimgCB.TabIndex = 3;
            this.tfimgCB.Text = "IMG";
            this.tfimgCB.UseVisualStyleBackColor = true;
            // 
            // tfTrueRB
            // 
            this.tfTrueRB.AutoSize = true;
            this.tfTrueRB.Location = new System.Drawing.Point(28, 41);
            this.tfTrueRB.Name = "tfTrueRB";
            this.tfTrueRB.Size = new System.Drawing.Size(47, 17);
            this.tfTrueRB.TabIndex = 4;
            this.tfTrueRB.TabStop = true;
            this.tfTrueRB.Text = "True";
            this.tfTrueRB.UseVisualStyleBackColor = true;
            // 
            // tfcorrectPL
            // 
            this.tfcorrectPL.Controls.Add(this.answerLB);
            this.tfcorrectPL.Controls.Add(this.tfFalseRB);
            this.tfcorrectPL.Controls.Add(this.tfTrueRB);
            this.tfcorrectPL.Location = new System.Drawing.Point(123, 116);
            this.tfcorrectPL.Name = "tfcorrectPL";
            this.tfcorrectPL.Size = new System.Drawing.Size(106, 100);
            this.tfcorrectPL.TabIndex = 5;
            // 
            // answerLB
            // 
            this.answerLB.AutoSize = true;
            this.answerLB.Location = new System.Drawing.Point(15, 16);
            this.answerLB.Name = "answerLB";
            this.answerLB.Size = new System.Drawing.Size(79, 13);
            this.answerLB.TabIndex = 6;
            this.answerLB.Text = "Correct Answer";
            // 
            // tfFalseRB
            // 
            this.tfFalseRB.AutoSize = true;
            this.tfFalseRB.Location = new System.Drawing.Point(28, 65);
            this.tfFalseRB.Name = "tfFalseRB";
            this.tfFalseRB.Size = new System.Drawing.Size(50, 17);
            this.tfFalseRB.TabIndex = 5;
            this.tfFalseRB.TabStop = true;
            this.tfFalseRB.Text = "False";
            this.tfFalseRB.UseVisualStyleBackColor = true;
            // 
            // mcaddBN
            // 
            this.mcaddBN.Location = new System.Drawing.Point(506, 328);
            this.mcaddBN.Name = "mcaddBN";
            this.mcaddBN.Size = new System.Drawing.Size(88, 38);
            this.mcaddBN.TabIndex = 0;
            this.mcaddBN.Text = "Add Question";
            this.mcaddBN.UseVisualStyleBackColor = true;
            this.mcaddBN.Click += new System.EventHandler(this.mcaddBN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Multichoice Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question:";
            // 
            // mcquestionTB
            // 
            this.mcquestionTB.Location = new System.Drawing.Point(426, 77);
            this.mcquestionTB.Name = "mcquestionTB";
            this.mcquestionTB.Size = new System.Drawing.Size(297, 20);
            this.mcquestionTB.TabIndex = 2;
            // 
            // mcimgCB
            // 
            this.mcimgCB.AutoSize = true;
            this.mcimgCB.Location = new System.Drawing.Point(532, 240);
            this.mcimgCB.Name = "mcimgCB";
            this.mcimgCB.Size = new System.Drawing.Size(46, 17);
            this.mcimgCB.TabIndex = 3;
            this.mcimgCB.Text = "IMG";
            this.mcimgCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Correct Answer:";
            // 
            // mccorrectTB
            // 
            this.mccorrectTB.Location = new System.Drawing.Point(460, 103);
            this.mccorrectTB.Name = "mccorrectTB";
            this.mccorrectTB.Size = new System.Drawing.Size(263, 20);
            this.mccorrectTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Incorrect Answer:";
            // 
            // mcincorrect1TB
            // 
            this.mcincorrect1TB.Location = new System.Drawing.Point(460, 130);
            this.mcincorrect1TB.Name = "mcincorrect1TB";
            this.mcincorrect1TB.Size = new System.Drawing.Size(263, 20);
            this.mcincorrect1TB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Incorrect Answer:";
            // 
            // mcincorrect2TB
            // 
            this.mcincorrect2TB.Location = new System.Drawing.Point(460, 156);
            this.mcincorrect2TB.Name = "mcincorrect2TB";
            this.mcincorrect2TB.Size = new System.Drawing.Size(263, 20);
            this.mcincorrect2TB.TabIndex = 2;
            // 
            // backBN
            // 
            this.backBN.Location = new System.Drawing.Point(12, 400);
            this.backBN.Name = "backBN";
            this.backBN.Size = new System.Drawing.Size(88, 38);
            this.backBN.TabIndex = 0;
            this.backBN.Text = "Back";
            this.backBN.UseVisualStyleBackColor = true;
            this.backBN.Click += new System.EventHandler(this.backBN_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.tfcorrectPL);
            this.Controls.Add(this.mcimgCB);
            this.Controls.Add(this.tfimgCB);
            this.Controls.Add(this.mcincorrect2TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mcincorrect1TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mccorrectTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mcquestionTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfquestionTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qLB);
            this.Controls.Add(this.mcaddBN);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.backBN);
            this.Controls.Add(this.tfaddBN);
            this.Name = "AddQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuestionForm_FormClosing);
            this.tfcorrectPL.ResumeLayout(false);
            this.tfcorrectPL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tfaddBN;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.TextBox tfquestionTB;
        private System.Windows.Forms.Label qLB;
        private System.Windows.Forms.CheckBox tfimgCB;
        private System.Windows.Forms.RadioButton tfTrueRB;
        private System.Windows.Forms.Panel tfcorrectPL;
        private System.Windows.Forms.Label answerLB;
        private System.Windows.Forms.RadioButton tfFalseRB;
        private System.Windows.Forms.Button mcaddBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mcquestionTB;
        private System.Windows.Forms.CheckBox mcimgCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mccorrectTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mcincorrect1TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mcincorrect2TB;
        private System.Windows.Forms.Button backBN;
    }
}