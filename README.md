# Console Games & Utilities

This project is a simple console application written in C# that offers a variety of games and utilities, including a number guessing game, a simple calculator, a word reversal game, and a bitwise operation game. The application provides a basic interface where users can select an activity from a menu and interact with the program directly through the console.

## Features

1. **Number Guessing Game**
   - Guess the secret number between 1 and 10.
   - You have three attempts to guess correctly.
   - Validates user input to ensure it's an integer.

2. **Simple Calculator**
   - Perform basic arithmetic operations: addition, subtraction, multiplication, and division.
   - Supports input validation for integers and decimal numbers.
   - Handles division by zero gracefully.

3. **Word Reversal Game**
   - Enter a word and see it reversed.
   - Validates that the input is a non-empty string.

4. **Bitwise Operation Game**
   - Perform bitwise operations on two integers: AND, OR, XOR, NOT, LEFT SHIFT, RIGHT SHIFT.
   - Supports input validation for integers.
   - Provides clear output for each operation.

## How to Use

1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/ConsoleGamesUtilities.git
   ```
2. **Open the Project**
   - Open the project in Visual Studio or any C# compatible IDE.

3. **Run the Program**
   - Run the project, and a console window will appear with the main menu.
   - Choose a game or utility by entering the corresponding number.
   - Follow the on-screen instructions for each game or utility.

4. **Navigate the Menu**
   - After completing a game, you will be returned to the main menu to select another game or exit.

## Code Overview

- **Program.cs**: The main entry point of the application containing all the game logic.
  - **Main Menu**: The main loop that displays the menu and processes user input.
  - **NumberGuessingGame()**: Implements the number guessing game.
  - **SimpleCalculator()**: Implements the simple calculator.
  - **WordReversalGame()**: Implements the word reversal game.
  - **BitwiseGame()**: Implements the bitwise operations game.

## Requirements

- .NET SDK (version 6.0 or later)
- A C# compatible IDE (e.g., Visual Studio, JetBrains Rider, Visual Studio Code)

## Contributing

Contributions are welcome! If you have ideas for new games or improvements to the existing ones, feel free to fork the repository and submit a pull request.

1. Fork the project.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add your feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.
