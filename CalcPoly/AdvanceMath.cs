
namespace CalcPoly;
internal class AdvanceMath : BasicMath
{
    public override void Divide()
    {
        try
        {
            Console.WriteLine(NumberOne / NumberTwo);
        }
        catch (Exception) when (NumberTwo == 0)
        {
            Console.WriteLine("can't divide with 0");
        }
        catch(Exception e) 
        {
            Console.WriteLine(e.Message);
        }

    }
}
