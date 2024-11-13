# Rock Paper Scissors Game

This is a simple **Rock, Paper, Scissors** game built with **C#** and **Windows Forms**. The game allows the player to compete against the computer, with the goal of being the first to reach 3 points.

## Features

- **Player vs Computer:** The player selects Rock, Paper, or Scissors, and the computer randomly chooses one as well.
- **Dynamic Scoring:** The score is updated after each round. The first player (either human or computer) to reach 3 points wins.
- **Game Rules:** The game follows the classic rules:
  - Rock beats Scissors
  - Scissors beat Paper
  - Paper beats Rock
- **Round History:** The choices for each round are displayed, along with who won the round.
- **Reset Button:** Resets the game to allow the player to start over.

## Game Rules

1. **Rock** beats **Scissors** and loses to **Paper**.
2. **Scissors** beat **Paper** but lose to **Rock**.
3. **Paper** beats **Rock**, but loses to **Scissors**.
4. The game ends when either the player or the computer reaches 3 points.
5. To make a choice, click on the pictures (Rock, Paper, or Scissors) on the left.

## Installation

### Prerequisites
- **Microsoft Visual Studio** (or any C# IDE)
- **.NET Framework** (or **.NET 5/6** if using newer versions)

### Steps to Run the Game

1. Clone the repository:
    ```bash
    git clone https://github.com/M-Orxan/rock-paper-scissors-game-windows-forms.git
    ```

2. Open the project in **Visual Studio** or your preferred C# development environment.

3. Build and run the project. The game should appear in a Windows Form window.

4. Click on one of the images (Rock, Paper, or Scissors) to make your choice. The game will automatically show the result of the round.

5. Use the **Reset** button to start a new game after either player wins.

## How It Works

- **Choices:** The game uses pictures as the player’s input. When the player clicks on an image (Rock, Paper, or Scissors), the `ShowChoices` method determines their selection.
- **Computer's Choice:** The computer's choice is randomly selected from the same options.
- **Score Calculation:** The game compares the player's and computer's choices to determine the winner and update the score. The first player to score 3 points wins.
- **Round Tracking:** The choices and results are displayed for each round. The labels for each round dynamically update as the game progresses.
