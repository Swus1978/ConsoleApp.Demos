// Variable Declarations and types 
using System.Globalization;

const int retirementAge = 65;


string? firstName = string.Empty;
string? lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary;
char gender = char.MinValue;
bool working = true;

// Promt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your date of birth (mm/dd/yyyy): ");
dob = DateOnly.ParseExact(Console.ReadLine(), "mm/dd/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine()); 

Console.Write("Please enter your gender (M or F ): ");
gender = Convert.ToChar(value: Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is: {salary.ToString("C")}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"Are you Employed: {working}");
Console.WriteLine($"Estimated Retirement year: {estimatedRetirementDate.Year}");