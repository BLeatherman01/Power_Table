using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Powers_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            
            bool keepGoing = true;

            while (keepGoing == true)
            {
                Console.WriteLine("Please enter a positive integer");
                
                string input = Console.ReadLine();
                int num = int.Parse(input);

               Console.WriteLine("Number\tSquared\tCubed \n======= ======= =====");

                for (int i = 1; i <= num; i++)
                {
                   Console.WriteLine($"{i} \t{i * i} \t{i * i * i}");
                }
           
               Console.WriteLine("\nWould you like to check a new number? Y/N");
               string goOn = Console.ReadLine().ToLower();

                if (goOn == "y")
                {
                    continue;
                }
                else if (goOn == "n")
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that let's try that again");
                }
            }
        }
    }
}