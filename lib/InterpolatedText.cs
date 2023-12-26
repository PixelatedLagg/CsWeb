using System.Runtime.CompilerServices;
using System.Text;

namespace CsWeb
{

    [InterpolatedStringHandler]
    public ref struct InterpolatedText
    {
        private readonly StringBuilder message;
        private int count = 0;

        public InterpolatedText(int literalLength, int formattedCount)
        {
            message = new StringBuilder(literalLength);
        }

        public void AppendLiteral(string s)
        {
            message.Append(s);
        }

        public void AppendFormatted<T>(T t)
        {
            count++;
            message.Append(t);
        }
        
        public void AppendFormatted(Type t)
        {
            count++;
            message.Append(t);
        }

        public string BuildMessage() =>
            message.ToString();
    }
}