

using OOP;

//Student stu1 = new Student(1,"Hieu",true, new DateTime(2004,09,13));

//Student stu2 = new(1, "Hieu", true, new DateTime(2004, 09, 13));

//object initializer => class không cần tạo constructor làm gì
Student stu3 = new()
{
    Id = 3,
    Gender = false,
    //Fullname = "Anh",
    //Dob = DateTime.Now
    test = DateOnly.FromDateTime(DateTime.Now) //ép kiểu về để lấy hiện tại
};

Console.WriteLine(stu3);
