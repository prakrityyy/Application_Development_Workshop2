class Program
{
    static void Main()
    {
        // 1. Creating a single-dimensional integer array with 5 favorite numbers
        int[] favoriteNumbers = { 1,2,3,4,5 };

        Console.WriteLine("Original array: " + string.Join(", ", favoriteNumbers));

        // 2. Sorting the array in ascending order
        Array.Sort(favoriteNumbers);
        Console.WriteLine("After Array.Sort() (ascending): " + string.Join(", ", favoriteNumbers));

        // 3. Reversing the sorted array
        Array.Reverse(favoriteNumbers);
        Console.WriteLine("After Array.Reverse(): " + string.Join(", ", favoriteNumbers));

        // 4. Printing each element using a for loop
        Console.WriteLine("\nPrinting elements using a for loop:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine($"Index {i}: {favoriteNumbers[i]}");
        }

        // 5. Using Array.IndexOf() to find the position of a specific number
        int searchNumber = 12;
        int index = Array.IndexOf(favoriteNumbers, searchNumber);

        if (index != -1)
        {
            Console.WriteLine($"\nNumber {searchNumber} found at index: {index}");
        }
        else
        {
            Console.WriteLine($"\nNumber {searchNumber} is not in the array.");
        }
    }
}