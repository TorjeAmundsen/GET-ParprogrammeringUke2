namespace ParprogrammeringUke2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "1" && input != "2")
            {
                Console.WriteLine("Select 1 for string reverser, 2 for currency converter");
                input = Console.ReadLine();
                if (input == "1") StringReverser.Run();
                else if (input == "2") Converter.Run();
                else Console.WriteLine("Invalid input!");
            }
        }
    }
}