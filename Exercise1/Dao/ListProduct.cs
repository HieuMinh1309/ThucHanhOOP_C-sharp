using Exercise1.IService;
using Exercise1.Model;
using Exercise1.Valid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Dao;
public class ListProduct : IDao
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

    public void FindProduct()
    {
        //trùng thì xài FirstOrDefault còn nếu duy nhất thì SingleOrDefault
        int id = Valid<int>.CheckCR("Id to Find: ");
        var findPro= ListPro.SingleOrDefault(p => p.ProId == id); //SingleOrDefault
        //var findPro= ListPro.First(p => p.ProId == id); //First (tìm thấy thằng đầu tiền sẽ hiển thị ra)
        //var findPro = ListPro.Single(p => p.ProId == id); //Single (hiển thị tất cả những thằng tìm thấy nhưng không trùng
        if(findPro is not null)
        {
            Console.WriteLine(findPro);
        }
    }

    public void SortProduct()
    {   
        //sql server
        //ListPro.OrderBy <=> ListPro.OrderByDescending()
        //cách này sẽ chỉ sort ở trong nó thôi
        var list = ListPro.OrderBy(p => p.ProId);
        list.ToList().ForEach(Console.WriteLine);

        //quick sort
        //cách này sort sẽ sort cả bên dưới list luôn
        //ListPro.Sort() <=> ListPro.Reverse()
        ListPro.Sort((p1,p2) => p1.ProId.CompareTo(p2.ProId));
    }

    //về làm update
}
