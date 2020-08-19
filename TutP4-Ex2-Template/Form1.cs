using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutP4_Ex2_Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Bomb b1 = new Bomb(50, 50);
            Missile m1 = new Missile(400, 170);
            b1.Display(paper);
            m1.Display(paper);
        }
    }
}
