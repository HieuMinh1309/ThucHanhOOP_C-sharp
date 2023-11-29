
using AbstractClass;

//abstract không cho khởi tạo đối tượng khác với java
//Human human = new(); 
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
//object initializer => giảm thiểu constructor
Teacher teacher = new()
{
    FullName = "Hieu",
    Age = 19
};
teacher.ShowInfo();
Console.WriteLine(teacher);