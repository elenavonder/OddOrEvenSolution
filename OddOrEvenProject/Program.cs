using System;

namespace OddOrEvenProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.write lets them enter an answer
            Console.Write("Enter an Integer: ");
            var response = Console.ReadLine();
            //Console.WriteLine(response);
            var nbr = Convert.ToInt32(response);
            var isEven = true;
            if (nbr % 2 == 1)//If nbr = 1 it's false(reciprical)
            { 
                isEven = false;
            }
            if (isEven)
            {
                Console.WriteLine($"The number {nbr} is even.");
            }else{
                Console.WriteLine($"The number {nbr} is odd.");
            }
        }
    }
}
