using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexamq2
{
    class Question
    {
        //Data
        int number;
        int type;
        string body;
        string correctAnswer;
        string incorrectanswers1;
        string incorrectanswers2;


        //Properties
        public int Number { get => number; set => number = value; }
        public int Type { get => type; set => type = value; }
        public string Body { get => body; set => body = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string Incorrectanswers1 { get => incorrectanswers1; set => incorrectanswers1 = value; }
        public string Incorrectanswers2 { get => incorrectanswers2; set => incorrectanswers2 = value; }
        

        //Contractors
        public Question()
        {
        }
        public Question(int number, int type, string body, string correctAnswer)
        {
            Number = number;
            Type = type;
            Body = body;
            CorrectAnswer = correctAnswer;
            if (correctAnswer.ToLower() == "true")
                Incorrectanswers1 = "false";
            else Incorrectanswers1 = "true";
        }
        public Question(int number, int type, string body, string correctAnswer, string incorrectanswers1)
        {
            Number = number;
            Type = type;
            Body = body;
            CorrectAnswer = correctAnswer;
            Incorrectanswers1 = incorrectanswers1;
        }
        public Question(int number, int type, string body, string correctAnswer, string incorrectanswers1, string incorrectanswers2)
        {
            Number = number;
            Type = type;
            Body = body;
            CorrectAnswer = correctAnswer;
            Incorrectanswers1 = incorrectanswers1;
            Incorrectanswers2 = incorrectanswers2;
        }
    }

}
