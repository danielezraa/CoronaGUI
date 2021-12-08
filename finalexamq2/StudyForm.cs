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
    public partial class StudyForm : Form
    {
        //-----Global Data-----//
        static List<Data> dataList = new List<Data>();
        static int counter = 0;
        //-----Global Data-----//

        public StudyForm()
        {

            ReadDataFile();     //reads the data file into string array, transfer the data into the list
            InitializeComponent();
            LoadData();


        }


        //----------Methods----------//
        void LoadData()
        {
            topicLB.Text = dataList[counter].Topic;
            contentTB.Text = dataList[counter].Content;
        }
        void ReadDataFile()
        {
            string[] infoDataArray = FileToString(@"..\..\DATA\infoData.txt");
            foreach (string line in infoDataArray)
            {
                string[] tmp = line.Split(';');
                if(tmp.Length > 3)
                {
                    Data d = new Data(int.Parse(tmp[0]), tmp[1], tmp[2], tmp[3]);
                    dataList.Add(d);
                }
                else
                {
                    Data d = new Data(int.Parse(tmp[0]), tmp[1], tmp[2]);
                    dataList.Add(d);
                }
            }
        }
        string[] FileToString(string dir)
        {
            string[] lines = System.IO.File.ReadAllLines(dir);
            return lines;
        }
        private void StudyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
        private void previousBN_Click(object sender, EventArgs e)
        {
            
            counter--;
            LoadData();
            nextBN.Enabled = true;
            if (counter == 0)
                previousBN.Enabled = false;
        }
        private void nextBN_Click(object sender, EventArgs e)
        {
            if(counter +1 < dataList.Count)
            {
                counter++;
                previousBN.Enabled = true;
                LoadData();
                if(counter +1 == dataList.Count)
                {
                    nextBN.Enabled = false;
                }
            }
        }
        private void finishBN_Click(object sender, EventArgs e)
        {
            MenuForm mm = new MenuForm();
            mm.Show();
            this.Hide();
        }
    }
}
