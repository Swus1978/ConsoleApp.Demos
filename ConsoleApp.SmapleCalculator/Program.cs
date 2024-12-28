// Welcome Message
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        // Variable Declaration
        int choice = 0;
        int num1, num2 = 0;

        // Show calculator options / Show menu
        while (choice != -1)
        {
            try
            {
                // Print menu options
                PrintMenu();

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == -1)
                {
                    break;
                }

                // Prompt for user input
                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                // Switch statement
                int answer = 0;

                switch (choice)
                {
                    case 1:
                        answer = AddNumbers(num1, num2);
                        break;
                    case 2:
                        answer = SubtractNumbers(num1, num2);
                        break;
                    case 3:
                        answer = Product(num1, num2);
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        answer = Quotient(num1, num2);
                        break;
                    case 5:
                        answer = Fibonacci(num1, num2);
                        break;
                    default:
                        throw new Exception("Invalid menu item selected.");
                }

                // Print the output
                Console.WriteLine($"The result is: {answer}");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            finally
            {
                Console.WriteLine("Press any key to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        Console.WriteLine("****************************** - Thank you for using the sample calculator! - *******************************************");

        // Method Definitions
        int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        int Product(int num1, int num2)
        {
            return num1 * num2;
        }

        int Quotient(int num1, int num2)
        {
            return num1 / num2;
        }

        int Fibonacci(int num1, int num2)
        {
            var answer = 0;
            for (int i = num1; i <= num2; i++) // Fixed loop syntax
            {
                answer += i; // Increment answer with current value of i
            }
            return answer;
        }

        void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("******** - Welcome to the sample calculator - ********");
            Console.WriteLine("Please select an operation  (-1 to exit program)");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Fibonacci sequence");
        }
    }
}
