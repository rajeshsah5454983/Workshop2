byte myByte = 10;
short myShort = 2000;
int myInt = 50000;
long myLong = 10000000000L;
float myFloat = 3.5F;
double myDouble = 7.12345;
decimal myDecimal = 9.87654321M;
char myChar = 'A';
bool myBool = true;


int number = 42;
string numberAsString = number.ToString();  // Convert int into string

string piString = "3.14";
double piValue = Convert.ToDouble(piString);  // Convert string into double


Console.WriteLine("---- Data Types and Type Conversion ----");
Console.WriteLine($"byte: {myByte}");
Console.WriteLine($"short: {myShort}");
Console.WriteLine($"int: {myInt}");
Console.WriteLine($"long: {myLong}");
Console.WriteLine($"float: {myFloat}");
Console.WriteLine($"double: {myDouble}");
Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine($"char: {myChar}");
Console.WriteLine($"bool: {myBool}");




Console.WriteLine($"Converted int to string: \"{numberAsString}\"");
Console.WriteLine($"Converted string \"{piString}\" to double: {piValue}");