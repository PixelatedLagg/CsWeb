using CsWeb.Internal;

namespace CsWeb
{
    public class Component
    {
        delegate void E();
        E P;

        protected void C<D>() where D : Delegate
        {

        }
    }
}