using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public static class GameExtension
    {
        public static Apple CreateApple()
        {
            var rows = 20;
            var colums = 20;
            var random = new Random();
            var top = random.Next(0, rows + 1);
            var left = random.Next(0, colums + 1);
            return new Apple(new Position(top, left));
        }

        public static void Render(this Apple apple)
        {
            Console.SetCursorPosition(apple.Position.Left, apple.Position.Top);
            Console.Write("🍏")
        }

        public static Direction OppositeDirection(this Direction direction)
        {
            direction switch
            {
                Direction.Up => Direction.Down,
                Direction.Down => Direction.Up,
                Direction.Left => Direction.Right,
                Direction.Right => Direction.Left,
                _ => throw new Exeption()
            };
        }

        public static void Render(this Snake snake, Game game)
            {
                game.RotateSnakeIfBounds();
                Console.SetCursorPosition(snake.Head.Left, snake.Head.Top);
                Console.Write("😊");
                foreach (var elem in snake.Body)
                {
                    Console.SetCursorPosition(elem.Left, elem.Top);
                    Console.Write("🎲");
                }
            }

        private static void RotateSnakeIfBounds(this Game game)
        {
            if (game.Snake.Head.Left == Console.WindowWidth - 6 || game.Snake.Head.Left == 0 ||
                game.Snake.Head.Top == Console.WindowHeight - 6 || game.Snake.Head.Top == 0)
                game.NextDirection = game.CurrentDirection.OppositeDirection();
        }
    }
}
