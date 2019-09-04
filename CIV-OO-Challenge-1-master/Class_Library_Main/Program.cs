using System;
using Class_Library;

namespace Class_Library_Main
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input.ToLower() != "e")
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Would you like to: ");
                Console.WriteLine("(A)Create Squarer");
                Console.WriteLine("(C)Create Rectangle");
                Console.WriteLine("(E)xit");
                Console.Write("Enter selection: ");

                input = Console.ReadLine();

                if (input.ToLower() == "a")
                {
                    
                    Console.WriteLine("Please enter Colour: ");
                    string color = Console.ReadLine();
                    Console.WriteLine("Please enter esquare Length: ");
                    int s1 = int.Parse(Console.ReadLine());

                    if (s1>=1)
                    {
                        Square sq = new Square(color, s1);
                        Console.WriteLine(sq+" New square : {0} ,{1} ",color,s1);
                    }
                    else
                    {
                        string msg = String.Format("No length less than 1!");


                        throw new InvalidLengthException(msg);
                    }
                    
                }
                else if (input.ToLower() == "c")
                {
                    Console.WriteLine("Please enter Colour: ");
                    string color = Console.ReadLine();
                    Console.WriteLine("Please enter rectangle Length: ");
                    int s1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter rectangle Width: ");
                    int s2 = int.Parse(Console.ReadLine());
                    if (s1 >= 1&& s2>=1)
                    {
                        Rectangle rec = new Rectangle(color, s1, s2);

                        Console.WriteLine(rec+ " New Rectangle {0}, {1}), (2}",color,s1,s2);
                    }
                    else
                    {
                        string msg = String.Format("No length less than 1!");


                        throw new InvalidLengthException(msg);
                    }
                    
                }
                else if (input.ToLower() == "e")
                {
                    break;
                }
                else
                {
                    string msg = String.Format("Invalid Input!!!");

                    throw new InvalidInputException(msg);
                }
            }
        }
    }
}