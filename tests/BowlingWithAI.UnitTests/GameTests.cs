using BowlingWithAI.Domain;

namespace BowlingWithAI.UnitTests;

public class GameTests
{
    [Fact]
    public void GutterGame_ScoresZero()
    {
        var game = new Game();

        for (int i = 0; i < 20; i++)
            game.Roll(0);

        Assert.Equal(0, game.Score());
    }
}
