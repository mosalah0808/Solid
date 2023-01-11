using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Game
{
    public class GameInitConfig : GameInit
    {
        private IConfig _config;
        public GameInitConfig(int maxDigit, int numberOfTry, IConfig config) : base(maxDigit, numberOfTry)
        {
            _config = config;
            Update();
        }

        private void Update()
        {
            _maxNumber = _config.GetMax();
            _numberOfTry = _config.GetGuessCount();
        }
    }
}
