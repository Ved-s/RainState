using RainState.Tags;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RainState
{
    public ref struct TagQueryPathEnumerator
    {
        static char[] QueryTagTypes = new[] { '@', '$', '#' };

        ReadOnlySpan<char> NextPath;
        string CurrentId = "";
        string CurrentName = "";
        TagType CurrentType = TagType.Value;
        string? LastTagId = null;

        public int Remaining 
        {
            get 
            {
                if (NextPath.IsEmpty)
                    return 0;

                int count = 1;
                for (int i = 0; i < NextPath.Length; i++)
                    if (NextPath[i] == '/')
                        count++;
                return count;
            }
        }
        public TagQueryElement Current => new(CurrentId, CurrentName, CurrentType);

        public TagQueryPathEnumerator(string query)
        {
            NextPath = query;
        }

        public bool MoveNext()
        {
            if (NextPath.IsEmpty)
                return false;

            ReadOnlySpan<char> current;

            int pathSep = NextPath.IndexOf('/');
            if (pathSep < 0)
            {
                current = NextPath;
                NextPath = ReadOnlySpan<char>.Empty;
            }
            else
            {
                current = NextPath.Slice(0, pathSep);
                NextPath = NextPath.Slice(pathSep + 1);
            }

            int typeIdx = current.IndexOfAny(QueryTagTypes);

            if (typeIdx < 0)
                throw new InvalidDataException("Query missing tag type");

            CurrentId = typeIdx > 0 ? new(current.Slice(0, typeIdx))
                : LastTagId ?? throw new InvalidDataException("Cannot implicitly define tag id in query");
            CurrentName = new(current.Slice(typeIdx + 1));

            CurrentType = current[typeIdx] switch
            {
                '@' => TagType.Pair,
                '$' => TagType.List,
                '#' => TagType.Value,
                _ => throw new InvalidDataException($"Invalid tag type in query: {current[typeIdx]}")
            };

            LastTagId = CurrentId;

            return true;
        }
        public TagQueryPathEnumerator GetEnumerator() => this;
    }
}
