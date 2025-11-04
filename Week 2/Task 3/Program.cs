/*
 * Task 3: Data Types and Type Conversion [5 minutes]
 * Declare and initialize variables of the following types: byte, short, int, long, float, double, decimal, char, bool.
 * Convert the integer value 42 to a string and store it in a new variable.
 * Convert a string "3.14" to a double and store it in a new variable.
 * Print all variables to the console with appropriate labels showing their types and values.

*/

byte byteVar = 255; // Maximum value for byte
short shortVar = 32767; // Maximum value for short -> -32,768 to 32,767
int intVar = 2147483647; // Maximum value for int -> -2,147,483,648 to 2,147,483,647
long longVar = 9223372036854775807; // Maximum value for long -> -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float floatVar = 3.14f; // Suffix 'f' to indicate float literal 
double doubleVar = 3.141592653589793; // Default is double
decimal decimalVar = 3.1415926535897932384626433832m; // Suffix 'm' to indicate decimal literal
char charVar = 'A'; // Single character
bool boolVar = true; // Boolean value

string intToString = 42.ToString(); 
double stringToDouble = Convert.ToDouble("3.14");

Console.WriteLine($"byte: {byteVar}");
Console.WriteLine($"short: {shortVar}");
Console.WriteLine($"int: {intVar}");
Console.WriteLine($"long: {longVar}");
Console.WriteLine($"float: {floatVar}");
Console.WriteLine($"double: {doubleVar}");
Console.WriteLine($"decimal: {decimalVar}");
Console.WriteLine($"char: {charVar}");
Console.WriteLine($"bool: {boolVar}");
