using System;
using System.Collections.Generic;

namespace color
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> colorList = new Dictionary<string, int>()
            {
                {"White",0},
                {"Yellow",0},
                {"Orange",0},
                {"Red",0},
                {"Blue",0},
                {"Green",0},
                {"Brown",0},
                {"Black",0}
            };
            string colorCode, favoritecolor, message = string.Empty;
            showColorlist(colorList);           
            
            message = ShowFirstMessage();
            while (true)
            {
                if (IsExit(message))
                {
                    PrintColors(colorList);
                    PrintExit();
                    break;
                }
                colorCode = message;
                favoritecolor = IsColor(colorCode);
                checkValue(colorList, myColor: favoritecolor);
                
                message = ShowFirstMessage();
            }
        }
        static void checkValue(Dictionary<string, int> Color,string myColor)
        {
            if (Color.ContainsKey(myColor) == true)
            {
                Color[myColor]++;
                Console.WriteLine($"{myColor} : {Color[myColor]}");
            }
        }
        static string ShowFirstMessage()
        {
            string message = "\nPlease Enter your Favorite color Code please!  or Type E  for Exit from App";
            Console.WriteLine(message);
            message = Console.ReadLine();
            return message;
        }
        static bool IsExit(string str)
        {
            if (str == "e" || str == "exit")
                return true;
            else
                return false;
        }

        static void showColorlist(Dictionary<string, int> Color)
        {
            int i = 0;
            foreach (var element in Color)
            {
                i++;
                Console.WriteLine($"{i}: {element.Key}");
            }
        }
        static void PrintColors(Dictionary<string, int> Color)
        {
            foreach (var element in Color)
            {
                Console.WriteLine($"\n{element.Key} : {element.Value}");
            }
        }
        static void PrintExit()
        {
            Console.WriteLine("\nYou Exit From App. * have a good day! *");
        }
        static string IsColor(string code)
        {
            string color = string.Empty;
            switch (code)
            {
                case "1":
                    color = "White";
                    break;
                case "2":
                    color = "Yellow";
                    break;
                case "3":
                    color = "Orange";
                    break;
                case "4":
                    color = "red";
                    break;
                case "5":
                    color = "blue";
                    break;
                case "6":
                    color = "green";
                    break;
                case "7":
                    color = "Brown";
                    break;
                case "8":
                    color = "Black";
                    break;
                default:
                    Console.WriteLine("\nyour Code is Unvalid!");
                    break;
            }
            return color;
        }
    }
}