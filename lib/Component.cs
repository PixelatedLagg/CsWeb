
namespace CsWeb
{
    public interface IComponent
    {
        ElementAttribute[] Attributes { get; set; }
        public string Render();

        public static IComponent operator +(IComponent component, ICollection<ElementAttribute> attributes)
        {
            component.Attributes = [.. attributes];
            return component;
        }
    }
}