using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;

namespace Arkanoid_IT2
{
    public class Game
    {
        private Board board;
        private Ball ball;
        public List<GameObject> GameObjects { get; set; }
        //private Timer timerEngine;

        public Game()
        {
             //timerEngine = new Timer();
             //timerEngine.Interval = 20;
             //timerEngine.Elapsed += TimerEngine_Elapsed;
             GameObjects = new List<GameObject>();
             CreateLevel(1);
        }

        //private void TimerEngine_Elapsed(object? sender, ElapsedEventArgs e)
        //{
        //    ball.Move();
        //}

        public void CreateLevel(int level)
        {
               board = new Board(50);
               GameObjects.Add(board);
               ball = new Ball(20);
               ball.VectorMove = new Vector(1, 1);
               ball.Location = new Point(200, 200);
               GameObjects.Add(ball);
        }

        public void SetBoardLocation(double x)
        {
             board.Location = new Point(x, board.Location.Y);
        }

        public void SetBallLocation(double x, double y)
        {
            ball.Location = new Point(ball.Location.X, ball.Location.Y);
        }



        public void Draw(Canvas canvas)
        {
             foreach (GameObject obj in GameObjects)
             {
                  if (obj != null)
                  {
                   obj.Draw(canvas);
                  }
             }
        }
    }
}
