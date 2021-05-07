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
        private const int VerticalInterval = 40; //constants determines how many pixels invader moves
        public enum Type
        {
            Bug,
            Saucer,
            Satallite,
            Spaceship,
            Star,
        }

        private Bitmap image;

        private List<Invader> invaders;
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
        public Type Star { get; private set; }

        public Invader(Type invaderType, Point location, int score) {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            this.image = InvaderImage(0);
        }

        public void Move(Direction direction) {
            //moves the ship in the specific direction
        }

        public void Draw(Graphics g, int animationCell) {
            g.DrawImage(InvaderImage(animationCell), this.Location);
            //draws the image of the ship, using the correct animationCell
        }
        
        private Bitmap InvaderImage(int animationCell)  {

            switch (animationCell) 
            {
                case 0:
                    return Properties.Resources.star1;
                case 1:
                    return Properties.Resources.star2;
                case 2:
                    return Properties.Resources.star3;
                case 3:
                    return Properties.Resources.star4;
                default:
                    return Properties.Resources.star1;
            }
            //return the right bitmap for the specified cell
        }

        private void CreateColumn(int x) 
        {
            invaders.Add(new Invader(Type.Star, new Point(100 - x, 100), 10));
            invaders.Add(new Invader(Type.Spaceship, new Point(100 - x, 90), 20));
            invaders.Add(new Invader(Type.Saucer, new Point(100 - x, 80), 30));
            invaders.Add(new Invader(Type.Satallite, new Point(100 - x , 70), 40));
            invaders.Add(new Invader(Type.Bug, new Point(100 - x, 60), 50));

        }

        private void NextWave() 
        {
            invaders = new List<Invader>();
            for (int i = 0; i <= 6; i++) {
                CreateColumn(10 * i);
            }

        }
        

    }
}
