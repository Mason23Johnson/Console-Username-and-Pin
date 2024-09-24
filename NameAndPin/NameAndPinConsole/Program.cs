class NameAndPinConsole
{
    static string? username;
    static string? pin;

    static void Main()
    {
        NameAndPin();
        MainMenuScreen();
    }

    public static void NameAndPin()
    {
        Console.WriteLine("Please enter a username between 3-20 characters.");

        while (true)
        {
            username = Console.ReadLine(); // Reference the class-level 'username' variable

            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Please enter a valid username.");
            }
            else if (!(username.Length >= 3 && username.Length <= 20))
            {
                Console.WriteLine("Please make sure the username is between 3 and 20 characters.");
            }
            else
            {
                Console.WriteLine($"Thank you! Please set your PIN {username}!");
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("Enter a 4-digit PIN (digits only):");
            pin = Console.ReadLine(); // Reference the class-level 'pin' variable

            if (!string.IsNullOrEmpty(pin) && pin.Length == 4 && pin.All(char.IsDigit))
            {
                Console.Write("Confirm your PIN: ");
                string? confirmPIN = Console.ReadLine();
                if (pin != confirmPIN)
                {
                    Console.WriteLine("PINs do not match. Please try again.");
                }
                else
                {
                    Console.WriteLine($"\nYour pin and username have been set successfully. Enjoy!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Please make sure the PIN is only 4 digits.\n");
            }
        }
    }

    public static void MainMenuScreen()
    {
        Console.WriteLine($"\n\tWelcome {username}!");
        Console.WriteLine("\t\t1. Example 1");
        Console.WriteLine("\t\t2. Example 2");
        Console.WriteLine("\t\t3. Example 3");
        Console.WriteLine("\t\t9. Settings");
        Console.WriteLine("\t\t10. Exit");

        try
        {
            int userInput = Convert.ToInt16(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Example1();
                    break;
                case 2:
                    Example2();
                    break;
                case 3:
                    Example3();
                    break;
                case 9:
                    Settings();
                    break;
                case 10:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number.");
                    MainMenuScreen();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            MainMenuScreen();
        }
    }

    public static void Example1()
    {
        Console.WriteLine("Example 1 Selected.");
        MainMenuScreen();
    }

    public static void Example2()
    {
        Console.WriteLine("Example 2 Selected.");
        MainMenuScreen();
    }

    public static void Example3()
    {
        Console.WriteLine("Example 3 Selected.");
        MainMenuScreen();
    }

    public static void Settings()
    {
        Console.WriteLine("Please select one of the following.");
        Console.WriteLine("1. Example A");
        Console.WriteLine("2. Example B");

        int userInput = Convert.ToInt16(Console.ReadLine());
        if (userInput == 1)
        {
            ExampleA();
        }
        else if (userInput == 2)
        {
            ExampleB();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            Settings();
        }
    }

    public static void ExampleA()
    {
        Console.WriteLine("Example A Selected.");
        MainMenuScreen();
    }

    public static void ExampleB()
    {
        Console.WriteLine("Example B Selected.");
        MainMenuScreen();
    }

    public static void ExitProgram()
    {
        Console.WriteLine("Exiting the program.");
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }

    public static void PINtoEnter()
    {
        Console.WriteLine("Please enter PIN to continue:");
        string? pinConfirm = Console.ReadLine();

        if (pinConfirm != pin) // Reference class-level 'pin'
        {
            Console.WriteLine("Incorrect PIN. Type 'm' to return to the menu or try again.");

            string? userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput) && userInput.ToLower() == "m")
            {
                MainMenuScreen(); // Call the correct menu method
            }
            else
            {
                Console.WriteLine("Invalid input.");
                PINtoEnter();
            }
        }
        else
        {
            Console.WriteLine("PIN confirmed!\n");
        }
    }
}
