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
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void AddDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
        private void backBN_Click(object sender, EventArgs e)
        {
            AddContentForm acf = new AddContentForm();
            acf.Show();
            this.Hide();
        }
        private void addBN_Click(object sender, EventArgs e)
        {

            if (topicTB.Text != string.Empty && contentTB.Text != string.Empty)
            {
                String last = File.ReadLines(@"..\..\DATA\infoData.txt").Last();
                string[] tmp = last.Split(';');
                int questionindex = int.Parse(tmp[0]) + 1;
                if (imgCB.Checked == true)
                {
                    string newq = questionindex + ";" + topicTB.Text + ";" + contentTB.Text + ";" + questionindex + "COVID.jpg";
                            File.AppendAllText(@"..\..\DATA\infoData.txt", newq + Environment.NewLine);
                            MessageBox.Show("Success! question has been added");
                            MessageBox.Show("WARNNING, please add the img to folder with the name: " + questionindex + "COVID");
                }
                else
                {
                    string newq = questionindex + ";" + topicTB.Text + ";" + contentTB.Text;
                    File.AppendAllText(@"..\..\DATA\infoData.txt", newq + Environment.NewLine);
                    MessageBox.Show("Success! question has been added");
                }

            }

            else MessageBox.Show("Please fill all fields before trying to add data");
            return;
        }
    }
}
