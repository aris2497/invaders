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
        private Direction direction;
        private bool turn = false;

        public Game(Rectangle boundaries) 
        {
            this.boundaries = boundaries;
            stars = new Stars(boundaries, rand);
            NextWave();
            direction = Direction.Right;
           
            playerShip = new PlayerShip(new Point(boundaries.Height - 150, boundaries.Width/2 - 50));

        }
    

        public void Draw(Graphics g, int animationCell) 
        {
            stars.Draw(g);
            playerShip.Draw(g);
            foreach (Invader invader in invaders)
            {
                invader.Draw(g, animationCell);
            }
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
            /*
                foreach (Invader invader in invaders) 
                {
                    if (!turn)
                    {
                        invader.MoveRight(direction, boundaries);
                        if (invader.Location.X > (boundaries.Width - 200))
                        {
                            turn = true;
                            foreach(Invader inv in invaders) 
                            { 
                                inv.MoveDown(); 
                            }
                            
                        }
                    }
                    else 
                    {
                        invader.MoveLeft(boundaries);
                        if (invader.Location.X < 100)
                        {
                            turn = false;
                            foreach (Invader inv in invaders)
                            {
                                inv.MoveDown();
                            }
                        }
                    }

                }
            */

            foreach (Invader invader in invaders) 
            {
                if (!turn)
                {
                    direction = Direction.Right;
                    invader.Move(direction, boundaries);
                    if (invader.Location.X > (boundaries.Width - 200))
                    {
                        direction = Direction.Down;
                        foreach (Invader inv in invaders)
                        {
                            inv.Move(direction, boundaries);
                        }

                        turn = true;
                    }
                }
                else
                {
                    direction = Direction.Left;
                    invader.Move(direction, boundaries);
                    if (invader.Location.X < 100)
                    {
                        direction = Direction.Down;
                        foreach (Invader inv in invaders)
                        {
                            inv.Move(direction, boundaries);
                        }

                        turn = false;
                    }
                }
                
            }
            

        }

        private void CreateColumn(int x)
        {
            invaders.Add(new Invader(ShipType.Star, new Point(50 + x, 450), 10));
            invaders.Add(new Invader(ShipType.Spaceship, new Point(50 + x, 350), 20));
            invaders.Add(new Invader(ShipType.Saucer, new Point(50 + x, 250), 30));
            invaders.Add(new Invader(ShipType.Satallite, new Point(50 + x, 150), 40));
            invaders.Add(new Invader(ShipType.Bug, new Point(50 + x, 50), 50));

        }

        private void NextWave()
        {
            invaders = new List<Invader>();
            for (int i = 0; i <= 6; i++)
            {
                CreateColumn(100*i);
            }
        }

    }
}
