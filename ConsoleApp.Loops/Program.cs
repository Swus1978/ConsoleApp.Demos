// See https://aka.ms/new-console-template for more information
Console.WriteLine("************************************** Simple Loop **********************************************************");
Console.WriteLine("How many times would you like me to print Hello World ? : ");
//  int userInput = Convert.ToInt32(Console.ReadLine());

//// Simple For Loop Demo


//for (int i = 0; i < userInput; i++)
//{
//    if (i > 0)
//    {
//        // Print Hello World 10 times
//        Console.WriteLine($"Hello, World! - {i}");

//    }
//}
//Console.WriteLine("Loop completed");

Console.WriteLine("************************************** End Simple Loop **********************************************************");



// While Loop
Console.WriteLine("**************************************  While Loop **********************************************************");


int counter = 0;
while (counter < 10)
{
    Console.WriteLine($" Hello World! - {counter}");
    counter += 2;

}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit.

int sum = 0;
int num = -1;

while (num != -1) 
{
    Console.Write("Please numbers to be summed. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    // Nested if statement
    if (num != -1)
    {
       sum += num;

    }
}

Console.WriteLine($"Your sum is: {sum}");

Console.WriteLine("************************************** End While Loop **********************************************************");


Console.WriteLine("************************************** Do While Loop **********************************************************");

sum = 0;
num = -1;

do
{
    Console.Write("Please numbers to be summed. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    // Nested if statement
    if (num != -1)
    {
        sum += num;

    }

} while (num != -1);
Console.WriteLine($"Your sum is: {sum}");

Console.WriteLine("************************************** End Do While Loop **********************************************************");
