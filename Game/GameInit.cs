

using Game.Interfaces;

namespace Game.Game
{
    public class GameInit : IWrite
    {
        private IGenerator _generator;
        private Guess _guess;

        public int _maxNumber;
        public int _numberOfTry;

        public GameInit(int maxDigit, int numberOfTry)
        {
            _maxNumber = maxDigit;
            _numberOfTry = numberOfTry;
        }

       

        public void Start()
        {

            _generator = new Generator();
            _guess = new Guess(_generator);
            
            int numberguess = _generator.GetNumber(_maxNumber);
            int digit;
            while (_numberOfTry > _guess.TryCount)
            {
                WriteGuessResult("Введите загаданное число:");
                if (int.TryParse(Console.ReadLine(), out digit))
                {
                    if (_guess.TryGuess(digit, numberguess))
                    {
                        break;
                    }
                }
            }

            WriteGuessResult("Конец игры.");
           
        }

        public void WriteGuessResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}
