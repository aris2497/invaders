using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invaders
{
    class Shot
    {
        public Point Location;
        public Size Size { get; private set; } = new Size(5, 20);
        private SolidBrush myBrush = new SolidBrush(Color.White);
        private int speed = 5;

        public Shot(Rectangle location) 
        {
            this.Location = new Point(location.X, location.Y);
            
        }

        public void Move()
        {
            this.Location = new Point(this.Location.X, this.Location.Y - speed);
        }

        public void Draw(Graphics g) 
        {
            g.FillRectangle(myBrush, new Rectangle(this.Location, this.Size));
        }
    }

    
}
