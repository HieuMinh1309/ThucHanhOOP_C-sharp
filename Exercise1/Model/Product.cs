using Exercise1.Valid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Model;
public class Product
{
    public int ProId { get; set; }
    public string ProName { get; set; }
    public double ProPrice { get; set; }
    public int Quantity { get; set; }
    public DateTime ProMfg { get; set; }

    public static List<Product> InputPro(List<Product> list)
    {
        int amount = Valid<int>.CheckCR("Amount of product you want to input: ");
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine($"Enter details for product #{i + 1}");
            int id = Valid<int>.CheckCR("Id: ");
            bool idExists = list.Any(product => product.ProId == id);
            while (idExists)
            {
                Console.WriteLine("Id already exists. Please enter a different Id.");
                id = Valid<int>.CheckCR("Id: ");
                idExists = list.Any(product => product.ProId == id);
            }
            string proname = Valid<string>.CheckCR("Product Name: ");
            double proprice = Valid<double>.CheckCR("Product Price: ");
            int quantity = Valid<int>.CheckCR("Quantity: ");
            DateTime promfg = Valid<DateTime>.CheckCR("Manufacture: ");
            Console.WriteLine("========================");
            Product product = new()
            {
                ProId = id,
                ProName = proname,
                ProPrice = proprice,
                Quantity = quantity,
                ProMfg = promfg
            };
            list.Add(product);
        }

        return list;
    }

    public static List<Product> OutPut(List<Product> list)
    {
        foreach(var product in list)
        {
            Console.WriteLine(product);
        }
        return list;
    }

    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice.ToString()}, {nameof(Quantity)}={Quantity.ToString()}, {nameof(ProMfg)}={ProMfg.ToString()}}}";
    }
}
