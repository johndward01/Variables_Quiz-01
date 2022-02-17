using System;
using System.Diagnostics;

namespace Variables_Quiz01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!  This will be an exerecise in Variable Declaration and Initialization!");
            Console.WriteLine();
            Console.WriteLine("Try to get the lowest possible score. . .");
            Console.WriteLine();
            Console.Write("Hit any key to begin the quiz and start the timer: "); Console.ReadLine();
            Console.WriteLine();

            Stopwatch sw = Stopwatch.StartNew();

            var answer1 = "int a;"; // declare a variable of type int called a
            var answer2 = "string b = \"\";"; // declare and initialize a string variable called b with a value of an empty string 
            var answer3 = "bool c = true;"; // declare and initialize a boolean variable called c with a value of true
            var answer4 = "char d = 'D';"; // declare and initialize a character type variable called d with a capital D as the value
            var answer5 = "string _title;"; // declare a variable of type string called _title
            var answer6 = "bool isComplete;"; // declare a variable of type bool called isComplete
            var answer7 = "string userName;"; // declare a string variable called userName
            var answer8 = "userName = \"John_Doe\";"; // initialize the variable userName to the value of "John_Doe"
            var answer9 = "string password = \"JD_123!!\";"; // declare and initialize a string variable called password with a value of "JD_123!!"


            var guess = "";
            var wrongCount = 0;

            do
            {
                Console.WriteLine("Declare a variable of type int called a:");
                guess = Console.ReadLine();
                if (guess == answer1)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("Declare and initialize a string variable called b with a value of an empty string:");
                guess = Console.ReadLine();
                if (guess == answer2)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer2 != guess);

            do
            {
                Console.WriteLine("Declare and initialize a boolean variable called c with a value of true:");
                guess = Console.ReadLine();
                if (guess == answer3)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer3 != guess);

            do
            {
                Console.WriteLine("Declare and initialize a character type variable called d with a capital D as the value:");
                guess = Console.ReadLine();
                if (guess == answer4)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer4 != guess);

            do
            {
                Console.WriteLine("Declare a variable of type string called _title:");
                guess = Console.ReadLine();
                if (guess == answer5)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer5 != guess);

            do
            {
                Console.WriteLine("Declare a variable of type bool called isComplete:");
                guess = Console.ReadLine();
                if (guess == answer6)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer6 != guess);

            do
            {
                Console.WriteLine("Declare a string variable called userName:");
                guess = Console.ReadLine();
                if (guess == answer7)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer7 != guess);

            do
            {
                Console.WriteLine("Initialize the variable userName to the value of \"John_Doe\":");
                guess = Console.ReadLine();
                if (guess == answer8)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer8 != guess);

            do
            {
                Console.WriteLine("Declare and initialize a string variable called password with a value of \"JD_123!!\":");
                guess = Console.ReadLine();
                if (guess == answer9)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer9 != guess);

            var time = sw.Elapsed.TotalSeconds;

            Console.WriteLine("Total seconds to complete:");
            Console.WriteLine(time);

            int score = (int)((time * .4) + (wrongCount * .6));

            Console.WriteLine("Your Score:");
            Console.WriteLine(score);
            Console.ReadLine();
        }

    }
}
