using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCSharp;
public class AnyFile : ITextFile, IBinaryFile
{
    public void WriteBinaryFile() => Console.WriteLine("write binary file");
    public void WriteTextFile() => Console.WriteLine("write text file");
    //dùng chính tên interface, nên không dùng từ public
    void ITextFile.ReadFile() => Console.WriteLine("read file");
    void IBinaryFile.ReadFile() => Console.WriteLine("read file");
}
