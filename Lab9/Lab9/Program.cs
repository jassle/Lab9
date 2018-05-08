using Lab9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string> { "Jason", "Kamel", "Riyad", "Mike", "Toni", "Tim", "Anna", "Anthony", "Sarah", "Racheal", "Jasmine", "Mcmike" };
            List<string> FavFood = new List<string> { "Cake", "Fries", "BK", "Pizza", "Pizza", "Pork Rinds", "Salmon", "Sonic", "Yogurt", "Apples", "7up Cake", "Cannolis" };
            List<string> Hometown = new List<string> { "Royal Oak", "Troy", "Frankenmuth", "Troy", "Dallas", "Ft Wayne", "Petoskey", "Rochester Hills", "Farmington", "Grand Rapids", "Northville", "Southfield" };
            List<string> FavColor = new List<string> { "Blue", "Fuscia", "Red", "Green", "Orange/Gray", "Yellow", "Blue", "Purple", "Pink", "Green", "Purple", "Magenta" };
            int Namind;
            int MenuChoice;
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Welcome to Grand Circus C# Class April 2018!!");

                Console.WriteLine($"Please enter a number from 1 - {Names.Count} to access a profile");
                for (int i = 0; i < Names.Count; i++)

                {
                    Console.WriteLine($"{i + 1,-3}{Names[i]}");
                }
                Console.WriteLine($"{Names.Count + 1,-3}Add new student");

                Namind = ValidInput(Names.Count);
                Console.Clear();
                if (Namind == Names.Count + 1)
                {
                    Console.WriteLine("Please enter all data starting with a capital letter");
                    Names.Add(AddValidate("Enter Students Name:", "^[A-Z][a-z]{1,15}$"));
                    FavFood.Add(AddValidate("Enter Students Favorite Food:", "^[A-Z][a-z]{1,15}$"));
                    Hometown.Add(AddValidate("Enter Students Hometown:", "^[A-Z][a-z]{1,15}$"));
                    FavColor.Add(AddValidate("Enter Students Favorite Color:", "^[A-Z][a-z]{1,15}$"));
                }
                Console.WriteLine(Names[Namind - 1]);

                Console.WriteLine($"Would you like to know more about {Names[Namind - 1]}?");
                Console.WriteLine("Hometown(1) Favorite food(2) Favorite color(3) New Student(4) Quit(5)");
                bool newprofile = true;
                while (newprofile)
                {
                    MenuChoice = MenuInput();

                    switch (MenuChoice)
                    {
                        case 1:
                            Console.WriteLine($"{Names[Namind - 1]}'s hometown is {Hometown[Namind - 1]}");
                            Console.WriteLine("Hometown(1) Favorite food(2) Favorite color(3) New Student(4) Quit(5)");
                            break;
                        case 2:
                            Console.WriteLine($"{Names[Namind - 1]}'s favorite food is {FavFood[Namind - 1]}");
                            Console.WriteLine("Hometown(1) Favorite food(2) Favorite color(3) New Student(4) Quit(5)");
                            break;
                        case 3:
                            Console.WriteLine($"{Names[Namind - 1]}'s favorite color is {FavColor[Namind - 1]}");
                            Console.WriteLine("Hometown(1) Favorite food(2) Favorite color(3) New Student(4) Quit(5)");
                            break;
                        case 4:
                            newprofile = false;
                            break;
                        case 5:
                            repeat = false;
                            newprofile = false;
                            break;

                    }
                }

            }
        }

        private static string AddValidate(string prompt, string regex)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            while (!Regex.IsMatch(input, regex))
            {
                Console.WriteLine($"Invalid input. {prompt}");
                input = Console.ReadLine();
            }

            return input;
        }

        private static int ValidInput(int MaxValue)
        {
            int Namind;
            while (!int.TryParse(Console.ReadLine(), out Namind) || Namind < 1 || Namind > MaxValue+1)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine($"Please enter a number from 1 - {MaxValue+1} to access a profile");
            }

            return Namind;
        }

        private static int MenuInput()
        {
            int menuChoice;
            while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 5)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Please choose a number from 1 - 5");
            }

            return menuChoice;
        }
        public static bool Continue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }
    }
}
