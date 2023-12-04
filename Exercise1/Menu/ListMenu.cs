using Exercise1.Dao;
using Exercise1.ExtMethod;
using Exercise1.Valid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Menu;
public class ListMenu
{
    public static void ShowMenu()
    {
        var loop = true;
        ListProduct list = new();
        while (loop)
        {
            Console.ResetColor();
            Console.WriteLine("1. Input Product");
            Console.WriteLine("2. Show List Product");
            Console.WriteLine("3. Delete By Id");
            Console.WriteLine("4. Find Product by Id");
            Console.WriteLine("5. Sort List");
            Console.WriteLine("Press any key to exit");
            Console.Write("Choose: ");
            string key =Console.ReadLine();
            switch (key)
            {
                case "1":
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Cyan);
                    list.AddProduct();
                    break;
                case "2":
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Red);
                    list.ShowProduct(); break;
                case "3":
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Green);
                    list.DeleteProduct(); break;
                case "4":
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Yellow);
                    list.FindProduct(); break;
                case "5":
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Magenta);
                    list.SortProduct(); break;
                default: loop = false; break;
            }
        }
    }
}
