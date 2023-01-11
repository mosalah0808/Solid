using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Game.Game
{
    internal class Config : IConfig
    {
        public int GetGuessCount()
        {
            Console.WriteLine("Введите максимальное число попыток: ");
            if (int.TryParse(Console.ReadLine(), out int input))
                return input;
            else
                return 5;
        }

        public int GetMax()
        {
            Console.WriteLine("Введите максимальное загадываемое число: ");
            if (int.TryParse(Console.ReadLine(), out int input))
                return input;
            else
                return int.MaxValue;
        }

    
    }
}
