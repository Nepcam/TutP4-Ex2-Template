using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutP4_Ex2_Template
{
    class Sprite
    {
        // fields
        protected int _x;
        protected int _y;

        // constructor
        /// <summary>
        /// Initialises the object to the values given
        /// </summary>
        /// <param name="x">The x position of the centre of the sprite</param>
        /// <param name="y">The y position of the centre of the sprite</param>
        public Sprite(int x, int y)
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
    }
}
