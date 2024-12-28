Console.WriteLine("********** - Methods - **********");

// Void methods - completes a task without returning a value
void PrintName()
{
    Console.WriteLine("Juan");
}

// Value returning methods - returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}
// Methods with parameters - represents data being passed into a methos.
void PrintNameWithParams(string name)
{
    // Method code
    Console.WriteLine("Your name is: " + name);
}

int GetYeatDifferenceWithPrams(int year)
{
    int yearDifference = DateTime.Now.AddYears(-5).Year;
    return yearDifference;
}

// Methods with optional parameters - parameter is not requiered.. also has a default value
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}


// Methods with nullable parameters
void PrintNameNullableParam(string? name, int? count)
{
    if (string.IsNullOrEmpty(name))
    {
        name = "Defdault name";
    }
    if (!count.HasValue)
    {
        count = 1;
    }
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

/*
 
name ??= "Default name";

//if(!count.HasValue)

{

  count ??= 1;

}



// The  null-coalescing assingment operator ??= assings the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null.



 

 */

/* Function Calls */

PrintName();
int fiveYearsAgo  = GetFiveYearsAgo();
Console.WriteLine("Five Years Ago was: " + fiveYearsAgo);

Console.WriteLine("Enter your name: ");
string name1 = Console.ReadLine();   
PrintNameWithParams(name1);

Console.WriteLine("Enter a year ");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYeatDifferenceWithPrams(2015);
Console.WriteLine("This was " + yearsAgo + " years ago");

Console.WriteLine("Enter number of years in the future or past: ");
int numberOfYears = Convert.ToInt32(Console.ReadLine());

var pastYear1 = GetFutureOrPastYear();
Console.WriteLine("The year is: " + pastYear1);

var pastYear2 = GetFutureOrPastYear();
Console.WriteLine("The year is: " + pastYear2);




PrintNameNullableParam("Juan Gustavo Quinones", 10);