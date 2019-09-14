using System;

namespace Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACCEPTING USER INPUT");
            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            }
            while (enteredKey.Key != ConsoleKey.Escape);
            string sentence;
            do
            {
                Console.WriteLine("Type in a sentence. Press enter when done.");
                sentence = Console.ReadLine();
                Console.WriteLine($"You entered the sentence: {sentence}");
            } while (sentence != "quit");
            
            //Number multipler 
            Console.WriteLine("NUMBER MULTIPLIER");
            var stringNumbers1 = "1,2,3";
            var stringNumbers2 = "2,4,5";

            var numGroup1 = stringNumbers1.Split(",");
            var numGroup2 = stringNumbers2.Split(",");

            int numValue1 = 1;
            int numValue2 = 1;
            string numSquareValue1 = "";
            string numSquareValue2 = "";
            Console.WriteLine($"({stringNumbers1}), ({stringNumbers2})");
            Console.WriteLine("Type 'multiply' to multiply each group of numbers together, or type 'square' to square each number in the two groups.");
            var selection = Console.ReadLine();

            if (selection == "multiply")
            {
                foreach (var num in numGroup1)
                {
                    int intNum = int.Parse(num);
                    numValue1 = intNum * numValue1;
                }

                foreach (var num in numGroup2)
                {
                    int intNum = int.Parse(num);
                    numValue2 = intNum * numValue2;
                }
                Console.WriteLine(numValue1);
                Console.WriteLine(numValue2);
            }
            else if (selection == "square")
            {
                foreach (var num in numGroup1)
                {
                    int intNum = int.Parse(num);
                    if (numSquareValue1.Length == 0)
                    {
                        numSquareValue1 = (intNum * intNum).ToString();
                    }
                    else
                    {
                        numSquareValue1 = $"{numSquareValue1}, {(intNum * intNum).ToString()}";
                    }
                }
                foreach (var num in numGroup2)
                {
                    int intNum = int.Parse(num);
                    if (numSquareValue2.Length == 0)
                    {
                        numSquareValue2 = (intNum * intNum).ToString();
                    }
                    else
                    {
                        numSquareValue2 = $"{numSquareValue2}, {(intNum * intNum).ToString()}";
                    }
                }

                Console.WriteLine(numSquareValue1);
                Console.WriteLine(numSquareValue2);
            }
           
             //LETTER LOOPS
            Console.WriteLine("LETTER LOOPS");

            Console.WriteLine("Type a random string.");
            var userInput = Console.ReadLine();
            string letterLoop = "";
            int counter = 0;

            foreach (var character in userInput)
            {
                string inputCharacters = character.ToString().ToUpper();
                for (var i = 0; i < counter; i++)
                {
                    inputCharacters = inputCharacters + character.ToString().ToLower();
                }
                counter++;

                if (letterLoop.Length == 0)
                {
                    letterLoop = inputCharacters;
                }
                else
                {
                    letterLoop = $"{letterLoop}-{inputCharacters}";
                }
            }

            Console.WriteLine(letterLoop);

        }

    }
    }
