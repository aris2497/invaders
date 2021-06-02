using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invaders
{
    class Stars
    {

        private List<Star> Stars_list;
        private int x;
        private int y;
        private Pen MyPen = new Pen(Color.White);
        private Size size = new Size(1, 1);
        private Random rand;
        private Rectangle rect;
        private List<Shot> playerShots;
        
        public Stars(Rectangle rect, Random rand) 
        {
            this.rand = rand;
            this.rect = rect;
            
            Stars_list = new List<Star>();
            for (int i = 0; i < 300; i++) 
            {
                x = rand.Next(rect.Width);
                y = rand.Next(rect.Height);
                Stars_list.Add(new Star(new Point(x, y), MyPen));
            }
        }

        public void Draw(Graphics g) 
        {
            foreach(Star star in Stars_list)
            {
                g.DrawRectangle(MyPen, new Rectangle(star.point, size));
            }
        }

        public void Twinkle() 
        {
            List<Star> starsToRemove = new List<Star>();
            for (int i = 0; i < 5; i++) {
                starsToRemove.Add(Stars_list[rand.Next(Stars_list.Count)]);
            }

            foreach (Star toRemove in starsToRemove) {
                Stars_list.Remove(toRemove);
            }

            for (int i = 0; i < 5; i++) {
                Stars_list.Add(new Star(new Point(rand.Next(rect.Width), rand.Next(rect.Height)), MyPen));
            }

        }

        private struct Star
        {
            public Point point;
            public Pen pen;

            public Star(Point point, Pen pen)
            {
                this.point = point;
                this.pen = pen;
            }
        }

    }
}
