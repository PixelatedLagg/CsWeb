namespace CsWeb
{
    public enum Elements
    {
        p,
        img,
        h1,
        h2,
        h3
    }

    public static class ElementExtensions
    {
        public static Element Margin(this Elements elements)
        {
            return new Element();
        }
    }
}