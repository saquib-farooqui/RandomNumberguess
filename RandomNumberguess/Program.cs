using System;

public class HelloWorld
{


    public static void Main(string[] args)
    {

        Random random = new Random();
        int randomNumber = random.Next(100);
       
        
        while (true)
        {
            Console.Write("Enter a number between 1 and 100(0 to quit)");
            int userran;
            userran = Convert.ToInt32(Console.ReadLine());

            if (userran == 0)
            {
                Console.WriteLine("you have exited the application");
                break;
            }
            else if (userran > randomNumber)
            {
                Console.WriteLine("High, Try Again");
            }
            else if (userran < randomNumber)
            {
                Console.WriteLine("Low, Try Again");
            }
            
            else
            {
                Console.WriteLine($"You guesssed correctly {randomNumber}");
                randomNumber = random.Next(100);
            }
           
        }
    }
}