using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using System;
namespace cool_proj
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Input the correct password.");
            bool loggedOn;
            string password;
            password =  Console.ReadLine();
            if (password == "F")
            {
            loggedOn = true;
            }
            else
            { 
            loggedOn = false;
            }

            if (loggedOn == true)
            {
            Console.WriteLine("Correct!");
            }
            else if (loggedOn == false)
            {
            Console.WriteLine("Nope!");
            Console.ReadLine();
            Environment.Exit(0);
            }

            
            Console.WriteLine("Double Check; What is password 2: ");
            string password2 = Console.ReadLine();




            Console.WriteLine("Wow! You have got everything correct so far! G00d. Now, to verify your age");
            Console.WriteLine("Input your age here: "); // why did I do this? I HAVE NO FREAKIN IDEA
            int age;
            age = Convert.ToInt32( Console.ReadLine() );
            if (age < 10) 
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your not old enough to continue");
            Console.ReadKey();
            Environment.Exit(0);
            }
            else 
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are old enough to pass! (Now press any key to proceed)");
            Console.ReadKey(); // Wait for a sec for the person to see
            }
            
//____________________________________________________________________________________________________________________________________________________
           
            Console.WriteLine("Now that you have passed the test, are you sure you want to continue? (Answer Y or N)");
            string Y = Console.ReadLine();
            if (Y == "Y")
            {
            Console.WriteLine("Ok!");
            }
            else if (Y == "N")
            {
            Console.WriteLine("Goodbye.");
            Console.ReadLine(); // Wait for a sec for the person to see
            Environment.Exit(0); // close the console
            }
            else
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error");
            Console.ReadLine(); // Wait for a sec for the person to see or type something
            Environment.Exit(0); 
            }
        }
    }
}