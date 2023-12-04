using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Valid;
public class Valid<T>
{
    public static T CheckCR(string message)
    {
        Console.Write(message);
        var type = Type.GetTypeCode(typeof(T));
        var i = default(T);
        bool flag = false;

        while (!flag)
        {
            flag = true;
            try
            {
                #region oldstyle
                //var str = Console.ReadLine();
                ////guard clause - design pattern
                //if (string.IsNullOrEmpty(str)) 
                //    throw new Exception("Can't be null or empty, Please enter: ");
                //switch (type)
                //{
                //    case TypeCode.String:
                //        i = str;
                //        if ((i as string).Length < 5)
                //            throw new Exception("lỗi, chuỗi phải lớn hơn 5");
                //        break;
                //    case TypeCode.Int32:
                //        i = Convert.ToInt32(str);
                //        if ((int)i < 0)
                //            throw new Exception("lỗi, số phải lớn hơn 0");
                //        break;
                //    case TypeCode.DateTime:
                //        var date = DateTime.TryParseExact(str, ["dd/MM/yyyy", "dd-MM-yyyy"], new CultureInfo("vi-VN"), DateTimeStyles.None, out DateTime t) ? t : throw new Exception("lỗi, không đúng định dạng (phải là dd/MM/yyyy hoặc dd-MM-yyyy)");
                //        i = date.Add(DateTime.Now.TimeOfDay); //để lấy giờ phút giây do bên trên chỉ lấy được ngày tháng năm
                //        break;
                //}
                #endregion
                var str = Console.ReadLine() ?? throw new Exception("Can't be null or empty, Please enter: ");
                i = type switch
                {
                    TypeCode.String => ((string)str).Length > 2 ? (T)(object)str : throw new Exception("lỗi, chuỗi phải lớn hơn 2"),
                    TypeCode.Int32 => (int.TryParse(str, out int value) && value > 0) ? (T)(object)value : throw new Exception("lỗi, số phải lớn hơn 0 hoặc không đúng định dạng"),
                        TypeCode.Double => (double.TryParse(str,out double value1) && value1>0)? (T)(object)value1 : throw new Exception("lỗi, số phải lớn hơn 0 hoặc không đúng định dạng"),
                    TypeCode.DateTime => DateTime.TryParseExact(str, new[] { "dd/MM/yyyy", "dd-MM-yyyy" }, new CultureInfo("vi-VN"), DateTimeStyles.None, out DateTime t)
                             ? (T)(object)t.Add(DateTime.Now.TimeOfDay)
                             : throw new Exception("lỗi, không đúng định dạng (phải là dd/MM/yyyy hoặc dd-MM-yyyy)"),
                    _ => throw new Exception("Unknown TypeCode")
                };
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}, Please Enter Again!");
                flag = false;
            }
        }
        return i;
    }
}
