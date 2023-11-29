using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndLinq;
internal class Student
{
    public int RollNumber { get; set; }
    public string Fullname { get; set; }
    public string Section { get; set; }
    public int RoomNumber { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(RollNumber)}={RollNumber.ToString()}, {nameof(Fullname)}={Fullname}, {nameof(Section)}={Section}, {nameof(RoomNumber)}={RoomNumber.ToString()}}}";
    }
}
