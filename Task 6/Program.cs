class Program
{
    static void Main()
    {
        // 1. Creating a List<string> containing the names of 3 favorite fruits
        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

        // 2. Adding a new fruit to the list
        fruits.Add("Orange");

        // 3. Removing one fruit from the list
        fruits.Remove("Banana");

        // 4. Printing all fruits in the list using a foreach loop
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine("- " + fruit);
        }

        // 5. Creating a Dictionary<int, string> where keys are fruit IDs and values are fruit names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Mango" }
        };

        // 6. Adding a new entry to the dictionary and printing all key-value pairs
        fruitDictionary.Add(4, "Orange");

        Console.WriteLine("\nFruit dictionary (ID: Name):");
        foreach (var kvp in fruitDictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}