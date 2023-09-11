namespace lektion_sep_11
{
    enum Beverage
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the awesome vending machine");
            Console.WriteLine("Which beverage do you prefer? (Coffee, Tea, Water, Soda or Juice)");
            string userInput = Console.ReadLine();
            

            switch(userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee); 
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("invalid input, this drink does not exist");
                    break;
            }
        }
        public static void Respond(Beverage drink)
        {
            switch(drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("You ordered Coffee");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("You ordered Tea");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You ordered Water");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("You ordered Soda");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("You ordered Juice");
                    break;
            }
        }
    }
}