
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select a game:");
                Console.WriteLine("1. Number Guessing Game");
                Console.WriteLine("2. Simple Calculator");
                Console.WriteLine("3. Word Reversal Game");
                Console.WriteLine("4. Bitwise Game");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

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
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        goto Start;
                }
            }
        }

        static void NumberGuessingGame()
        {
            const int SECRET_NUMBER = 7;
            bool isGuessedCorrectly = false;

            Console.Clear();
            Console.WriteLine("Guess the secret number between 1 and 10");

            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.Write($"Attempt {attempt}: Enter your guess: ");
                string input = Console.ReadLine();

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
                        Console.WriteLine("Congratulations! You guessed the number correctly.");
                        isGuessedCorrectly = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect guess. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (!isGuessedCorrectly)
            {
                Console.WriteLine("Sorry, you did not guess the number. The secret number was 7.");
            }

            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }
        static void SimpleCalculator()
        {
            Console.Clear();
            Console.WriteLine("Simple Calculator");

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

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

                Console.WriteLine("Select an operation: +, -, *, /");
                string operation = Console.ReadLine();

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
                            Console.WriteLine("Error: Division by zero.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {result}"); // $"BFDBDFBADFB {}"
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }
        static void WordReversalGame()
        {
            Console.Clear();
            Console.WriteLine("Word Reversal Game");

            Console.Write("Enter a word to reverse: ");
            string word = Console.ReadLine();

            if (!string.IsNullOrEmpty(word))
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                Console.WriteLine($"Reversed word: {reversedWord}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-empty word.");
            }

            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }
        static void BitwiseGame()
        {
            Console.Clear();
            Console.WriteLine("Bitwise Game");

            Console.Write("Enter the first integer: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second integer: ");
            string input2 = Console.ReadLine();

            bool isValidInteger1 = true;
            bool isValidInteger2 = true;

            foreach (char c in input1)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    isValidInteger1 = false;
                    break;
                }
            }

            foreach (char c in input2)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    isValidInteger2 = false;
                    break;
                }
            }

            if (isValidInteger1 && isValidInteger2)
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);

                Console.WriteLine("Select a bitwise operation: & (AND), | (OR), ^ (XOR), ~ (NOT), << (LEFT SHIFT), >> (RIGHT SHIFT)");
                string operation = Console.ReadLine();

                int result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "&":
                        result = num1 & num2;
                        Console.WriteLine($"{num1} & {num2} = {result}");
                        break;
                    case "|":
                        result = num1 | num2;
                        Console.WriteLine($"{num1} | {num2} = {result}");
                        break;
                    case "^":
                        result = num1 ^ num2;
                        Console.WriteLine($"{num1} ^ {num2} = {result}");
                        break;
                    case "~":
                        result = ~num1;
                        Console.WriteLine($"~{num1} = {result}");
                        break;
                    case "<<":
                        Console.Write("Enter the number of positions to shift left: ");
                        string shiftLeft = Console.ReadLine();
                        bool isValidShiftLeft = true;

                        foreach (char c in shiftLeft)
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
                            Console.WriteLine($"{num1} << {shiftLeft} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid shift amount. Please enter a valid integer.");
                            validOperation = false;
                        }
                        break;
                    case ">>":
                        Console.Write("Enter the number of positions to shift right: ");
                        string shiftRight = Console.ReadLine();
                        bool isValidShiftRight = true;

                        foreach (char c in shiftRight)
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
                            Console.WriteLine($"{num1} >> {shiftRight} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid shift amount. Please enter a valid integer.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        validOperation = false;
                        break;
                }

                if (!validOperation)
                {
                    Console.WriteLine("Operation failed. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }

            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }
    }
}
