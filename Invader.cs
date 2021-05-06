using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invaders
{
    class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;
        public enum Type
        {
            Bug,
            Saucer,
            Satallite,
            Spaceship,
            Star,
        }

        private Bitmap image;
        public Point Location { get; private set; }
        public Type InvaderType { get; private set; }
        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }
        public int Score { get; private set; }

        public Invader(Type invaderType, Point location, int score) {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            image = InvaderImage(0);
        }

        public void Move(Direction direction) {
            //moves the ship in the specific direction
        }

        public void Darw(Graphics g, int animationCell) {
            //draws the image of the ship, using the correct animationCell
        }

        private Bitmap InvaderImage(int animationCell)  {
            Bitmap bitmap; 
            //return the right bitmap for the specified cell
            return bitmap;
        }

    }
}
