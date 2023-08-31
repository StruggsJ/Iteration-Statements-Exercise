using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        
        static void Main(string[] args)
        {
            PrintNumbers();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("-----------");
            
            PrintAddThree();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("-----------");

            Console.WriteLine(EqualCheckInterface());
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("-----------");

            Console.WriteLine(OddOrEvenInterface());
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("-----------");

            Console.WriteLine(PosOrNegInterface());
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("-----------");

            Console.WriteLine(VoteAgeInterface());
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
            Console.WriteLine("-----------");
        }

        public static void  PrintNumbers()
        {

            int number = 1000;

            Console.WriteLine("Good day, may I interest you in some numbers from one-thousand down to negative one-thousand?");
            Console.WriteLine("Input 1 for yes. Input any other number to decline.");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 1) 
            { 
          
            while (number >= -1000)
            {
                Console.WriteLine($"{number}");
                number--;
            }

            }
            else
            {
                Console.WriteLine("Very well.");
            }
            
         
        }

        public static void  PrintAddThree()
        {
            int number = 3;

            Console.WriteLine("Hello again, may I interest you in some more numbers? The ones available are three through nine-hundrend and ninty nine," +
                "but the listed numbers will be increased by three. ");

            Console.WriteLine("Input 1 for yes. Input any other number to decline.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                do
                {
                    Console.WriteLine(number);
                    number += 3;
                } while (number <= 999);
            }
            else
            {

                Console.WriteLine("See you next time.");

            }
           

        }

        public static string EqualCheckInterface()
        {
            Console.WriteLine("Please pick a random number.");
            int pickNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please pick another random number.");
            int pickNum2 = Convert.ToInt32(Console.ReadLine());

            string result = EqualCheck(pickNum1, pickNum2 );

            return result;
        }

        public static string EqualCheck(int numInput1, int numInput2)
        {

            if (numInput1 == numInput2)
            {
                return $"{numInput1} and {numInput2} are equal to each other.";
            }
            else
            {
                return $"{numInput1} and {numInput2}  are not equal to each other.";
            }

        }

        public static string OddOrEvenInterface()
        {
            Console.WriteLine("Please input a number, and I will tell you if that number is odd or even.");
            int pickNum1 = Convert.ToInt32(Console.ReadLine());

            string result = OddOrEven(pickNum1);

            return result;
        }


        public static string OddOrEven (int numInput)
        {
            int remainder = numInput % 2;

            if (remainder == 0) 
            {

                return $"{numInput} is even";

            }
            else
            {
                return $"{numInput} is odd";
            }
        }


        public static string PosOrNegInterface()
        {
            Console.WriteLine("Please input a number, and I will tell you if that number is positive or negative.");
            int pickNum1 = Convert.ToInt32(Console.ReadLine());

            string result = PosOrNeg(pickNum1);

            return result;
        }

        public static string PosOrNeg (int numInput)
        {
            if (numInput > 0)
            {
                return $"{numInput} is a positive number.";
            }
            else if ( numInput < 0)
            {
                return $"{numInput} is a negative number.";
            }
            else
            {
                return $"{numInput} is neither a positive or negative number.";
            }
        }

        public static string VoteAgeInterface()
        {
            Console.WriteLine("Good day, I will tell you if you are eligible to vote. How old are you?");
            int pickNum1 = Convert.ToInt32(Console.ReadLine());

            string result = VoteAgeCheck(pickNum1);

            return result;
        }

        public static string VoteAgeCheck (int numInput)
        {
            int yearRemaning = 18 - numInput;

            if (numInput >= 18)
            {
                return "Congratulations, you are eligible. Do not forget to register to vote.";
            }
            else
            {
                return $"In {yearRemaning} years, you will be eligible to vote.";
            }

       

        }

        
        }
    }

        

    
