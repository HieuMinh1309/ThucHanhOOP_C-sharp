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
                default: loop = false; break;
            }
        }
    }
}
