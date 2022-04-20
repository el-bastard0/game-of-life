using CommandLine;

namespace ElBastard0.GameOfLife.Options
{
    internal class CliOptions
    {
        private int _startPopulation = 0;

        [Option('w', "width", Default = 200, HelpText = "Game field width")]
        public int Width { get; set; }

        [Option('h', "height", Default = 45, HelpText = "Game field height")]
        public int Height { get; set; }

        [Option('p', "population", HelpText = "Initial population")]
        public int StartPopulation
        {
            get
            {
                if (_startPopulation == 0)
                {
                    _startPopulation = Width * Height / 2;
                }
                return _startPopulation;
            }
            set { _startPopulation = value; }
        }

        [Option('r', "refresh", Default = 100, HelpText = "Refresh cycle in ms")]
        public int Refresh { get; set; }
    }
}
