/*
 * Task 5: Generic Collections (List and Dictionary) [10 minutes]
 * 
 * Creates a List<string> containing the names of 3 of your favorite fruits.
 * Adds a new fruit to the list.
 * Removes one fruit from the list.
 * Prints all fruits in the list using a foreach loop.
 * Creates a Dictionary<int, string> where keys are fruit IDs (1,2,3) and values are the fruit names.
 * Adds a new entry to the dictionary and prints all key-value pairs.
 * 
 */

List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
fruits.Add("Date");
fruits.Remove("Banana");
Console.WriteLine("Fruits in the list:");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine(
    "------------------------"
);
Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Banana" },
    { 3, "Cherry" }
};
fruitDict.Add(4, "Date");
Console.WriteLine("Fruits in the dictionary:");
foreach (var kvp in fruitDict)
{
    Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");
}
