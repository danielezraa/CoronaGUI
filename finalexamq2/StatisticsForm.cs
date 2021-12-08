using System;
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
    public partial class StatisticsForm : Form
    {
        static List<WrongQuestions> wq = new List<WrongQuestions>();
        int[] randIndex;
        int score;
        public StatisticsForm(List<WrongQuestions> lgwq, int[] lgrandom, int lgscore, string playerinfo)
        {
            InitializeComponent();
            //read data from last game
            randIndex = lgrandom;
            score = lgscore;
            scoreLB.Text = score.ToString();
            wq = lgwq;

            //textbox fill
            string mistakes = null;
            foreach (WrongQuestions question in wq)
            {
                mistakes += question.ToString() + "\r\n\r\n";
            }
            wrongTB.Text = mistakes;

        }
        //Methods
        private void showwrongBN_Click(object sender, EventArgs e)
        {
            wrongTB.Visible = true;
            showwrongBN.Visible = false;
        }
        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void studyBN_Click(object sender, EventArgs e)
        {
            StudyForm sf = new StudyForm();
            sf.Show();
            this.Hide();
        }

        private void newgameBN_Click(object sender, EventArgs e)
        {
            ExerciseForm ef = new ExerciseForm(null,null);
            ef.Show();
            this.Hide();
        }

        private void playagainBN_Click(object sender, EventArgs e)
        {
            ExerciseForm ef = new ExerciseForm(randIndex, null);
            ef.Show();
            this.Hide();
        }

        private void mainmenuBN_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }
    }
}
