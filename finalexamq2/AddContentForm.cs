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
    public partial class AddContentForm : Form
    {
        public AddContentForm()
        {
            InitializeComponent();
        }

        private void AddContentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void dataBN_Click(object sender, EventArgs e)
        {
            AddDataForm adf = new AddDataForm();
            adf.Show();
            this.Hide();
        }

        private void backBN_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void questionBN_Click(object sender, EventArgs e)
        {
            AddQuestionForm aqf = new AddQuestionForm();
            aqf.Show();
            this.Hide();
        }
    }
}
