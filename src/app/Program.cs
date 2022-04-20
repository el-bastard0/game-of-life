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
            IGameField<bool> test = new GameField(width: 200, heigth: 40);
            
            foreach (var key in test.Keys)
            {
                for(int i = 0; i < test.Width; i++)
                {
                    test[key][i] = true;
                    test.PrintGameField();
                    Thread.Sleep(GameSettings.RefreshTimer);
                }
            }
        }
    }
}