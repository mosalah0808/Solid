using Game.Interfaces;


namespace Game.Game
{
    internal class Guess : IGuess, IWrite
    {
        public Guess(IGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;
                
        }
        
        private IGenerator _numberGenerator;

        public int TryCount
        {
            get { return _tryCount;  }
           
        }

        private int _tryCount;

        public bool TryGuess(int number, int numberguess)
        {
           
            Console.WriteLine(numberguess);
            if (number == numberguess)
            {
                WriteGuessResult("Число угадано!");
                
                return true;
            }

            if (number < numberguess)
                WriteGuessResult("Число меньше загаданного!");

            if (number > numberguess)
                WriteGuessResult("Число больше загаданного!");

            _tryCount++;
            return false;
        }

        public void WriteGuessResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}
