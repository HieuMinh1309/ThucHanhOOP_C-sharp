using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Model;
public class Product
{
    public string ProId { get; set; }
    public string ProName { get; set; }
    public double ProPrice { get; set; }
    public int Quantity { get; set; }
    public DateTime ProMfg { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice.ToString()}, {nameof(Quantity)}={Quantity.ToString()}, {nameof(ProMfg)}={ProMfg.ToString()}}}";
    }
}
