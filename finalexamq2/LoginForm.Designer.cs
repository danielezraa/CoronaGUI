namespace finalexamq2
{
    partial class LoginForm
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
            this.welcomeLB = new System.Windows.Forms.Label();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.loginBN = new System.Windows.Forms.Button();
            this.infoLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLB
            // 
            this.welcomeLB.AutoSize = true;
            this.welcomeLB.Location = new System.Drawing.Point(347, 21);
            this.welcomeLB.Name = "welcomeLB";
            this.welcomeLB.Size = new System.Drawing.Size(55, 13);
            this.welcomeLB.TabIndex = 0;
            this.welcomeLB.Text = "Welcome!";
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(327, 86);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(100, 20);
            this.firstnameTB.TabIndex = 1;
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(327, 123);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(100, 20);
            this.lastnameTB.TabIndex = 2;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(327, 159);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(100, 20);
            this.ageTB.TabIndex = 3;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(327, 204);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 4;
            // 
            // loginBN
            // 
            this.loginBN.Location = new System.Drawing.Point(340, 259);
            this.loginBN.Name = "loginBN";
            this.loginBN.Size = new System.Drawing.Size(75, 23);
            this.loginBN.TabIndex = 5;
            this.loginBN.Text = "Login";
            this.loginBN.UseVisualStyleBackColor = true;
            this.loginBN.Click += new System.EventHandler(this.loginBN_Click);
            // 
            // infoLB
            // 
            this.infoLB.AutoSize = true;
            this.infoLB.Location = new System.Drawing.Point(321, 48);
            this.infoLB.Name = "infoLB";
            this.infoLB.Size = new System.Drawing.Size(106, 13);
            this.infoLB.TabIndex = 6;
            this.infoLB.Text = "This application is.... ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLB);
            this.Controls.Add(this.loginBN);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.lastnameTB);
            this.Controls.Add(this.firstnameTB);
            this.Controls.Add(this.welcomeLB);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLB;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button loginBN;
        private System.Windows.Forms.Label infoLB;
    }
}

