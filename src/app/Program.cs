using CommandLine;
using ElBastard0.GameOfLife.Models;
using ElBastard0.GameOfLife.Options;
using System.Text;

namespace ElBastard0.GameOfLife
{
    internal static class Program
    {
        static Program()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CliOptions>(args)
                .WithParsed(o =>
                {
                    RunGame(o.Width, o.Height, o.StartPopulation, o.Refresh);
                });
        }

        private static void RunGame(int width, int height, int population, int refresh)
        {
            IGame<bool> game = new Game(width: width, heigth: height);
            game.Initialize(population);
            game.PrintGameField();

            while (true)
            {
                game.Update(true);
                Thread.Sleep(refresh);
            }
        }
    }
}