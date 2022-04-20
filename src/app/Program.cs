using CommandLine;
using ElBastard0.GameOfLife.Models.Environment;
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
                    IGameField<bool> game = new GameField(width: o.Width, heigth: o.Height);
                    game.Initialize(o.StartPopulation);
                    game.PrintGameField();

                    while (true)
                    {
                        game.Update(true);
                        Thread.Sleep(o.Refresh);
                    }
                });
        }
    }
}