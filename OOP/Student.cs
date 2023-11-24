
namespace OOP;
internal class Student
{
    #region code ban dau
    ////các field
    //int? id;
    //string? fullname;
    ////tự các field sẻ thành luôn property
    ////muốn cho bản thân class xài được cái auto property với tư cách là field thì vẫn để set nhưng thêm private
    //public bool? Gender { get; private set; } //=>auto property bắt buộc phải là public
    //public DateOnly? Dob { get; set; } //=>auto property



    ////constructor
    //public Student(int? id, string? fullname, bool gender, DateOnly dob)
    //{
    //    this.Id = id;
    //    this.fullname = fullname;
    //    this.Gender = gender;
    //    this.Dob = dob;
    //}

    //public Student() { }

    //public void Hi()
    //{
    //    id = 1;
    //    Console.WriteLine(id);
    //    Gender = false;
    //    Console.WriteLine(Gender);
    //}

    ////property
    ////khác với java, C# có cách viết riêng không dùng các phương thức getter và setter
    //public int? Id { get => id; set => id = value; }
    //public string? Fullname { get => fullname; set => fullname = value; }

    //public override string? ToString()
    //{
    //    return base.ToString();
    //}
    #endregion

    public int? Id { get; set; }
    public string? Fullname { get; set; }
    public bool? Gender { get; set; }
    public DateOnly? dob { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Fullname)}={Fullname}, {nameof(Gender)}={Gender.ToString()}, {nameof(dob)}={dob.ToString()}}}";
    }
}
