using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutP4_Ex2_Template
{
    class Bomb
    {
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
    }
}
