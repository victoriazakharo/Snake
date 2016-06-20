using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snake
{
    public enum Direction
    {
        Down,
        Up,
        Right,
        Left
    }

    public class Snake
    {
        public int HeadX => m_Pieces.Last().X;
        public int HeadY => m_Pieces.Last().Y;
        public int ScoreLength => m_Pieces.Count - 2;
        public Direction Direction { get; set; }

        private readonly Queue<Piece> m_Pieces;
        private readonly Brush m_Color;

        public Snake(Brush color)
        {
            m_Color = color;
            m_Pieces = new Queue<Piece>();
        }

        public void Draw(Graphics g)
        {
            foreach (var piece in m_Pieces)
            {
                piece.Draw(g);
            }
        }

        public bool CanEat(int a, int b, Piece food)
        {
            return food.X == HeadX + a && food.Y == HeadY + b;
        }

        public bool EatsItself()
        {
            var i = 0;
            return m_Pieces.Any(piece => i++ != m_Pieces.Count - 1 && HeadY == piece.Y && HeadX == piece.X);
        }

        public bool Contains(int a, int b)
        {
            return m_Pieces.Any(piece => piece.X == a && piece.Y == b);
        }

        public void Eat(Piece food)
        {
            m_Pieces.Enqueue(new Piece(food.X, food.Y, m_Color));
        }

        public void Clear()
        {
            m_Pieces.Clear();
            m_Pieces.Enqueue(new Piece(0, 0, m_Color));
            m_Pieces.Enqueue(new Piece(0, 1, m_Color));
            Direction = Direction.Down;
        }

        public void MoveTo(int a, int b)
        {
            m_Pieces.Enqueue(new Piece(HeadX + a, HeadY + b, m_Color));
            m_Pieces.Dequeue();
        }
    }
}
