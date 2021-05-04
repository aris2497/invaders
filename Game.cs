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

        public Game(Rectangle boundaries) 
        {
            stars = new Stars(boundaries, rand);

        }

        public void Draw(Graphics g) 
        {
            stars.Draw(g);
        }
        public void Twinkle() 
        {
            stars.Twinkle();
        }

        public void MovePlayer(Direction direction) 
        {

        }

        public void FireShot() 
        {
        }

        public void Go() 
        { 
        }

    }
}
