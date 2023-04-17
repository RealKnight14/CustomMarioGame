using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marios_Bros_Game
{
    public partial class titlescreen : Form
    {
        public titlescreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();
            gameWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helpscreen helpWindow = new helpscreen();
            helpWindow.Show();
        }
    }
}
