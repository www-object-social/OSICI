namespace OSICI.Product;
/// <summary>
/// Register the infomation in this Product
/// </summary>
public class Infomation
{
    public readonly Name Name;
    public readonly Type Type;
    internal Infomation(Name Name, Type Type)
    {
        this.Name = Name;
        this.Type = Type;
    }
}