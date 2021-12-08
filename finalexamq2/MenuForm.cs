using System;
using System.CodeDom.Compiler;
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
    public partial class MenuForm : Form
    {
        
        public MenuForm()
        {
            
            

            InitializeComponent();
        }

        private void studyBN_Click(object sender, EventArgs e)
        {
            StudyForm sf = new StudyForm();
            sf.Show();
            this.Hide();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void exerciseBN_Click(object sender, EventArgs e)
        {
            ExerciseForm ef = new ExerciseForm(null,null);
            ef.Show();
            this.Hide();
        }

        private void addnewdataBN_Click(object sender, EventArgs e)
        {
            AddContentForm acf = new AddContentForm();
            acf.Show();
            this.Hide();
        }
    }
}
