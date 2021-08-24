using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            // parameters
            string name;
            DateTime currentDate = DateTime.Now;
            DateTime borrowDate = DateTime.Now;
            int bookType = 0;
            int firstNumber = 0;
            int countWeeks = 0;
            double fine = 0;
            string bookT = "";

            double dateDiffer;

            // data
            Console.WriteLine("What is the name of the book?");
            name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the current date?");
                    currentDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the book code? It contains 4 digits.");
                    bookType = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("WHat is the rent date?");
                    borrowDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }

            // math
            dateDiffer = (currentDate - borrowDate).TotalDays;
            string bt = bookType.ToString();
            if (bookType >= 10)
            {
                bt = bt.Remove(bt.Length - (bt.Length - 1));
            }
            firstNumber = Convert.ToInt32(bt);
            if (firstNumber == 9)
            {
                bookT = "Roman";
            }
            else
            {
                bookT = "School";
            }
            if (dateDiffer > 21 && bookT == "Roman")
            {
                fine = 0.25 * (dateDiffer - 21);
            }
            else if (dateDiffer > 30 && bookT == "School")
            {
                double t = dateDiffer - 30;
                while (t > 0)
                {
                    t = t - 7;
                    countWeeks++;
                }
                fine = countWeeks++;
            }

            // conclusion
            Console.WriteLine("The name is: " + name);
            Console.WriteLine("The book code is: " + bookType);
            Console.WriteLine("The book type is: " + bookT);
            Console.WriteLine("The current date is: " + currentDate);
            Console.WriteLine("The rent date is: " + borrowDate);
            Console.WriteLine("The amount of days renting the book is: " + dateDiffer);
            Console.WriteLine("The fine is: " + fine);
        }
    }
    // uitleendatum
    // retourdatum
    // elke maand 30 dagen
    // romans
        // meer dan 21 dagen boete van 0,25 euro per dag
    // studieboeken
        // meer dan 30 dagen boete van 1 euro per week
            // deel van week is volle week
    //soort boek aan hand van 4-cijfer boeknummmer
        // roman: 1e cijfer = 9
        // studie: 1e cijfer <> 9

    // bepaal boete voor boeken
}
