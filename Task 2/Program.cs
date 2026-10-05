class circle
{
    public const double PI = 3.14159;

    private int radius = 5;
    
    // method to calculate circumference = 2 * PI * r
    public double circumference()
    {
        return 2 * PI * radius;
    }
}
 class Program
 {
     static void Main()
     {
         Console.WriteLine($"PI = {circle.PI}");

         circle.PI = 3.15;
// *** displays error because PI is a constant. ***
     }
 }
 
