using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1;
public class Valid<T>
{
    public static T CheckCR(string message)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.Write(message);
        var type = Type.GetTypeCode(typeof(T));
        var i = new object();
        bool flag;

        do
        {
            flag = true;
            try
            {
                var str = Console.ReadLine();
                //guard clause - design pattern
                if (String.IsNullOrEmpty(str))
                    throw new Exception("Can't be null or empty, Please enter: ");

                switch (type)
                {
                    case TypeCode.String:
                        i = str;
                        if ((i as string).Length < 5)
                            throw new Exception("lỗi, chuỗi phải lớn hơn 5");
                        break;
                    case TypeCode.Int32:
                        i = Convert.ToInt32(str);
                        if ((int)i < 0)
                            throw new Exception("lỗi, số phải lớn hơn 0");
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, ["dd/MM/yyyy", "dd-MM-yyyy"], new CultureInfo("vi-VN"), DateTimeStyles.None, out DateTime t)?t:throw new Exception("lỗi, không đúng định dạng (phải là dd/MM/yyyy hoặc dd-MM-yyyy)");
                        i = date.Add(DateTime.Now.TimeOfDay); //để lấy giờ phút giây do bên trên chỉ lấy được ngày tháng năm
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}, Please Enter Again!");
                flag = false;
            }
        } while (!flag);
        return (T)i;
    }
}
