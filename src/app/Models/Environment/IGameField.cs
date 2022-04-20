namespace ElBastard0.GameOfLife.Models.Environment
{
    internal interface IGameField<TField> : IDictionary<int, IList<TField>>
    {
        int Width { get; init; }
        int Height { get; init; }

        void Initialize(int startPopulation=10);
        void Update(bool print = false);
        void PrintGameField();
    }
}
