using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutP4_Ex2_Template
{
    class Missile
    {
        // fields ********************
        private const int WIDTH = 4;
        private const int HEIGHT = 8;
        private int _x;
        private int _y;

        // constructor ********************
        /// <summary>
        /// Initialise the object to the value values passed in
        /// </summary>
        /// <param name="x">The x position of the centre of the missile</param>
        /// <param name="y">The y position of the centre of the missile</param>
        public Missile(int x, int y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Gets the x position of the missile
        /// </summary>
        public int X
        {
            get { return _x; }
        }

        /// <summary>
        /// Gets the y position of the missile
        /// </summary>
        public int Y
        {
            get { return _y; }
        }

        /// <summary>
        /// Moves the missiles up the graphics area
        /// </summary>
        /// <param name="pixels">The amount of pixels to move the missiles by</param>
        public void Move(int pixels)
        {
            _y -= pixels;
        }

        /// <summary>
        /// Draws the missile centred around it's x and y position
        /// </summary>
        /// <param name="paper">Where to draw the graphics</param>
        public void Display(Graphics paper)
        {
            SolidBrush br = new SolidBrush(Color.Red);
            if (Y % 20 >= 10)
            {
                br.Color = Color.Yellow;
            }
            paper.FillRectangle(br, X - WIDTH / 2, Y - HEIGHT / 2, WIDTH, HEIGHT);
        }
    }
}
