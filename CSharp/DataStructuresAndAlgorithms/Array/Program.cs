int[] array = new int[] { 1, 3, 5, 7, 8 };

// Tranverse
Console.WriteLine("Tranverse an array:");
for
    (int i = 0;
        i < array.Length;
        i++)
    Console.WriteLine($"array[{i}] = {array[i]}");

// Insertion
Console.WriteLine("\nInsert an element to an array's index:");
Console.Write("Input an element to insert: ");
int element
    = int.Parse(Console.ReadLine() ?? "0");
Console
    .Write($"Input an array's index ([{0}, {array.Length - 1}]): ");
int index
    = int.Parse(Console.ReadLine() ?? "0");
Array.Resize(ref array, array.Length + 1);
for
    (int i = array.Length - 1;
    i > index;
    i--)
    array[i] = array[i - 1];
array[index] = element;
Console.WriteLine("Array after insertion:");
for
    (int i = 0;
        i < array.Length;
        i++)
    Console.WriteLine($"array[{i}] = {array[i]}");