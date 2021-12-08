using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalexamq2
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void tfaddBN_Click(object sender, EventArgs e)
        {
            if (tfquestionTB.Text != string.Empty && (tfTrueRB.Checked== true || tfFalseRB.Checked == true))
            {
                String last = File.ReadLines(@"..\..\DATA\gameData.txt").Last();
                string[] tmp = last.Split(';');
                int questionindex = int.Parse(tmp[0]) + 1;

                if (tfimgCB.Checked == true)        //11;2;true false question with img:;true
                {
                    if (tfTrueRB.Checked == true)
                    {
                        string newq = questionindex + ";2;" + tfquestionTB.Text + ";true";
                        File.AppendAllText(@"..\..\DATA\gameData.txt", newq + Environment.NewLine);
                    }
                    else
                    {
                        string newq = questionindex + ";2;" + tfquestionTB.Text + ";false";
                        File.AppendAllText(@"..\..\DATA\gameData.txt", newq + Environment.NewLine);
                    }
                    
                    MessageBox.Show("Success! question has been added");
                    MessageBox.Show("WARNNING, please add the img to folder with the name: " + questionindex + "CoronaVirus and img format has to be JPG");
                }
                else
                {
                    if (tfTrueRB.Checked == false)
                    {
                        string newq = questionindex + ";0;" + tfquestionTB.Text + ";true";
                        File.AppendAllText(@"..\..\DATA\gameData.txt", newq + Environment.NewLine);
                    }
                    else
                    {
                        string newq = questionindex + ";0;" + tfquestionTB.Text + ";false";
                        File.AppendAllText(@"..\..\DATA\gameData.txt", newq + Environment.NewLine);
                    }
                    MessageBox.Show("Success! question has been added");
                }
            }
            else MessageBox.Show("Please fill all fields before trying to add questions");
        }

        private void backBN_Click(object sender, EventArgs e)
        {
            AddContentForm acf = new AddContentForm();
            acf.Show();
            this.Hide();
        }
        private void mcaddBN_Click(object sender, EventArgs e)
        {
            if(mcquestionTB.Text != string.Empty && mccorrectTB.Text != string.Empty && mcincorrect1TB.Text != string.Empty && mcincorrect2TB.Text != string.Empty)
            {
                String last = File.ReadLines(@"..\..\DATA\gameData.txt").Last();
                string[] tmp = last.Split(';');
                int questionindex = int.Parse(tmp[0]) + 1;
                if(mcimgCB.Checked == true)//index;3;mcquestion:;correct answer;incorrectanswer1;incorrectanswer2 
                {
                    string newq = questionindex + ";3;" + mcquestionTB.Text + ";" + mccorrectTB.Text + ";" + mcincorrect1TB.Text + ";" + mcincorrect2TB.Text;
                    File.AppendAllText(@"..\..\DATA\gameData.txt", newq + Environment.NewLine);
                    MessageBox.Show("Success! question has been added");
                    MessageBox.Show("WARNNING, please add the img to folder with the name: " + questionindex + "CoronaVirus and img format has to be JPG");
                }
                else
                {
                    string newq = questionindex + ";1;" + mcquestionTB.Text + ";" + mccorrectTB.Text + ";" + mcincorrect1TB.Text + ";" + mcincorrect2TB.Text;
                    File.AppendAllText(@"..\..\DATA\gameData.txt", newq + Environment.NewLine);
                    MessageBox.Show("Success! question has been added");
                }
            }
            else MessageBox.Show("Please fill all fields before trying to add questions");
        }
    }
}
