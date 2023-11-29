
namespace AbstractClass;
internal abstract class Human
{
    public string? FullName { get; set; }
    public int? Age { get; set; }

    public abstract void ShowInfo();
    public override string ToString()
    {
        return $"{{{nameof(FullName)}={FullName}, {nameof(Age)}={Age.ToString()}}}";
    }
}
