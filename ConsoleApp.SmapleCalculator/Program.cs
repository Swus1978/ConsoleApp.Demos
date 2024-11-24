// See https://aka.ms/new-console-template for more information

// Welcome Message
using System.ComponentModel.DataAnnotations;

Console.WriteLine("********************************** - Welcome to the sample calculator - ***********************************");

// Show calculator options
Console.WriteLine("Please select an operation (-1 to exit program) ");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Fibonacci sequene");

int choice = Convert.ToInt32(Console.ReadLine());
while (choice != -1)
{
    // Prompt for user input
    Console.WriteLine("Please enter the first number:  ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the second number:  ");
    int num2 = Convert.ToInt32(Console.ReadLine());


    // Decide which operation is needed based on selected option
    /*If statements*/
    //if (choice == 0 )
    //{
    //    answer = num1 + num2;
    //}
    //else if (choice == 1 )
    //{

    //}
    //else if (choice == 2 )
    //{
    //     answer = num1 - num2;
    //}
    //else if (choice == 3 )
    //{
    //     answer = num1 * num2;
    //}
    //else if (choice == 4 )
    //{
    //     answer = num1 / num2;   
    //}
    //else
    //{
    //    Console.WriteLine("Invalid choice");
    //}

    /* Switch statement */

    int answer = 0;

    switch (choice)
    {
        case 1:
            answer = num1 + num2;
            break;
        case 2:
            answer = num1 - num2;

            break;
        case 3:
            answer = num1 * num2;
            break;
        case 4:
            answer = num1 / num2;
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;

            }
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    // Print the out put 
    Console.WriteLine($"The result is: {answer}");
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
    Console.Clear();
   
    Console.WriteLine("Please select an operation (-1 to exit program)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequene");
    choice = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("****************************** - Thank you for using the sample calculator! - *******************************************");
