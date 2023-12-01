using ReviewExtensionMethod;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        //nhập vào biến i
        Console.Write("Vui lòng nhập số: ");
        int i = int.TryParse(Console.ReadLine(), out int result) ? result : 0; //khi nhập kiểu ko phải số thì trả về 0
        Console.WriteLine($"{nameof(i)}={i}"); //xuất ra biến i

        //so sánh i với một giá trị bất kỳ
        Console.WriteLine(Valid.isGreaterThan(i, 100) ? "i lớn hơn" : "i nhỏ hơn");

        //so sánh i với một giá trị bất kỳ, dùng extension method
        Console.WriteLine(i.isGreater(100) ? "i lớn hơn" : "i nhỏ hơn");

        //bất kỳ biến nào là int đều gọi được cái extension method
        int x = 50;
        Console.WriteLine(x.isGreater(100) ? "x lớn hơn" : "x nhỏ hơn");

        Program pro1 = new();
        pro1.Hi();
    }
}