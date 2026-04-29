Feature: Score a bowling game
  As an avid bowler
  I want to correctly score a game
  So that I can see my progress

Scenario: Score a game of all gutter balls
  Given I have rolled gutter balls in every frame
  When I calculate the score for this game
  Then I see a score of 0 for this game

Scenario: Score a game of all open frames
  Given I have completed the game
  | Roll1 | Roll2 |
  |     1 |     7 |
  |     6 |     1 |
  |     1 |     0 |
  |     3 |     0 |
  |     4 |     5 |
  |     6 |     0 |
  |     5 |     3 |
  |     3 |     2 |
  |     8 |     0 |
  |     3 |     4 |
  When I calculate the score for this game
  Then I see a score of 62 for this game

Scenario: Score a game of both open frames and spares
  Given I have completed the game
  | Roll1 | Roll2 |
  |     3 |     0 |
  |     8 |     1 |
  |     8 |     2 |
  |     0 |    10 |
  |     6 |     0 |
  |     7 |     0 |
  |     8 |     2 |
  |     2 |     0 |
  |     9 |     0 |
  |     2 |     4 |
  When I calculate the score for this game
  Then I see a score of 80 for this game

Scenario: Score a game of strikes, spares, and open frames
  Given I have completed the game
  | Roll1 | Roll2 |
  |     6 |     0 |
  |     5 |     2 |
  |    10 |       |
  |     3 |     7 |
  |     9 |     0 |
  |     6 |     4 |
  |    10 |       |
  |     7 |     3 |
  |     3 |     4 |
  |     1 |     5 |
  When I calculate the score for this game
  Then I see a score of 127 for this game
