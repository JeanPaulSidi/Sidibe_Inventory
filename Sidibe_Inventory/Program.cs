namespace Sidibe_Inventory
{
    internal class Program
    {
        static void DisplayNonLoggedInMenu() 
        {
            Console.Clear();
            Console.WriteLine("Welcome back!");
            Console.WriteLine();
            Console.WriteLine("Press any key to start the program");
            Console.ReadKey();
        }

        static ConsoleKeyInfo DisplayLoggedInMenu(List<string> MenuOptions) 
        {
            ConsoleKeyInfo UserChoice;

            Console.Clear();
            Console.WriteLine("Choose from the following options:");
            Console.WriteLine();
            Console.WriteLine("   1. Add a Bicycle to the shipment.");
            Console.WriteLine("   2. Add a Lawn Mower to the shipment.");
            Console.WriteLine("   3. Add a Baseball Glove to the shipment.");
            Console.WriteLine("   4. Add Crackers to the shipment.");
            Console.WriteLine("   5. Add a Cell Phone to the shipment.");
            Console.WriteLine("   6. List Shipment Items.");
            Console.WriteLine("   7. Compute Shipping Charges.");

            do
            {
                UserChoice = Console.ReadKey(true);

            } while (!MenuOptions.Contains(UserChoice.KeyChar.ToString()));

            return UserChoice;
        }

        static void ReturnToMenu() 
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
            Console.Clear();
        }

        static void TerminateProgram() 
        {
            string Message;

            Message = "Thank you for using our shipping program. \n";
            Message += "Press any key to terminate the program";
            Console.WriteLine();
            Console.WriteLine(Message);
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        { 
            List<string> MenuOptions = new List<string>();
            MenuOptions.Add("1");
            MenuOptions.Add("2");
            MenuOptions.Add("3");
            MenuOptions.Add("4");
            MenuOptions.Add("5");
            MenuOptions.Add("6");
            MenuOptions.Add("7");

            IShippable Bicycle = new Bicycles();
            IShippable LawnMower = new LawnMowers();
            IShippable BaseballGlove = new BaseballGloves();
            IShippable Crackers = new Crackers();
            IShippable CellPhone = new CellPhones();

            ConsoleKeyInfo UserChoice;
            string Message;
            decimal TotalShippingCost;
            Shipper shipper;

            while (true) 
            {
                DisplayNonLoggedInMenu();

                shipper = new Shipper();
                UserChoice = new ConsoleKeyInfo();
                Message = string.Empty;
                TotalShippingCost = 0;

                do
                {
                    UserChoice = DisplayLoggedInMenu(MenuOptions);

                    if (UserChoice.Key == ConsoleKey.D1) 
                    {
                        Console.Clear();
                        Message = shipper.Add(Bicycle);
                        Console.WriteLine(Message);

                        ReturnToMenu();

                    }
                    else if (UserChoice.Key == ConsoleKey.D2) 
                    {
                        Console.Clear();
                        Message = shipper.Add(LawnMower);
                        Console.WriteLine(Message);

                        ReturnToMenu();

                    }
                    else if (UserChoice.Key == ConsoleKey.D3) 
                    {
                        Console.Clear();
                        Message = shipper.Add(BaseballGlove);
                        Console.WriteLine(Message);

                        ReturnToMenu();

                    }
                    else if (UserChoice.Key == ConsoleKey.D4) 
                    {
                        Console.Clear();
                        Message = shipper.Add(Crackers);
                        Console.WriteLine(Message);

                        ReturnToMenu();

                    }
                    else if (UserChoice.Key == ConsoleKey.D5) 
                    {
                        Console.Clear();
                        Message = shipper.Add(CellPhone);
                        Console.WriteLine(Message);

                        ReturnToMenu();

                    }
                    else if (UserChoice.Key == ConsoleKey.D6) 
                    {
                        Console.Clear();
                        Message = shipper.ListShipmentItems();

                        if (Message == string.Empty) 
                        {
                            Message = ("Your shipping cart is empty! start adding items first.");
                        }

                        Console.WriteLine(Message);

                        ReturnToMenu();

                    }
                    else if (UserChoice.Key == ConsoleKey.D7) 
                    {
                        Console.Clear();
                        TotalShippingCost = shipper.ComputeShippingCharges();

                        if (TotalShippingCost == 0) 
                        {
                            Console.WriteLine("Your shipping cart is empty!");
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to start adding items or press Q to quit");

                            do 
                            {
                                UserChoice = Console.ReadKey(true);

                            }while (UserChoice.Key != ConsoleKey.Enter && UserChoice.Key != ConsoleKey.Q);
                            
                        }
                        else 
                        {
                            Console.Write("Total shipping cost for this order is ");
                            Console.WriteLine(TotalShippingCost.ToString("C"));
                            Console.WriteLine();

                            TerminateProgram();
                        }

                    }

                } while (UserChoice.Key != ConsoleKey.D7 && UserChoice.Key != ConsoleKey.Q);

            }
        }
    }
}