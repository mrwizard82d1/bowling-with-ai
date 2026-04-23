namespace BowlingWithAI.Domain;

public class Game
{
    private readonly int[] _rolls = new int[21];
    private int _currentRoll;

    public void Roll(int pins)
    {
        _rolls[_currentRoll++] = pins;
    }

    public int Score()
    {
        return _rolls.Sum();
    }
}
