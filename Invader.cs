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
        private const int HorizontalInterval = 5;
        private const int VerticalInterval = 50; //constants determines how many pixels invader moves
        
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
        public ShipType InvaderType { get; private set; }
        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, Image.Size);
            }
        }

        public int Score { get; private set; }
        public Type Star { get; private set; }
        public Bitmap Image { get => image; set => image = value; }

        public Invader(ShipType invaderType, Point location, int score) {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            this.Image = InvaderImage(0);
        }

        public void Move(Direction direction, Rectangle boundaries) 
        {
            switch (direction) 
            {
                case Direction.Left:
                    MoveLeft(boundaries);
                    break;
                case Direction.Right:
                    MoveRight(boundaries);
                    break;
                case Direction.Down:
                    MoveDown();
                    break;

            }
        }

        public void MoveRight(Rectangle boundaries) {
            this.Location = new Point(Location.X + HorizontalInterval, Location.Y);
            //moves the ship in the specific direction
        }
        public void MoveLeft(Rectangle boundaries)
        {
            this.Location = new Point(Location.X - HorizontalInterval, Location.Y);
            //moves the ship in the specific direction
        }

        public void MoveDown() 
        {
            this.Location = new Point(Location.X, Location.Y + VerticalInterval);
            //moves the ship in the specific direction
        }

        public void Draw(Graphics g, int animationCell) {
             g.DrawImage(InvaderImage(animationCell), this.Location);
            
            //draws the image of the ship, using the correct animationCell
        }
        
        private Bitmap InvaderImage(int animationCell)  
        {
            
            switch (InvaderType)
            {
                case ShipType.Bug:
                    return BugAnimation(animationCell);
                case ShipType.Saucer:
                    return SaucerAnimation(animationCell);
                case ShipType.Satallite:
                    return SatalliteAnimation(animationCell);
                case ShipType.Star:
                    return StarAnimation(animationCell);
                case ShipType.Spaceship:
                    return SpaceshipAnimation(animationCell);
                default:
                    return StarAnimation(animationCell);
            }

        }

        private Bitmap StarAnimation(int animationCell)
        {
            switch (animationCell)
            {
                case 0:
                    return Properties.Resources.star1;
                case 1:
                    return Properties.Resources.star1;
                case 2:
                    return Properties.Resources.star2;
                case 3:
                    return Properties.Resources.star2;
                case 4:
                    return Properties.Resources.star3;
                case 5:
                    return Properties.Resources.star3;

                default:
                    return Properties.Resources.star1;
            }
            //return the right bitmap for the specified cell
        }
        private Bitmap BugAnimation(int animationCell) 
        {
            switch (animationCell)
            {
                case 0:
                    return Properties.Resources.bug1;
                case 1:
                    return Properties.Resources.bug1;
                case 2:
                    return Properties.Resources.bug2;
                case 3:
                    return Properties.Resources.bug2;
                case 4:
                    return Properties.Resources.bug3;
                case 5:
                    return Properties.Resources.bug3;

                default:
                    return Properties.Resources.bug1;
            }
        }
        private Bitmap SaucerAnimation(int animationCell) 
        {
            switch (animationCell)
            {
                case 0:
                    return Properties.Resources.flyingsaucer1;
                case 1:
                    return Properties.Resources.flyingsaucer1;
                case 2:
                    return Properties.Resources.flyingsaucer2;
                case 3:
                    return Properties.Resources.flyingsaucer2;
                case 4:
                    return Properties.Resources.flyingsaucer3;
                case 5:
                    return Properties.Resources.flyingsaucer3;

                default:
                    return Properties.Resources.flyingsaucer1;
            }
        }
        private Bitmap SatalliteAnimation(int animationCell) 
        {
            switch (animationCell)
            {
                case 0:
                    return Properties.Resources.satellite1;
                case 1:
                    return Properties.Resources.satellite1;
                case 2:
                    return Properties.Resources.satellite2;
                case 3:
                    return Properties.Resources.satellite2;
                case 4:
                    return Properties.Resources.satellite3;
                case 5:
                    return Properties.Resources.satellite3;

                default:
                    return Properties.Resources.satellite1;
            }
        }
        private Bitmap SpaceshipAnimation(int animationCell) 
        {
            switch (animationCell)
            {
                case 0:
                    return Properties.Resources.spaceship1;
                case 1:
                    return Properties.Resources.spaceship1;
                case 2:
                    return Properties.Resources.spaceship2;
                case 3:
                    return Properties.Resources.spaceship2;
                case 4:
                    return Properties.Resources.spaceship3;
                case 5:
                    return Properties.Resources.spaceship3;

                default:
                    return Properties.Resources.spaceship1;
            }
        }

    }
}
