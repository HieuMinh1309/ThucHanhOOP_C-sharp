
using System.Threading.Channels;

namespace AccessModify;
public class Plant
{
    void Private() => Console.WriteLine("Private");
    protected void Protected() => Console.WriteLine("Protected");
    internal void Internal() => Console.WriteLine("Internal");
    private protected void PrivateProtected() => Console.WriteLine("PrivateProtected");
    protected internal void ProtectedInternal() => Console.WriteLine("Protected Internal");
    public void Public() => Console.WriteLine("Public");
}
