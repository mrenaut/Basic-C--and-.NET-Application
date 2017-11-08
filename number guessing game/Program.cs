using System;

//Namespace
namespace number_guessing_game
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {

            // Run GetAppInfo Function
            GetAppInfo();

            // Ask for user's name and greet
            GreetUser();


            while (true) { 

            // Initialize correct number
            //int correctNumber = 7;

            // Create a new Random object
            Random random = new Random();

            // Initialize correct number
            int correctNumber = random.Next(1,10);

            // Inisialize guess variable
            int guess = 0;

            // Tell user to guess a number
            Console.WriteLine("Guess a number between 1 and 10");


            // While guess is not correct
            while(guess != correctNumber) {

                //Get user's input
                string input = Console.ReadLine();

                // Make sure input is a number
                if (!int.TryParse(input, out guess)) {

                    // Print error message
                    PrintColorMessage(ConsoleColor.Red, "Sorry, please enter an actual number.");
                    
                    // Keep going
                    continue;
                   
                }

                // Cast to integer and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                    if(guess !=correctNumber) {

                        // Print wrong number message
                        PrintColorMessage(ConsoleColor.Red, "Sorry, that number is not correct!");


                }
              

            }

                // Output success message
                PrintColorMessage(ConsoleColor.Green, "That is correct!");


                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }

            }
        }

        // Get and display app info
        static void GetAppInfo(){
            // Set app variables
            string appName = "Number Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Melissa Renaut";


            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser () {  
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Greets user with user's name
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Write out wrong guess message
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();

        }

    }
}
