using CommandLine;

namespace ElBastard0.GameOfLife.Options
{
    internal class CliOptions
    {
        private int? _startPopulation;

        [Option('w', "width", Default = 100, HelpText = "Game field width")]
        public int Width { get; set; }

        [Option('h', "height", Default = 40, HelpText = "Game field height")]
        public int Height { get; set; }

        [Option('p', "population", HelpText = "(Default: Width * Height / 2) Initial population")]
        public int StartPopulation
        {
            get
            {
                return _startPopulation ?? Width * Height / 2;
            }
            set
            {
                _startPopulation = value;
            }
        }

        [Option('r', "refresh", Default = 100, HelpText = "Refresh cycle in ms")]
        public int Refresh { get; set; }
    }
}
