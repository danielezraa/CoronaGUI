using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexamq2
{
    public class WrongQuestions
    {
        //Data
        string body;
        int type;
        string correctAnswer;
        string incorrectanswer;


        //Properties
        public string Body { get => body; set => body = value; }
        public int Type { get => type; set => type = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string Incorrectanswer { get => incorrectanswer; set => incorrectanswer = value; }


        //Contractors
        public WrongQuestions(string body, int type, string correctAnswer, string incorrectanswer)
        {
            Body = body;
            Type = type;
            CorrectAnswer = correctAnswer;
            Incorrectanswer = incorrectanswer;
        }

        //Methods
        public override string ToString()
        {
            return Body + "\r\nYour Answer: " + incorrectanswer + "\r\nCorrect Answer: " + correctAnswer + "\r\n";
        }
    }
}
