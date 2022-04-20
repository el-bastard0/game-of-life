using ElBastard0.GameOfLife.Models.Environment;
using ElBastard0.GameOfLife.Utils;
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
            IGameField<bool> game = new GameField(width: 200, heigth: 45);
            game.Initialize(2000);
            game.PrintGameField();

            while (true)
            {
                game.Update(true);
                Thread.Sleep(GameSettings.RefreshTimer);
            }
        }
    }
}