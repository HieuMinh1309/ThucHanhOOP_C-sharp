using ListAndLinq;
using System.Collections;
using System.Diagnostics;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

#region ArrayList
//ArrayList arr = new();
//arr.Add("Hiếu");
//arr.Add(5);
//arr.Add(true);

//ArrayList arr2 = ["Thịnh", 35, true];

//for (int i = 0; i < arr.Count; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}
#endregion


#region List
//cách 1
List<Student> list1 = new();
list1.Add(new Student() { RollNumber = 13, Fullname = "Hiếu", Section = "dãy 1", RoomNumber = 2 });
list1.Add(new Student() { RollNumber = 14, Fullname = "Nguyên", Section = "dãy 5", RoomNumber = 3 });

//cách 2: cách nên làm (đỡ tốn bộ nhớ)
List<Student> list2 = [
    new Student() { RollNumber = 14, Fullname = "hehe", Section = "dãy 2", RoomNumber = 1 },
    new Student() { RollNumber = 17, Fullname = "hoho", Section = "dãy 3", RoomNumber = 22 }
];

//////đo tốc độ
////Stopwatch sw = new();
//////khởi động bằng cách restart lại
////sw.Restart();
////foreach (var item in list1)
////{
////    Console.WriteLine(item);
////}
////sw.Stop();
////Console.WriteLine($"foreach run: {sw.ElapsedMilliseconds}");
////Console.WriteLine("==================================");
//////tốc độ của IEnumerator (chạy thuật toán thường xài thằng này do nó chạy rất nhanh)
////sw.Restart();
////IEnumerator enu = list1.GetEnumerator();
////while (enu.MoveNext())
////{
////    Console.WriteLine(enu.Current.ToString());
////}
////sw.Stop();
////Console.WriteLine($"iemunerator run: {sw.ElapsedMilliseconds}");

////duyệt qua list chỉ lấy roomnumber lớn hơn 2
//foreach (var stu in list2)
//{
//    if (stu.RoomNumber > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}
#endregion

#region Linq

    #region Query Syntax
////linq có 2 style viết
////a) query syntax => dùng cú pháp sql theo cấu trúc:
////from [biến/đối tượng] bất kỳ in list
////where condition là gì đó (biến > hay < gì đó)
////group by gom nhóm
////having xét điều kiện cho group by
////order by sắp xếp
////cuối cùng mới select

//var listStu = from stu in list1
//              where stu.RoomNumber > 2
//              select stu;
//Console.WriteLine(listStu.Count());

//foreach (var stu in listStu)
//{
//    Console.WriteLine(stu);
//}

////rút gọn
////linq khuyến khích xài 1 ký tự
//foreach (var t in from u in list1
//                  where u.RoomNumber > 2
//                  select u)
//{
//    Console.WriteLine(t);
//}
#endregion

    #region Method Syntax(lambda)
////b) mothod syntax (sử dụng lambda)
////tốc độ rất nhanh
//var x = list1.Where(u => u.RollNumber > 2);
//foreach (var i in x)
//{
//    Console.WriteLine(i);
//}

////rút gọn
//foreach (var i in list1.Where(u => u.RollNumber > 2))
//{
//    Console.WriteLine(i);
//}

////bản thân collection có luôn foreach
//list1.ForEach(Console.WriteLine);
//list1.ForEach(stu => Console.WriteLine(stu.Fullname));
//list1.ForEach(stu =>
//{
//    if (stu.RoomNumber > 2)
//    {
//        Console.WriteLine(stu);
//    }
//});


//list1.Where(u => u.RollNumber > 2).ToList().ForEach(Console.WriteLine);
#endregion

#endregion
