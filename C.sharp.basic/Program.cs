internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, programmer");
        Console.WriteLine("Enter your first name:");
        string fName = Console.ReadLine();
        Console.WriteLine("Enter your family name:");
        string familyName = Console.ReadLine();
        Console.WriteLine("Enter your birthday date:");
        string bD = Console.ReadLine();
        Console.WriteLine("Enter your Email:");
        string email = Console.ReadLine();
        Console.WriteLine("Enter your Github name:");
        string gName = Console.ReadLine();
        Console.WriteLine("*               *");
        Console.WriteLine(" *             * ");
        Console.WriteLine("  *           *  ");
        Console.WriteLine("    *       *    ");
        Console.WriteLine("      *   *      ");
        Console.WriteLine("        *        ");
        Console.WriteLine("Welcome "+ familyName);
        Console.WriteLine("");
        Console.WriteLine("First Name: " + fName );
        Console.WriteLine("Family Name: " + familyName);
        Console.WriteLine("Day of birth: " + bD);
        Console.WriteLine("*        *  *  *        *");
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Github Username:" + gName);
        Console.ReadLine();
        Console.WriteLine("THANK YOU FOR USING OUR APP, HAVE A NICE DAY");
        Console.ReadLine();
    }
}