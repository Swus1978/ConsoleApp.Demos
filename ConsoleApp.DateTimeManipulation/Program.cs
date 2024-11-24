// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("******** - DateTime manipulation - ********");

// Empty DateTime object
DateTime dateTime = new DateTime();

// Create a DateTime from date and time
var dateOfBirth = new DateTime(1978,07,13);
Console.WriteLine($"My DOB is: {dateOfBirth}");

var exactDateOfBirth = new DateTime(1978, 07, 13,14, 30, 00, DateTimeKind.Utc);
Console.WriteLine($"My DOB is: {exactDateOfBirth}");

//Console.WriteLine($"Day of the week: {dateOfBirth.DayOfWeek}");
//Console.WriteLine($"Day of the year: {dateOfBirth.DayOfYear}");
//Console.WriteLine($"Time of Day: {exactDateOfBirth.TimeOfDay}");
//Console.WriteLine($"Tick: {exactDateOfBirth.Ticks}");
//Console.WriteLine($"Kind: {exactDateOfBirth.Kind}");


// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
//Console.WriteLine($"The time Now is: " + now);

//// Create a DateTime from a String
//Console.WriteLine("What is your DOB (dd/MM/yyyy): ");
//string dob = Console.ReadLine();

//var userDob = DateTime.Parse(dob);
//Console.WriteLine($"Day of the week: {userDob.DayOfWeek}");
//Console.WriteLine($"Day of the year: {userDob.DayOfYear}");
//Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
//Console.WriteLine($"Tick: {userDob.Ticks}");
//Console.WriteLine($"Kind: {userDob.Kind}");

//// Change Format DateTime
//Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("MMM dd, yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("dd-MMM-yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("dddd, MMMM dd, yyyy")}");




//// Add Additional Time
//Console.WriteLine("One hour from now is: " + now.AddHours(1));
//Console.WriteLine("One day from now is: " + now.AddDays(1));
//Console.WriteLine("One day ago from now is: " + now.AddDays(-1));



////Ticks from DateTime

//Console.WriteLine("******** - DateTime Offset manipulation - ********");
//// UTC - Cordinated Universal Time
//var utcNow = DateTime.UtcNow;
//Console.WriteLine($"Now Date Time: {now}");
//Console.WriteLine($"UTC Now Date Time: {utcNow}");

//// DateTimeOffSet and TimeZone Info
//var tz = TimeZoneInfo.Local.GetUtcOffset( utcNow );
//Console.WriteLine($"User Time Zone: {tz}");

//var dto = new DateTimeOffset(now, tz);
//Console.WriteLine($"User Time Zone: {dto}");
//Console.WriteLine($"UTC Time Action: {dto.UtcDateTime}");

//var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time: ");
//var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
//Console.WriteLine($"Action was completed in India at: {indiaDateTime}");




Console.WriteLine("******** - Date only and Time only manipulation - ********");

// DateOnly
DateOnly dateOnly = new(1978, 07, 13);
var nextDay = dateOnly.AddDays(1);
var previousDay = dateOnly.AddYears(-1);
var decadeLater = dateOnly.AddYears(10);
var lastMonth = dateOnly.AddMonths(-1);

Console.WriteLine($"The Date: {dateOnly}");
Console.WriteLine($"The Next day: {nextDay}");
Console.WriteLine($"The Previous day: {previousDay}");
Console.WriteLine($"The Decade later: {decadeLater}");
Console.WriteLine($"The Last month: {lastMonth}");

var dateOnlyFormDateTime = DateOnly.FromDateTime(now);
Console.WriteLine($"Date Only From DateTime: {dateOnlyFormDateTime}");

Console.WriteLine($"What is your DOB (dd MMM yyyy): ");
string dobDateOnly = Console.ReadLine();

var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"The Date Only: {theDateOnly}");

// TimeOnly
var timeNow = TimeOnly.FromDateTime(now);
Console.WriteLine($"It is now: {timeNow}");
Console.WriteLine($"It is now: {timeNow:hh:mm tt}");

// Date Comparisons
var date1 = new DateTime(2002, 01, 19);
var date2 = new DateTime(1997, 02, 21);

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");




