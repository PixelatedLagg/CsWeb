using System.Runtime.CompilerServices;
using System.Text;

namespace CsWeb
{
    [InterpolatedStringHandler]
    public ref struct InterpolatedText(int literalLength)
    {
        public List<object> Variables = [];
        public List<Component> Components = [];
        public List<string> Static = [];
        public List<ushort> Positions = [];
        public int Length = literalLength;

        public readonly void AppendFormatted<T>(T t)
        {
            Variables.Add(t ?? new object());
            Positions.Add(0);
        }
        
        public readonly void AppendFormatted(Component e)
        {
            Components.Add(e);
            Positions.Add(1);
        }

        public readonly void AppendLiteral(string s)
        {
            Static.Add(s);
            Positions.Add(2);
        }

        public readonly string BuildMessage()
        {
            StringBuilder builder = new(Length);
            int[] indexes = [0, 0, 0];
            foreach (ushort position in Positions)
            {
                switch (position)
                {
                    case 0:
                        builder.Append(Variables[indexes[0]]);
                        indexes[0] = indexes[0] + 1;
                        break;
                    case 1:
                        builder.Append(Components[indexes[1]]);
                        indexes[1] = indexes[1] + 1;
                        break;
                    default:
                        builder.Append(Static[indexes[2]]);
                        indexes[2] = indexes[2] + 1;
                        break;
                }
            }
            return builder.ToString();
        }
    }
}