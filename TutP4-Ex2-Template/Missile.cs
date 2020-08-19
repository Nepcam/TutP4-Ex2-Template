using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutP4_Ex2_Template
{
    class Missile
    {
        // fields ********************
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
    }
}
