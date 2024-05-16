using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Arkanoid_IT2
{
    public class Ball : GameObject
    {
        // co by mel mit ball za vlastnosti:
        // velikost, rychlost pohybu, pohyb (x, y), barvu

        public int Size { get; set; }

        public Vector VectorMove { get; set; }
        //public SolidColorBrush color;

        // double speed, double xpos, double ypos, SolidColorBrush brush
        // Speed = speed;
        // XPos = xpos;
        // YPos = ypos;
        // color = brush;
        public Ball(int size)
        {
            Size = size;

        }

        public override void Draw(Canvas canvas)
        {
            //Ellipse ball = new Ellipse
            //{
            //    Width = Size,
            //    Height = Size,
            //    Fill = Brushes.White,
            //};
            //Canvas.SetLeft(ball, Location.X + Size);
            //Canvas.SetTop(ball, Location.Y + Size);

            //canvas.Children.Add(ball);

            Ellipse ellipse = new Ellipse();
            ellipse.Width = Size;
            ellipse.Height = Size;
            ellipse.Fill = Brushes.White;
            Canvas.SetBottom(ellipse, Location.Y - Size / 2);
            Canvas.SetLeft(ellipse, Location.X - Size / 2);
            canvas.Children.Add(ellipse);

        }

        public void Move()
        {
            Location.Offset(VectorMove.X, VectorMove.Y);
        }

    }
}
