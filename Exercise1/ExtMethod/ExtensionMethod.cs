using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.ExtMethod;
static class ExtensionMethod
{
    public static void ChangeColor<T>(this T item, params ConsoleColor[] color)
    {
        Console.BackgroundColor = color[0];
        Console.ForegroundColor = color[1];
    }
}
