
using static System.Console;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main()
        {
        Start:
            while (true)
            {
                Clear();
                WriteLine("Select a game:");
                WriteLine("1. Number Guessing Game");
                WriteLine("2. Simple Calculator");
                WriteLine("3. Word Reversal Game");
                WriteLine("4. Bitwise Game");
                WriteLine("5. Exit");

                string choice = ReadLine();

                switch (choice)
                {
                    case "1":
                        NumberGuessingGame();
                        goto Start;

                    case "2":
                        SimpleCalculator();
                        goto Start;

                    case "3":
                        WordReversalGame();
                        goto Start;

                    case "4":
                        BitwiseGame();
                        goto Start;

                    case "5":
                        WriteLine("Exiting...");
                        return;

                    default:
                        WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        WriteLine("Press any key to continue...");
                        ReadKey();
                        goto Start;
                }
            }
        }

        static void NumberGuessingGame()
        {
            const int SECRET_NUMBER = 7;
            bool isGuessedCorrectly = false;

            Clear();
            WriteLine("Guess the secret number between 1 and 10");

            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Write($"Attempt {attempt}: Enter your guess: ");
                string input = ReadLine();

                bool isValidInteger = true;
                foreach (char c in input)
                {
                    if (!char.IsDigit(c) && c != '-' && c != '+')
                    {
                        isValidInteger = false;
                        break;
                    }

                    // FARESHAXXAN@GMAIL.COM
                }

                if (isValidInteger)
                {
                    var userGuess = int.Parse(input);

                    if (userGuess == SECRET_NUMBER)
                    {
                        WriteLine("Congratulations! You guessed the number correctly.");
                        isGuessedCorrectly = true;
                        break;
                    }
                    else
                    {
                        WriteLine("Incorrect guess. Try again.");
                    }
                }
                else
                {
                    WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (!isGuessedCorrectly)
            {
                WriteLine("Sorry, you did not guess the number. The secret number was 7.");
            }

            WriteLine("Press Enter to return to the main menu...");
            ReadLine();
        }
        static void SimpleCalculator()
        {
            Clear();
            WriteLine("Simple Calculator");

            Write("Enter the first number: ");
            string input1 = ReadLine();
            Write("Enter the second number: ");
            string input2 = ReadLine();

            bool isValidDouble1 = true;
            bool isValidDouble2 = true;
            bool decimalFound = false;



            foreach (char c in input1)
            {
                if (c == '.')
                {
                    if (decimalFound)
                    {
                        isValidDouble1 = false;
                        break;
                    }
                    decimalFound = true;
                }
                else if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    isValidDouble1 = false;
                    break;
                }
            }

            decimalFound = false;
            foreach (char c in input2)
            {
                if (c == '.')
                {
                    if (decimalFound)
                    {
                        isValidDouble2 = false;
                        break;
                    }
                    decimalFound = true;
                }
                else if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    isValidDouble2 = false;
                    break;
                }
            }

            if (isValidDouble1 && isValidDouble2)
            {
                double num1 = double.Parse(input1);
                double num2 = double.Parse(input2);

                WriteLine("Select an operation: +, -, *, /");
                string operation = ReadLine();

                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            WriteLine("Error: Division by zero.");
                            validOperation = false;
                        }
                        break;
                    default:
                        WriteLine("Invalid operation.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    WriteLine($"Result: {result}"); // $"BFDBDFBADFB {}"
                }
            }
            else
            {
                WriteLine("Invalid input. Please enter valid numbers.");
            }

            WriteLine("Press Enter to return to the main menu...");
            ReadLine();
        }
        static void WordReversalGame()
        {
            Clear();
            WriteLine("Word Reversal Game");

            Write("Enter a word to reverse: ");
            string word = ReadLine();

            if (!string.IsNullOrEmpty(word))
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                WriteLine($"Reversed word: {reversedWord}");
            }
            else
            {
                WriteLine("Invalid input. Please enter a non-empty word.");
            }

            WriteLine("Press Enter to return to the main menu...");
            ReadLine();
        }
        static void BitwiseGame()
        {
            Clear();
            WriteLine("Bitwise Game");

            Write("Enter the first integer: ");
            var input1 = ReadLine();
            Write("Enter the second integer: ");
            var input2 = ReadLine();

            var isValidInteger1 = true;
            var isValidInteger2 = true;

            foreach (var c in input1)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    isValidInteger1 = false;
                    break;
                }
            }

            if (input2 != null)
            {
                foreach (var c in input2)
                {
                    if (!char.IsDigit(c) && c != '-' && c != '+')
                    {
                        isValidInteger2 = false;
                        break;
                    }
                }

                if (isValidInteger1 && isValidInteger2)
                {
                    var num1 = int.Parse(input1);
                    var num2 = int.Parse(input2);

                    WriteLine(
                        "Select a bitwise operation: & (AND), | (OR), ^ (XOR), ~ (NOT), << (LEFT SHIFT), >> (RIGHT SHIFT)");
                    var operation = ReadLine();

                    var result = 0;
                    var validOperation = true;

                    switch (operation)
                    {
                        case "&":
                            result = num1 & num2;
                            WriteLine($"{num1} & {num2} = {result}");
                            break;
                        case "|":
                            result = num1 | num2;
                            WriteLine($"{num1} | {num2} = {result}");
                            break;
                        case "^":
                            result = num1 ^ num2;
                            WriteLine($"{num1} ^ {num2} = {result}");
                            break;
                        case "~":
                            result = ~num1;
                            WriteLine($"~{num1} = {result}");
                            break;
                        case "<<":
                            Write("Enter the number of positions to shift left: ");
                            var shiftLeft = ReadLine();
                            var isValidShiftLeft = true;

                            foreach (var c in shiftLeft)
                            {
                                if (!char.IsDigit(c) && c != '-' && c != '+')
                                {
                                    isValidShiftLeft = false;
                                    break;
                                }
                            }

                            if (isValidShiftLeft)
                            {
                                result = num1 << int.Parse(shiftLeft);
                                WriteLine($"{num1} << {shiftLeft} = {result}");
                            }
                            else
                            {
                                WriteLine("Invalid shift amount. Please enter a valid integer.");
                                validOperation = false;
                            }

                            break;
                        case ">>":
                            Write("Enter the number of positions to shift right: ");
                            var shiftRight = ReadLine();
                            var isValidShiftRight = true;

                            foreach (var c in shiftRight)
                            {
                                if (!char.IsDigit(c) && c != '-' && c != '+')
                                {
                                    isValidShiftRight = false;
                                    break;
                                }
                            }

                            if (isValidShiftRight)
                            {
                                result = num1 >> int.Parse(shiftRight);
                                WriteLine($"{num1} >> {shiftRight} = {result}");
                            }
                            else
                            {
                                WriteLine("Invalid shift amount. Please enter a valid integer.");
                                validOperation = false;
                            }

                            break;
                        default:
                            WriteLine("Invalid operation.");
                            validOperation = false;
                            break;
                    }

                    if (!validOperation)
                    {
                        WriteLine("Operation failed. Please try again.");
                    }
                }
                else
                {
                    WriteLine("Invalid input. Please enter valid integers.");
                }
            }

            WriteLine("Press Enter to return to the main menu...");
            ReadLine();
        }
    }
}
