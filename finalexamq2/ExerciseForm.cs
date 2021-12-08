using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalexamq2
{
    public partial class ExerciseForm : Form
    {
        //-----Global Data-----//
        static ArrayList questionList = new ArrayList();
        static List<WrongQuestions> wq = new List<WrongQuestions>();
        static int counter = 0;
        int[] randIndex;
        int score;
        //-----Global Data-----//
        public ExerciseForm(int[] lgrandom, string playerinfo)
        {
            InitializeComponent();
            counter = 0;
            score = 0;
            wq.Clear();
            if (questionList.Count < 1)
                ReadDataFile();
            if (lgrandom == null)
                randIndex = RandIndex();
            else randIndex = lgrandom;
            LoadQuestions();


        }


        //----------Methods----------//
        void LoadQuestions()
        {
            Question q = (Question)questionList[randIndex[counter]];
            bodyLB.Text = q.Body;

            // which question?
            switch (q.Type)
            {
                case 0:
                    truefalsePL.Visible = true;
                    break;

                case 1:
                    multichoicePL.Visible = true;
                    RandRB(q.CorrectAnswer, q.Incorrectanswers1, q.Incorrectanswers2);
                    break;

                case 2:
                    //
                    break;

                case 3:
                    //
                    break;
            }
            counter++;
            questionCounterLB.Text = counter + "/10";
        }
        bool RBChecked()
        {
            if (trueRB.Checked == true || falseRB.Checked == true || multi1RB.Checked == true || multi2RB.Checked == true || multi3RB.Checked == true)
                return true;
            return false;
        }
        void ReadDataFile()
        {
            string[] gameDataArray = FileToString(@"..\..\DATA\gameData.txt");
            foreach (string line in gameDataArray)
            {
                string[] tmp = line.Split(';');
                Question d = new Question();

                // which contractor?
                switch (int.Parse(tmp[1]))
                {
                    case 0:     // true/false question
                        d = new Question(int.Parse(tmp[0]), int.Parse(tmp[1]), tmp[2], tmp[3]);
                        questionList.Add(d);
                        break;

                    case 1:     // multichoice question
                        d = new Question(int.Parse(tmp[0]), int.Parse(tmp[1]), tmp[2], tmp[3], tmp[4], tmp[5]);
                        questionList.Add(d);
                        break;

                    case 2:    // true/false question with IMG 
                        d = new Question(int.Parse(tmp[0]), int.Parse(tmp[1]), tmp[2], tmp[3], tmp[4]);
                        questionList.Add(d);
                        break;

                    case 3:     // multichoice question answer is IMG
                        d = new Question(int.Parse(tmp[0]), int.Parse(tmp[1]), tmp[2], tmp[3], tmp[4], tmp[5]);
                        questionList.Add(d);
                        break;
                }
            }
        }
        void ResetRB()
        {
            //truefalse questions
            trueRB.Checked = false;
            falseRB.Checked = false;
            truefalsePL.Visible = false;

            //multichoice questions
            multi1RB.Checked = false;
            multi2RB.Checked = false;
            multi3RB.Checked = false;
            multichoicePL.Visible = false;
        }
        void RandRB(string answer1, string answer2, string answer3)
        {
            string[] answers = { answer1, answer2, answer3 };
            int[] randomIndex = new int[3];
            for (int i = 0; i < 3; i++)
            {
                randomIndex[i] = -1;    //reset all numbers to -1
            }
            Random rnd = new Random();
            int randnum;
            for (int i = 0; i < 3; i++)
            {
                randnum = rnd.Next(0, 3);
                if (randomIndex.Contains(randnum))             //verify number isnt inside already
                {
                    i--;
                }
                else                                       //going to else if the number isnt inside
                {
                    randomIndex[i] = randnum;
                }
            }
            multi1RB.Text = answers[randomIndex[0]];
            multi2RB.Text = answers[randomIndex[1]];
            multi3RB.Text = answers[randomIndex[2]];
        }
        int[] RandIndex()
        {
            int[] randomIndex = new int[10];
            for (int i = 0; i < randomIndex.Length; i++)
            {
                randomIndex[i] = -1;    //reset all numbers to -1
            }
            Random rnd = new Random();
            int randnum;
            for (int i = 0; i < randomIndex.Length; i++)
            {
                randnum = rnd.Next(0, questionList.Count);
                if (randomIndex.Contains(randnum))             //verify number isnt inside already
                {
                    i--;
                }
                else                                       //going to else if the number isnt inside
                {
                    randomIndex[i] = randnum;
                }

            }
            return randomIndex;
        }
        string[] FileToString(string dir)
        {
            string[] lines = System.IO.File.ReadAllLines(dir);
            return lines;
        }
        private void ExerciseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
        void CheckAnswer()
        {
            Question q = (Question)questionList[randIndex[counter - 1]];
            // which question?
            switch (q.Type)
            {
                case 0:
                    if (trueRB.Checked == true && q.CorrectAnswer.ToLower() == "true")
                    {
                        score++;
                        break;
                    }
                    if (falseRB.Checked == true && q.CorrectAnswer.ToLower() == "false")
                    {
                        score++;
                        break;
                    }
                    else
                    {
                        WrongQuestions tmpwq = new WrongQuestions(q.Body, q.Type, q.CorrectAnswer, q.Incorrectanswers1);
                        wq.Add(tmpwq);
                        break;
                    }
                case 1:
                    if (multi1RB.Checked == true)
                    {
                        if (q.CorrectAnswer == multi1RB.Text)
                        {
                            score++;
                            break;
                        }
                        else
                        {
                            WrongQuestions tmpwq = new WrongQuestions(q.Body, q.Type, q.CorrectAnswer, multi1RB.Text);
                            wq.Add(tmpwq);
                            break;
                        }
                    }
                    if (multi2RB.Checked == true)
                    {
                        if (q.CorrectAnswer == multi2RB.Text)
                        {
                            score++;
                            break;
                        }
                        else
                        {
                            WrongQuestions tmpwq = new WrongQuestions(q.Body, q.Type, q.CorrectAnswer, multi2RB.Text);
                            wq.Add(tmpwq);
                            break;
                        }
                    }
                    else
                    {
                        if (q.CorrectAnswer == multi3RB.Text)
                        {
                            score++;
                            break;
                        }
                        else
                        {
                            WrongQuestions tmpwq = new WrongQuestions(q.Body, q.Type, q.CorrectAnswer, multi3RB.Text);
                            wq.Add(tmpwq);
                            break;
                        }
                    }
                case 2:
                    //
                    break;
                case 3:
                    //
                    break;
            }
        }
        private void nextBN_Click(object sender, EventArgs e)
        {
            if (true)//RBChecked()
            {
                if (counter < 3)
                {
                    CheckAnswer();
                    ResetRB();
                    LoadQuestions();
                }
                else
                {
                    MessageBox.Show("Great! exercise is done, lets see your results!");
                    StatisticsForm sf = new StatisticsForm(wq, randIndex, score, null);
                    sf.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Chose your answer to continue");
        }
    }
}
