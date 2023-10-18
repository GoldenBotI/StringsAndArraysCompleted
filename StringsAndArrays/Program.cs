namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations
            // 1.1 Print the length of the string.
            string helloWorld = "Hello, World!";
            int a = helloWorld.Length;
            Console.WriteLine($"The length of the given string is {a} characters.");
            // 1.2 Print the first and the last character of the string.
            char b = helloWorld[0];
            char c = helloWorld[a - 1];
            Console.WriteLine($"The first character of the given string is '{b}' and the last one is '{c}'.");

            // 2. String Manipulation
            // 2.1 Get the input from and assing it into new string variable called name
            Console.Write("Please enter your name: "); string name = Console.ReadLine();
            // 2.2 Print a personalized welcome message including the name.
            Console.WriteLine($"Hello and welcome to C#, {name}!");
            // 2.3 Convert name variable to uppercase and output the result
            // 2.4 Convert name variable to lovercase and output the result
            string nameUp = name.ToUpper();
            string nameDown = name.ToLower();
            Console.WriteLine($"Here also your name, {name}, in upperscale - '{nameUp}', and lowerscale - '{nameDown}'.");

            // 3. String Searching
            Console.WriteLine("Here, we will check, if given string 'helloWorld' contains word 'World'.");
            // 3.1 Create new boolean variable called containsWorld
            // 3.2 Check that the helloWorld variable contains the word "World".
            //     Assign the result to the created constainsWorld variable
            bool containsWorld = helloWorld.Contains("World");
            // 3.3 If the word is found, get the index of the word from helloWorld string
            if (containsWorld == true) 
                Console.WriteLine($"Our word has been found, and it's index in given string is {helloWorld.IndexOf("World")}.");
            else 
                Console.WriteLine("Sorry, given word could not be found.");

            // PART 2: Arrays
            // 1. Basic Array Operations
            // 1.1 initialize array called numbers containing array of int values
            //     Add these values to the array -> 2 3 5 7 11 
            int[] numbers = { 2, 3, 5, 7, 11 };
            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11
            for (int i = 0; i < numbers.Length; i++)
                Console.Write($"{numbers[i]} ");
            // 1.3 Output the value of the third (3th) item in the numbers array 
            // Expected outcome: 5
            Console.WriteLine("");
            Console.WriteLine(numbers[2]);

            // 2. Array Manipulation
            Console.WriteLine("Please enter five names:");
            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5
            string[] names = new string[5];
            // 2.2 Ask the user to input new names 5 times
            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Please enter {i + 1} name: ");
                names[i] = Console.ReadLine();
            }
            // 2.3 Output the array of given names.
            for (int i = 0; i < names.Length; i++)
                Console.Write($"{names[i]} ");
            Console.WriteLine("");
            // 2.4 Reverse the order of the items in the names array and outpu the result
            for (int i = names.Length - 1; i >= 0; i--)
                Console.Write($"{names[i]} ");
            Console.WriteLine("");

            // 3. Array Searching
            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable
            Console.Write("Please enter a name to search: ");
            string searchName = Console.ReadLine();
            int position = Array.IndexOf(names, searchName);
            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            // 3.2.1 If position is found output the searchName and the found position
            if (position != -1)
                Console.WriteLine($"Entered name '{searchName}' was found in array with index {position}.");
            // 3.2.2 Else output that the searchName was not found
            else
                Console.WriteLine($"Sorry, looks like the name '{searchName}' you entered does not exist in this array.");

            // 4. BONUS
            // 1. String to Array
            // 1.1 Create new empty words string array
            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array
            string[] bonusRound = helloWorld.Split(' ');
            // 1.3 Output the values of the words array
            for (int i = 0; i < bonusRound.Length; i++)
                Console.WriteLine($"{i + 1} element of array is {bonusRound[i]}.");

        }
    }
}
