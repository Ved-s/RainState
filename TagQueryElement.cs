using System.Linq;

namespace RainState
{
    public record struct TagQueryElement(string Id, string Name, TagType Type, string[]? Filters)
    {
        public override string ToString()
        {
            if (Filters is null)
                return $"{Type} {Id} {Name}";

            return $"{Type} {Id} {Name} [ {string.Join(", ", Filters)} ]";
        }
    }
}
