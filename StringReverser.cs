namespace ParprogrammeringUke2
{
    class StringReverser
    {
        public static void Run()
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            Console.WriteLine("Press 1 to reverse, 2 to covert to lower case, 3 to covert to upper case.");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    ReverseString(input);
                    break;
                case "2":
                    Console.WriteLine($"Lower case string: {input.ToLower()}");
                    break;
                case "3":
                    Console.WriteLine($"Lower case string: {input.ToUpper()}");
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    break;
            }
        }
        private static void ReverseString(string input)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine($"Reversed string: {reversed}");
        }
    }
}
