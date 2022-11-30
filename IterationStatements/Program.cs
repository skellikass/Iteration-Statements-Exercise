using System.Net.NetworkInformation;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void NegToPosThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------------");
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void ByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------------");
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static void EqualOrNot(int someNumber, int someOtherNumber)
        {
            bool areTheyEqual = someNumber == someOtherNumber;
            Console.WriteLine(areTheyEqual);
            Console.WriteLine("--------------------------------------------------");
        }

        
        //Write a method to check whether a given number is even or odd
        static string EvenOrOdd(int givenNumber)
        {
            return givenNumber % 2 == 0 ? "Even" : "Odd";
        }
        

        //Write a method to check whether a given number is positive or negative
        static string PosOrNeg(int anotherGivenNumber)
        {
            return anotherGivenNumber * 1 > 0 ? "Positive" : "Negative"; 
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static void Vote()
        {
            Console.WriteLine("Please type your age:");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 21)
                {
                    Console.WriteLine("Sorry, you have to take at least one more trip around the sun before you can vote, but I love your enthusiasm!");
                }
                else 
                {
                    Console.WriteLine("Hooray!  You have lived enough years to earn the right to vote!");
                }
            }
            Console.WriteLine("--------------------------------------------------");
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static string NegToPosTen()
        {
            Console.WriteLine("Type any number you would like:");
            int userInteger = int.Parse(Console.ReadLine());
            return userInteger >= -10 && userInteger <= 10 ? "This number is in the range -10 to 10." : "This number is NOT in the range -10 to 10.";
        }

        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultTable(int givenInteger)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}" , givenInteger, i, givenInteger*i);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("Below is  every number between 1000 and -1000:");
            Program.NegToPosThousand();
            Console.WriteLine("Below is every multiple of 3 between 3 and 999:");
            Program.ByThrees();
            Console.WriteLine("7 and 8 are equal, true or false?");
            Program.EqualOrNot(7, 8);
            Console.WriteLine("Is 3 even or odd?");
            Console.WriteLine(Program.EvenOrOdd(3));
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Is -11 positive or negative?");
            Console.WriteLine(Program.PosOrNeg(-11));
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Are you old enough to vote?");
            Program.Vote();
            Console.WriteLine(Program.NegToPosTen());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Below is the multiplication table (from 1 to 12) of 5:");
            Program.MultTable(5);
        }
    }
}
