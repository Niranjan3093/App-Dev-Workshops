int[] ints = { 69, 969, 169, 469, 269 };

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