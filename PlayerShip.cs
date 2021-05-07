using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invaders
{
    class PlayerShip
    {
        public Point Location { get; private set; }

        private const int HorizontalInterval = 10;
        public bool Alive { get; private set; } = true;
        public Pen MyPen = new Pen(Color.Red);

        private Bitmap Image;

        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, Image.Size);
            }
        }
        public PlayerShip(Point location)
        {
            this.Location = location;
            this.Image = Properties.Resources.player;
        }

        public void Draw(Graphics g) {
            
            if (Alive) 
            {
                Console.WriteLine(this.Location);
                //resets the deadShipHeight field and darw the ship
                g.DrawImage(this.Image, this.Location);
            }
            else {
                
                
            }
        }

        public void Move(Direction direction) {
            if (direction == Direction.Left)
            {
                this.Location = new Point(Location.X - HorizontalInterval, Location.Y);
            }
            else if (direction == Direction.Right) 
            {
                this.Location = new Point(Location.X + HorizontalInterval, Location.Y);
            }
        }
    }
}
