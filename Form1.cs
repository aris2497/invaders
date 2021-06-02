using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invaders
{
    public partial class Form1 : Form
    {
        private Rectangle boundaries;
        private Game game;
        public Random rand;
        List<Keys> keysPressed = new List<Keys>();
        private int animationCell = 0;

        private bool gameOver = false;

        public Form1()
        {
            InitializeComponent();

            boundaries = Screen.GetBounds(this);
            rand = new Random();
            

            game = new Game(boundaries);
            
            animationTimer.Start();
            gameTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void animationTimer_Tick_1(object sender, EventArgs e)
        {
            game.Twinkle(); //background stars twinkling
            Refresh(); //repainting the background

            animationCell++;
            if (animationCell > 6) 
            {
                animationCell = 0;
            }
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics, animationCell); //drawing background stars
            if (gameOver){

                //writing the game is over in the middle of the screen
                //hiting S to start again
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) //if want to Quit
                Application.Exit(); 

            if (gameOver) 
                if(e.KeyCode == Keys.S) //to restart the game
                {
                    //to reset the game and restart the timers

                    return;
                }
                if (e.KeyCode == Keys.Space) //spacebar fires a shot 
                    game.FireShot();
                if (keysPressed.Contains(e.KeyCode)) //if the list already contains the key - remove
                    keysPressed.Remove(e.KeyCode);
                keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode)) //removing realised key from the pressed keys list
                keysPressed.Remove(e.KeyCode);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!gameOver) 
            {
                if (keysPressed.Count() >= 1)
                {
                    //zero is the most recent key pressed
                    switch (keysPressed[0])
                    {
                        case Keys.Left:
                            game.MovePlayer(Direction.Left); //moving player to the left
                            break;
                        case Keys.Right:
                            game.MovePlayer(Direction.Right); //moving player to the right
                            break;

                    }
                }
                game.Go(); //to let the game continue
            }
          
        }
    }
}
