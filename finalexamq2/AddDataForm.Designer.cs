namespace finalexamq2
{
    partial class AddDataForm
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
            this.topicTB = new System.Windows.Forms.TextBox();
            this.contentTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backBN = new System.Windows.Forms.Button();
            this.addBN = new System.Windows.Forms.Button();
            this.imgCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Topic:";
            // 
            // topicTB
            // 
            this.topicTB.Location = new System.Drawing.Point(37, 43);
            this.topicTB.Name = "topicTB";
            this.topicTB.Size = new System.Drawing.Size(314, 20);
            this.topicTB.TabIndex = 3;
            // 
            // contentTB
            // 
            this.contentTB.Location = new System.Drawing.Point(37, 89);
            this.contentTB.Multiline = true;
            this.contentTB.Name = "contentTB";
            this.contentTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTB.Size = new System.Drawing.Size(422, 196);
            this.contentTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Content:";
            // 
            // backBN
            // 
            this.backBN.Location = new System.Drawing.Point(6, 346);
            this.backBN.Name = "backBN";
            this.backBN.Size = new System.Drawing.Size(75, 23);
            this.backBN.TabIndex = 6;
            this.backBN.Text = "Back";
            this.backBN.UseVisualStyleBackColor = true;
            this.backBN.Click += new System.EventHandler(this.backBN_Click);
            // 
            // addBN
            // 
            this.addBN.Location = new System.Drawing.Point(216, 306);
            this.addBN.Name = "addBN";
            this.addBN.Size = new System.Drawing.Size(75, 47);
            this.addBN.TabIndex = 6;
            this.addBN.Text = "Add";
            this.addBN.UseVisualStyleBackColor = true;
            this.addBN.Click += new System.EventHandler(this.addBN_Click);
            // 
            // imgCB
            // 
            this.imgCB.AutoSize = true;
            this.imgCB.Location = new System.Drawing.Point(413, 45);
            this.imgCB.Name = "imgCB";
            this.imgCB.Size = new System.Drawing.Size(46, 17);
            this.imgCB.TabIndex = 7;
            this.imgCB.Text = "IMG";
            this.imgCB.UseVisualStyleBackColor = true;
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 374);
            this.Controls.Add(this.imgCB);
            this.Controls.Add(this.addBN);
            this.Controls.Add(this.backBN);
            this.Controls.Add(this.contentTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topicTB);
            this.Controls.Add(this.label1);
            this.Name = "AddDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDataForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox topicTB;
        private System.Windows.Forms.TextBox contentTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBN;
        private System.Windows.Forms.Button addBN;
        private System.Windows.Forms.CheckBox imgCB;
    }
}