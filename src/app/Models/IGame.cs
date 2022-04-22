using ElBastard0.GameOfLife.Utils;

namespace ElBastard0.GameOfLife.Models
{
    internal interface IGame<TField> : IDictionary<int, IList<TField>>
    {
        int Width { get; init; }
        int Height { get; init; }
        GameState State { get; set; } 
        void Initialize(int startPopulation=10);
        void Update(bool print = false);
        void PrintGameField();
    }
}
