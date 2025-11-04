/*
 * Task 5: Date Time and Time Span [10 minutes]
 * 
 * Creates a DateTime variable representing your birthdate.
 * Creates another DateTime variable representing the current date and time.
 * Calculates your age using TimeSpan (you'll need to subtract the two DateTime values).
 * Prints your birthdate, the current date, and your age in years.
 * Adds 10 days to your birthdate and prints the resulting date.
 * 
 */


DateTime birthDate = new DateTime(2005, 07, 21);
DateTime currentDate = DateTime.Now;

TimeSpan ageSpan = currentDate - birthDate;
int ageInYears = (int)(ageSpan.TotalDays/ 365.25);
Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Age in Years: {ageInYears}");
DateTime newDate = birthDate.AddDays(10);
Console.WriteLine(
    $"Birthdate after adding 10 days: {newDate.ToShortDateString()}"
);

