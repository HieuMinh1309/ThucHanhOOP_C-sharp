using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCSharp;
internal class SomeFile : IBinaryFile, ITextFile
{
    //thực thi các phương thức của interface bổ từ truy cập (access modify) phải là public
    public void ReadFile() => Console.WriteLine("read file");

    public void WriteBinaryFile()=> Console.WriteLine("write binary file");

    public void WriteTextFile()=> Console.WriteLine("write text file");
}
