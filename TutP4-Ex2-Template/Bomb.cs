using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TutP4_Ex2_Template
{
    class Bomb
    {
        private const int SIZE = 20;
        private int _x;
        private int _y;

        /// <summary>
        /// Initialise the object to the value values passed in
        /// </summary>
        /// <param name="x">The x position of the centre of the bomb</param>
        /// <param name="y">The y position of the centre of the bomb</param>
        public Bomb(int x, int y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Gets the x position of the bomb
        /// </summary>
        public int X
        {
            get { return _x; }
        }

        /// <summary>
        /// Gets the y position of the bomb
        /// </summary>
        public int Y
        {
            get { return _y; }
        }

        /// <summary>
        /// Moves the bomb down the graphics area
        /// </summary>
        /// <param name="amount">The amount to move the bomb by</param>
        public void Move(int amount)
        {
            _y += amount;
        }

        /// <summary>
        /// Draws a bomb centred around it's x and y position
        /// </summary>
        /// <param name="paper"></param>
        public void Display(Graphics paper)
        {
            SolidBrush br = new SolidBrush(Color.Black);
            paper.FillEllipse(br, _x - SIZE / 2, _y - SIZE / 2, SIZE, SIZE);
        }
    }
}
