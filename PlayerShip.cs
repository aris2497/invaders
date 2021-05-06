using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invaders
{
    class PlayerShip : PictureBox
    {
        public Point Location { get; private set; }
        public bool Alive { get; private set; }

        private Bitmap image;

        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }
        public PlayerShip()
        {

        }

        public void Draw(Graphics g) {
            if (!Alive)
            {
                //resets the deadHipHeight field and darw the ship
            }
            else { 
                //checks the deadShipHeight field.
                //
            }
        }
    }
}
