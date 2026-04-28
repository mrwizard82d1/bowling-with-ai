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

    [Fact]
    public void Spare_AddsNextRollAsBonus()
    {
        var game = new Game();

        game.Roll(5);
        game.Roll(5); // spare
        game.Roll(3); // bonus roll
        for (int i = 0; i < 17; i++)
            game.Roll(0);

        Assert.Equal(16, game.Score());
    }
}
