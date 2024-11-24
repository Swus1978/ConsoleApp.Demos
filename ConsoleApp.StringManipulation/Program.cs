// See https://aka.ms/new-console-template for more information
Console.WriteLine("******** - String manipulation - ********");

// Initialize with a regular string literal.
string s1 = "This is a literal string";
String s2 = "This is a literal string";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");

// Initialize as an empty string
string s4 = string.Empty;
Console.WriteLine($"{nameof(s4)}: {s4}");

// Initialize to null. (possible null exception)
string? s5 = null;
string s6 = " ";
Console.WriteLine($"{nameof(s5)}: {s5}");
Console.WriteLine($"{nameof(s6)}: {s6}");

// Verbatim string literal.
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\program files\programfolder\";

// Use a const string to prevent modification to a string.
const string path = "C:\\program files\\programfolder\\";

// Escape sequences and characters.
string sentence = "She said, \"I have your phone\" \r\n This is the next line ";
Console.WriteLine($"{nameof(sentence)}: {sentence}");

// Raw string literals (requires C# 11 or later).
string rawLiteral = """ \snnjsdnj' "" This is a literal string """;
string rawLiteral2 = """
 \snnjsdnj' "" This is a literal string
 This is another line
 And another one
 """;

// Concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} Hello World!";
string newString1 = s1 + $"{s1}{s2} Some literal text";
string newString2 = string.Format("Literal string {0} {1}", s1, s2);
Console.WriteLine($"{nameof(newString)}: {newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");

// NULL or empty checks and length
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");

if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}
if (string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}

// Substring
string substring = s1.Substring(5);
Console.WriteLine($"{nameof(substring)} : {substring}");
substring = s1.Substring(5,5);
Console.WriteLine($"{nameof(substring)} : {substring}");

// Splitting strings
var splitsStrings = s2.Split(' ');
for (int i = 0; i < splitsStrings.Length; i++)
{
    Console.WriteLine(splitsStrings[i]);

}

// Replace
string replacement1 = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacement1)} : {replacement1}");

string replacement2 = s1.Replace("string","Chicken");
Console.WriteLine($"{nameof(replacement2)} : {replacement2}");



// Convert to string
string salary = 8000.57.ToString();
int value = 74185296;
string strValue = value.ToString();
bool chosen = true;

chosen.ToString();

// Changing Formatting
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary)+ ": " + value.ToString("C"));



// String comparison
