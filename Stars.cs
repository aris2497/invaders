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
        private Pen MyPen = new Pen(Color.White);
        private Size size = new Size(5, 5);
        private Random rand = new Random();
        private int random;
        private SolidBrush brush = new SolidBrush(Color.White);
        

        public Stars(Rectangle rect, Random rand) 
        {
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
            for (int i = 0; i < Stars_list.Count; i++) {
                
                g.FillEllipse(brush, new Rectangle(Stars_list[i].point, RandomSize()));
                
            }
            brush.Dispose();
        }
        public void Twinkle(Random random) { }

        public Size RandomSize() 
        {
            random = rand.Next(0, 4);
            return new Size(random, random);
        }

    }

}
