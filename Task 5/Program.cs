class Program
{
    static void Main()
    {
        // 1. Creating a DateTime variable representing birthdate
        DateTime birthdate = new DateTime(2004, 12, 22); 

        // 2. Creating another DateTime variable representing the current date and time
        DateTime now = DateTime.Now;

        // 3. Calculating age using TimeSpan
        TimeSpan ageSpan = now - birthdate;
        int ageInYears = ageSpan.Days / 365; 

        // 4. Printing birthdate, the current date, and  age in years
        Console.WriteLine($"Birthdate: {birthdate:dd/MM/yyyy}");
        Console.WriteLine($"Current date and time: {now:dd/MM/yyyy HH:mm:ss}");
        Console.WriteLine($"Age (approximate): {ageInYears} years");

        // 5. Add 10 days to birthdate and printing the resulting date
        DateTime birthdatePlus10Days = birthdate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {birthdatePlus10Days:dd/MM/yyyy}");
    }
}