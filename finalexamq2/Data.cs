using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexamq2
{
    class Data
    {
        //Data
        private int number;
        private string topic;
        private string content;
        private string image;
                
        public Data(int number, string topic, string content, string image)
        {
            Number = number;
            Topic = topic;
            Image = image;
            Content = content;
        }
        public Data(int number, string topic, string content)
        {
            Number = number;
            Topic = topic;
            Content = content;
        }

        //Properties
        public int Number { get => number; set => number = value; }
        public string Topic { get => topic; set => topic = value; }
        public string Image { get => image; set => image = value; }
        public string Content { get => content; set => content = value; }



    }
}
