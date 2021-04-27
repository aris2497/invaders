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

        private List<Star> Stars_list;
        private int x;
        private int y;
        private Pen MyPen = new Pen(Color.Black);

        public Stars(Rectangle rect, Random rand) 
        {
            Stars_list = new List<Star>();
            for (int i = 0; i < 300; i++) {
                x = rand.Next(100);
                y = rand.Next(100);
                Stars_list.Add(new Star(new Point(x, y), MyPen));
            }
        }

        public void Draw(Graphics g) 
        {
            for (int i = 0; i < Stars_list.Count; i++) {
                Console.WriteLine(Stars_list[i].point);
                g.DrawLine(Stars_list[i].pen, Stars_list[i].point, Stars_list[i].point);
                
            }
            
            //should draw all the stars from the list
        }
        public void Twinkle(Random random) { }

    }

}
