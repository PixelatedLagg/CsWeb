namespace CsWeb;

public class ElementAttribute(string name, string value)
{
    public string Name = name;
    public string Value = value;

    public static implicit operator ElementAttribute((string name, string value) data)
    {
        return new ElementAttribute(data.name, data.value);
    }
}