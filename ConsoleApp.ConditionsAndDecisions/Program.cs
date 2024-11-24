// See https://aka.ms/new-console-template for more information
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If...Else...statement - Decide to print pass or fail based on input

Console.WriteLine("**************** Simple IF Results********************");

if (grade > 50 )
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has faild"); 
    Console.WriteLine("please recommend student to student affair's office");
}
Console.WriteLine("**************** Simple IF Results End *********************");


// Complex If... Else if... statement - Decide to print letter based on grade value
Console.WriteLine("**************** Complex IF... ELSE IF Results *********************");
/*
 * A: 85 - 100
 * B: 75 - 84
 * C: 65 - 74
 * D: 50 - 64 - else if (grade >= 50 && brage <= 64)
 * F: less than 50 X
 */





if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 50)
{
    Console.WriteLine("Student has faild - F ");

}
else if (grade >= 51 && grade <= 64)
{
    Console.WriteLine("D");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job!");
}
else
{
    Console.WriteLine("This is an invalid value");
}


Console.WriteLine("**************** Complex IF... ELSE IF Results End *****************");

// Ternary operator - Used to assing a value to a variable based on a condition
Console.WriteLine("**************** Ternary Operator Results *****************");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Status is: {passStatus}");

Console.WriteLine("**************** Ternary Operator Results End *****************");

Console.WriteLine("**************** Switch Statement Results *****************");
Console.Write("PLease enter the day of the week: ");
int daysOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (daysOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday - Going to Church");
        break;
    case 2: 
        Console.WriteLine("Monday - Back to Work!");
        break;
    case 3: 
        Console.WriteLine("Tuesday - Taco Tuesday!");
        break;
    case 4:
        Console.WriteLine("Wednesday - Hump Day!");
        break;
    case 5:
        Console.WriteLine("Thursday - Almost Friday!");
        break;
    case 6: 
        Console.WriteLine("Friday");
        Console.WriteLine("TGIF!!!");
        break;
    case 7: 
        Console.WriteLine("Saturday");
        Console.WriteLine("Beach Day!!!");
        break;
    default:
        Console.WriteLine("Invalid day! Please enter a number between 1 and 7.");
        break;
}

Console.WriteLine("**************** Switch Statement Results End *****************");




// The rest of the application
Console.WriteLine("Thank you for using this program");