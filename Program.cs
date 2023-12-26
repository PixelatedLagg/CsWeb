using CsWeb;

namespace Testing
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(new MyComponent(1).Render().BuildMessage());
        }
    }
}