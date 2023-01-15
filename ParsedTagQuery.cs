using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainState
{
    public class ParsedTagQuery : IEnumerable<TagQueryElement>
    {
        public TagQueryElement[] Elements;

        public int Length => Elements.Length;

        public ParsedTagQuery(string query)
        {
            int index = 0;
            TagQueryPathEnumerator enumerator = new(query);
            TagQueryElement[] elements = new TagQueryElement[enumerator.Remaining];

            foreach(TagQueryElement element in enumerator)
                elements[index++] = element;
            Elements = elements;
        }

        public IEnumerator<TagQueryElement> GetEnumerator()
        {
            return ((IEnumerable<TagQueryElement>)Elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Elements.GetEnumerator();
        }
    }
}
