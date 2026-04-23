using Reqnroll;
using Xunit;
using BowlingWithAI.Domain;

namespace BowlingWithAI.AcceptanceTests;

[Binding]
public class ScoreBowlingSteps
{
    private readonly Game _game = new();
    private int _score;

    [Given("I have rolled gutter balls in every frame")]
    public void GivenIHaveRolledGutterBallsInEveryFrame()
    {
        for (int frame = 0; frame < 10; frame++)
        {
            _game.Roll(0);
            _game.Roll(0);
        }
    }

    [When("I calculate the score for this game")]
    public void WhenICalculateTheScoreForThisGame()
    {
        _score = _game.Score();
    }

    [Then("I see a score of {int} for this game")]
    public void ThenISeeAScoreOf(int expectedScore)
    {
        Assert.Equal(expectedScore, _score);
    }
}
