using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListOfShortLib;

namespace Lab8Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lab №8";
            ProgramInfo();
            Console.WriteLine();
            ListOfShort list = new ListOfShort();
            ListMenu(list);
        }
        static void ProgramInfo()                                       // prints information about the program
        {
            Console.WriteLine("Lab №8. Nikita Chernikov, IS-02");
            Console.WriteLine("Researching of building and using datastructures");
            Console.WriteLine("Variant 15");
        }
        static void ListMenu(ListOfShort list)
        {
            PrintHelp(list);
            Console.WriteLine("What do you want to do?");
            bool parsed;
            short choice;
            const short minPoint = 1;
            const short maxPoint = 5;
            do
            {
                Console.WriteLine($"\nEnter the number {minPoint} - {maxPoint}: ");
                parsed = short.TryParse(Console.ReadLine(), out choice);
                if (!parsed || choice < minPoint || choice > maxPoint)
                {
                    Console.WriteLine($"Error: you entered not a number or number was smaller than {minPoint} or bigger than {maxPoint}.");
                    Console.WriteLine($"Help - {maxPoint - 1}");
                    choice = minPoint - 1;
                }
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        ProgramInfo();
                        Console.WriteLine();
                        short number;
                        Console.WriteLine("Enter the short number you want to add:");
                        parsed = short.TryParse(Console.ReadLine(), out number);
                        while (!parsed)
                        {
                            Console.WriteLine("Enter the short number you want to add once more:");
                            parsed = short.TryParse(Console.ReadLine(), out number);
                        }
                        Node newNode = ListOfShort.CreateNode(number);
                        list.AddLast(newNode);
                        Console.WriteLine("List of shorts current state:");
                        for (int i = 0; i < list.GetLength(); i++)
                            Console.Write(list[i] + " ");
                        Console.WriteLine("\nPress ENTER to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        ProgramInfo();
                        Console.WriteLine();
                        Console.WriteLine("List of shorts current state:");
                        for (int i = 0; i < list.GetLength(); i++)
                            Console.Write(list[i] + " ");
                        Console.WriteLine($"\nThere are {list.CountMultiplesOfSeven()} multiples of 7 in the list.");
                        Console.WriteLine("\nPress ENTER to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        ProgramInfo();
                        Console.WriteLine();
                        Console.WriteLine("List of shorts before replacement:");
                        for (int i = 0; i < list.GetLength(); i++)
                            Console.Write(list[i] + " ");
                        Console.WriteLine($"\nAverage: {list.GetAverage():F3}");
                        list.ChangeMoreThanAverageToZero();
                        Console.WriteLine("List of shorts current state:");
                        for (int i = 0; i < list.GetLength(); i++)
                            Console.Write(list[i] + " ");
                        Console.WriteLine("\nPress ENTER to continue");
                        Console.ReadLine();
                        break;
                }
                if (choice >= minPoint && choice < maxPoint)
                {
                    PrintHelp(list);
                    Console.WriteLine("What do you want to do?");
                }
            } while (choice != maxPoint);
        }
        public static void PrintHelp(ListOfShort list)
        {
            Console.Clear();
            ProgramInfo();
            Console.WriteLine();
            Console.WriteLine("List of shorts current state:");
            for (int i = 0; i < list.GetLength(); i++)
                Console.Write(list[i] + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add number to the end");
            Console.WriteLine("2. Count the quantity of the multiples of 7");
            Console.WriteLine("3. Replace all numbers ");
            Console.WriteLine("4. Print help");
            Console.WriteLine("5. Quit");
        }
    }
}
