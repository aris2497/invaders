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

        private List<Invader> invaders;

        private PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> playerShotsToRemove;
        private Direction direction;
        private bool turn = false;
        private List<Invader> invadersToRemove;

        private int level = 1;

        public Game(Rectangle boundaries) 
        {
            this.boundaries = boundaries;
            stars = new Stars(boundaries, rand);
            NextWave();
            direction = Direction.Right;
            playerShots = new List<Shot>();
            playerShotsToRemove = new List<Shot>();
            invadersToRemove = new List<Invader>();

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
            foreach (Shot shot in playerShots) 
            {
                shot.Draw(g);
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
            if (playerShots.Count <= 2)
            {
                playerShots.Add(new Shot(playerShip.Area));
            }
            
        }
        
        public void Go() 
        {
            foreach (Invader invader in invaders) 
            {
                if (!turn)
                {
                    direction = Direction.Right;
                    invader.Move(direction, boundaries);
                    if (invader.Location.X > (boundaries.Width - 50))
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
                    if (invader.Location.X < 50)
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

            foreach (Shot shot in playerShots) 
            {
                if (shot.Location.Y > 100)
                {
                    shot.Move();
                }
                else 
                {
                    playerShotsToRemove.Add(shot);
                }
            }

           

            foreach (Shot shot in playerShots)
            {
                if (shot.Location.Y > 100)
                {
                    shot.Move();
                }
                else
                {
                    playerShotsToRemove.Add(shot);
                }
            }

            foreach (Shot shot in playerShots)
            {
                foreach (Invader invader in invaders)
                {
                    if (DetectCollision(shot, invader))
                    {
                        playerShotsToRemove.Add(shot);
                        invadersToRemove.Add(invader);
                    }
                }
            }

            foreach (Shot shotToRemove in playerShotsToRemove)
            {
                playerShots.Remove(shotToRemove);
            }
            foreach (Invader invaderToRemove in invadersToRemove)
            {
                invaders.Remove(invaderToRemove);
            }

            if (!invaders.Any()) 
            {
                LevelUp();
                NextWave();
            }

        }

        private void LevelUp()
        {
            level++;

        }

        public bool DetectCollision(Shot shot, Invader invader)
        {
            Rectangle ctrl1Rect = new Rectangle(shot.Location, shot.Size);
            Rectangle ctrl2Rect = new Rectangle(invader.Location, invader.Image.Size);
            
            return ctrl1Rect.IntersectsWith(ctrl2Rect);
        }

        private void CreateColumn(int distance)
        {
            invaders.Add(new Invader(ShipType.Star, new Point(50 + distance, 450), 10));
            invaders.Add(new Invader(ShipType.Spaceship, new Point(50 + distance, 350), 20));
            invaders.Add(new Invader(ShipType.Saucer, new Point(50 + distance, 250), 30));
            invaders.Add(new Invader(ShipType.Satallite, new Point(50 + distance, 150), 40));
            invaders.Add(new Invader(ShipType.Bug, new Point(50 + distance, 50), 50));
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
