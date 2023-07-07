namespace Lab2_b_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
            Console.ReadLine();
            
        }

        static void StartSequence()
        {
            int[] numberArray = new int[4]; //Declare array of four zeros
            int[] populateResult = Populate(numberArray); //Call populate method
            int sum = GetSum(populateResult); // Sum of numbers in array
            Console.WriteLine(sum);

            for (int i = 0; i < populateResult.Length; i++)
            {
                Console.WriteLine(populateResult[i] + " ");
            }

           int product = GetProduct(populateResult, sum);
            GetQuotient(product);
        }

       static int[] Populate(int[] array)
        {
            
            //Loop through array and prompt user for values
            for (int i = 0; i < array.Length; i++)
            {
                
                Console.WriteLine("Give me a number");
                string userInput = Console.ReadLine();
                int number = Int32.Parse(userInput);
                array[i] = number;
            }
            return array;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;

            //Loop through the array to add all the numbers
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            

            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Pick a random number between 1 and {0}", array.Length);
            string randomIndex =Console.ReadLine() ;
            int randomIndexInt = Int32.Parse(randomIndex);
            randomIndexInt = randomIndexInt -1 ;
            int randomNumber = array[randomIndexInt];
            Console.WriteLine("Random number is: {0}", randomNumber);

            //Multiply the sum and the random number
            int product = randomNumber * sum;
            Console.WriteLine("This is the product: {0}", product);
            return product;
        }

        static decimal GetQuotient(int product)
        {
          // Prompt user for number to divide product by
            Console.WriteLine("Give me a number to divide the product by ");
            string userInput = Console.ReadLine();
            int divisor = Int32.Parse(userInput);
            decimal quotient = product / divisor;

            Console.WriteLine("This is the quotient: {0}", quotient);

            return quotient;
        }
    }
}