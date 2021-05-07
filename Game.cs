using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invaders
{
    class Game
    {
        private Random rand = new Random();
        private Stars stars;
        private Rectangle boundaries;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip;
        //private List<Shot> playerShot;
        //private List<Shot> invaderShots;

        public Game(Rectangle boundaries) 
        {
            this.boundaries = boundaries;
            stars = new Stars(boundaries, rand);
            playerShip = new PlayerShip(new Point(boundaries.Height - 150, boundaries.Width/2 + 50));
        }

        public void Draw(Graphics g) 
        {
            stars.Draw(g);
            playerShip.Draw(g);
        }
        public void Twinkle() 
        {
            stars.Twinkle();
        }

        public void MovePlayer(Direction direction) 
        {
            playerShip.Move(direction);
        }

        public void FireShot() 
        {

        }

        public void Go() 
        {
            
            foreach (Invader invader in invaders) {
                if (invader.Location.X >= boundaries.Width) 
                {

                }
                invader.Move(direction);
            }
            
        }

    }
}
