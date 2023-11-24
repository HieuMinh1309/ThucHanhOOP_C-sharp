
namespace OOP;
internal class Student
{
    //các field
    int? id;
    string? fullname;
    bool gender;
    DateOnly dob;

    //constructor
    public Student(int? id, string? fullname, bool gender, DateOnly dob)
    {
        this.id = id;
        this.fullname = fullname;
        this.gender = gender;
        this.dob = dob;
    }

    public Student() { }


}
