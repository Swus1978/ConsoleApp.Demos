
// Option one to write the code 
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());


// Option two to write the code 
int num2 = 0;
Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

// Add numbers
int sum = num1 + num2;

// Multiply
int product = num1 * num2;

// Division
int quotient = num1 / num2;

// Subtract
int diffrence = num1 - num2;

// Modulus
int mod = num1 % num2;

Console.WriteLine("******************* Math Results *****************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Diffrence: {diffrence}");
Console.WriteLine($"Product:{product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("******************* End Math Results *****************");

/*
     Logic Operations and Operators
 */

bool isGraterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualThan = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("******************* Logic Results *****************");
Console.WriteLine();
Console.WriteLine($"Is Grater than: {isGraterThan}");
Console.WriteLine($"Is Less than: {isLessThan}");
Console.WriteLine($"Is Equal to: {isEqualThan}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("******************* End Logic Results *****************");


/*
     Assingment Operations and Operators
 */
int randomValue = Convert.ToInt32(Console.ReadLine());
//int incrementValue = num1 + 5;
//num1 = num1 + 5;

Console.WriteLine("******************* Assingment Results *****************");
Console.WriteLine();
num1 += 5;
Console.WriteLine($"Nun 1 increases by 5 {randomValue}: {num1}");
num1 -= 3 ;
Console.WriteLine($"Num 1 reduced by 3 {randomValue}: {num1}");
num1 /= 2;
Console.WriteLine($"Num 1 divided by 2{randomValue}: {num1}");
num1 %= 2;
Console.WriteLine($"Num 1 mod by 2 {randomValue}: {num1}");
num1 *= 10;
Console.WriteLine($"Num 1 multiplied by 10 {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("******************* End Assingment Results *****************");
