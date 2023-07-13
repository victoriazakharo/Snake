using System.Drawing;

namespace Snake
{
    public class Piece
    {
        public static int SIDE = 25;
        
        public Brush Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Piece(int a, int b, Brush color)
        {
            X = a;
            Y = b;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Color, new Rectangle(X * SIDE, Y * SIDE, SIDE, SIDE));
        }
    }
}
