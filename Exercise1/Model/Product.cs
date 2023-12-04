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
    public static List<Product> list { get; set; } = [];

    public static List<Product> InputPro()
    {
        int amount = Valid<int>.CheckCR("Amount of product you want to input: ");
        for (int i = 0; i < amount; i++)
        {
            Product product = new();
            Console.WriteLine($"Enter details for product #{i + 1}");
            product.ProId = Valid<int>.CheckCR("Id: ");
            bool idExists = list.Any(product1 => product1.ProId == product.ProId);
            while (idExists)
            {
                Console.WriteLine("Id already exists. Please enter a different Id.");
                product.ProId = Valid<int>.CheckCR("Id: ");
                idExists = list.Any(product1 => product1.ProId == product.ProId);
            }
            product.ProName = Valid<string>.CheckCR("Product Name: ");
            product.ProPrice = Valid<double>.CheckCR("Product Price: ");
            product.Quantity = Valid<int>.CheckCR("Quantity: ");
            product.ProMfg = Valid<DateTime>.CheckCR("Manufacture: ");
            Console.WriteLine("========================");
            
            list.Add(product);
        }

        return list;
    }

    public static List<Product> OutPut()
    {
        list.ForEach(Console.WriteLine);
        return list;
    }

    public void DeleteProduct()
    {
        int id = Valid<int>.CheckCR("Id to delete: ");
        list.RemoveAll(p => p.ProId == id);
    }

    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice.ToString()}, {nameof(Quantity)}={Quantity.ToString()}, {nameof(ProMfg)}={ProMfg.ToString()}}}";
    }
}
