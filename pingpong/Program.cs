using System;
using System.Diagnostics;

namespace Pingpong
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the screen
            const int screenLength = 60;
            const int screenWidth = 20;
            const char screenBorder = '-'; 

            //creating the bars
            const int barLength = 3;
            const char leftBar = '|';
            const char rightBar = '|';

            //creating the ball
            const char ball = 'O';

            float speed = 5;
            float ballX = 30;
            float ballY = 10;
            int scoreLeft = 0;
            int scoreRight = 0;
            bool up;
            bool down;

            ConsoleKey key;

            //print the screen borders
            string line = string.Concat(Enumerable.Repeat(screenBorder, screenLength));

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(line);

                Console.SetCursorPosition(0, screenWidth);
                Console.WriteLine(line);

                int leftBarVector = 0;
                int rightBarVector = 0;

                //print the bars
                for (int i = 0; i < barLength; i++)
                {
                    Console.SetCursorPosition(0, i + 1 + leftBarVector);
                    Console.WriteLine(leftBar);

                    Console.SetCursorPosition(screenLength - 1, i + 1 + rightBarVector);
                    Console.WriteLine(rightBar);

                    while (!Console.KeyAvailable)
                    {

                    }

                    key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.UpArrow)
                    {
                        rightBarVector++;
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        rightBarVector--;
                    }
                    else if (key == ConsoleKey.S)
                    {
                        leftBarVector++;
                    }
                    else if (key == ConsoleKey.X)
                    {
                        leftBarVector--;
                    }

                }

                for (int j = 1; j < screenWidth; j++)
                {
                    Console.SetCursorPosition(0, j);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(screenLength - 1, j);
                    Console.WriteLine(" ");
                }



            }

            // ball movement
            // if ball touches either side of the wall it resets
            // score + 1 when ball touches the wall
            // if either of the score reaches 10 the game ends

           
        }

        
    } 
}



