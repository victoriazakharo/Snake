using System;
using System.Drawing;

namespace Snake
{
    public class Game
    {
        private readonly int m_Width;
        private readonly int m_Height;
        private readonly Snake m_Snake;
        private readonly Piece m_Food;
        private readonly Random m_Rnd;

        public Game(int width, int height)
        {
            m_Width = width;
            m_Height = height;
            m_Snake = new Snake(Brushes.MidnightBlue);
            m_Rnd = new Random();
            m_Food = new Piece(0, 0, Brushes.Violet);
            Restart();
        }

        public void Restart()
        {
            m_Snake.Clear();
            GenerateFood();
        }

        public void Draw(Graphics g)
        {
            m_Snake.Draw(g);
            m_Food.Draw(g);
        }

        public int GetScore()
        {
           return m_Snake.ScoreLength;
        }

        public bool SnakeHasGrown()
        {
            switch (m_Snake.Direction)
            {
                case Direction.Down:
                    return TryEat(0, 1);
                case Direction.Up:
                    return TryEat(0, -1);
                case Direction.Right:
                    return TryEat(1, 0);
                case Direction.Left:
                    return TryEat(-1, 0);
            }
            return false;
        }

        public bool Lost()
        {
            return m_Snake.HeadX > m_Width || m_Snake.HeadX < 0 || m_Snake.HeadY > m_Height || m_Snake.HeadY < 0 || m_Snake.EatsItself();
        }

        public void ChangeSnakeDIrection(Direction direction)
        {
            m_Snake.Direction = direction;
        }

        private bool TryEat(int a, int b)
        {
            if (m_Snake.CanEat(a, b, m_Food))
            {
                m_Snake.Eat(m_Food);
                GenerateFood();
                return true;
            }
            m_Snake.MoveTo(a, b);
            return false;
        }

        private void GenerateFood()
        {
            var a = m_Rnd.Next(0, m_Width);
            var b = m_Rnd.Next(0, m_Height);
            if (m_Snake.Contains(a, b))
            {
                GenerateFood();
            }
            m_Food.X = a;
            m_Food.Y = b;
        }
    }
}
