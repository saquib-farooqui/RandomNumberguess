using System;

public class HelloWorld
{


    public static void Main(string[] args)
    {

        Random random = new Random();
        int randomNumber = random.Next(100);
        int count = 0;
        
        while (true)
        {
            Console.Write("Enter a number between 1 and 100 (0 to quit) ");
            int userran;
            userran = Convert.ToInt32(Console.ReadLine());

            if (userran == 0)
            {
                Console.WriteLine("You have exited the application");
                break;
               
            }
            else if (userran > randomNumber)
            {
                Console.WriteLine("High, Try Again");
                count++;
            }
            else if (userran < randomNumber)
            {
                Console.WriteLine("Low, Try Again");
                count++;
            }
            
            else
            {
                Console.WriteLine($"You guesssed correctly! The number is {randomNumber}");
                Console.WriteLine($"It took you {count} tries");
                Console.Write("Do you want to play again? ");
                string ans;
                ans = Console.ReadLine();
                if (ans == "no" || ans == "No"){
                    Console.WriteLine("You have exited the application");
                    break;
                }
                count = 0;
                randomNumber = random.Next(100);
            }
           
        }
    }
}