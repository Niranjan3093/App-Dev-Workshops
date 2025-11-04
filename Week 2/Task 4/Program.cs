/*
 * Task 4: Array and Array Methods [10 minutes]
 * 
 * Creates a single-dimensional integer array containing 5 of your favorite numbers.
 * Uses Array.Sort() to sort the array in ascending order.
 * Uses Array.Reverse() to reverse the sorted array.
 * Prints each element of the array using a for loop.
 * Uses Array.IndexOf() to find the position of a specific number in the array.

 */

int[] ints = [ 69, 969, 169, 469, 269 ];

Array.Sort(ints);
Console.WriteLine("Sorted:");
foreach (var item in ints)
{
    Console.WriteLine(item);
}

Array.Reverse(ints);
Console.WriteLine("Reversed:");
foreach (var item in ints)
{
    Console.WriteLine(item);
}

Console.WriteLine("Index of 169:");
Console.WriteLine(Array.IndexOf(ints, 169));