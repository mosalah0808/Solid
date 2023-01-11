namespace Game.Interfaces
{
    public interface IGuess
    {
        bool TryGuess(int number, int guessnumber);
    }
}
