Feature: Score a bowling game
  As an avid bowler
  I want to correctly score a game
  So that I can see my progress

Scenario: Score a game of all gutter balls
  Given I have rolled gutter balls in every frame
  When I calculate the score for this game
  Then I see a score of 0 for this game
