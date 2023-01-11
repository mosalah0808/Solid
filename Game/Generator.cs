using Game.Interfaces;
using System.Security.Principal;

namespace Game.Game
{
    public class Generator : IGenerator
    {
       
        public int GetNumber(int max)
        {
            var rnd = new Random();
            return rnd.Next(0, max);
        }

   

    }
}
