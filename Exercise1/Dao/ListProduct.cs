using Exercise1.Model;
using Exercise1.Valid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Dao;
public class ListProduct
{
    public List<Product> ListPro { get; set; } = [];

    public void AddProduct()
    {
        int amount = Valid<int>.CheckCR("Amount of product you need to input: ");
        for(var i = 0; i < amount; i++)
        {
            Product pro = new()
            {
                ProId = Valid<int>.CheckCR("Id: "),
                ProName = Valid<string>.CheckCR("Pro Name: "),
                ProPrice = Valid<double>.CheckCR("Pro Price: "),
                Quantity = Valid<int>.CheckCR("Quantity: "),
                ProMfg = Valid<DateTime>.CheckCR("Manufacture: ")
            };
            ListPro.Add(pro);
        }
    }

    public void ShowProduct()
    {
        ListPro.ForEach(Console.WriteLine);
    }

    public void DeleteProduct()
    {
        int id = Valid<int>.CheckCR("Id to delete: ");
        ListPro.RemoveAll(p => p.ProId == id);
        //ListPro.RemoveAll(p => p.Proid.ToLower() == id.ToLower())
        //ListPro.RemoveAll(p => string.Compare(p.proId, id, true) == 0)
    }

}
