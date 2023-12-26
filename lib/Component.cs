namespace CsWeb
{
    public abstract class Component
    {
        protected Type test = typeof(Component);

        public Component(params object[] properties) { }

        public abstract InterpolatedText Render();
    }
}