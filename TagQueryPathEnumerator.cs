using RainState.Tags;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        string[]? CurrentFilters = null;

        public int Remaining 
        {
            get 
            {
                if (NextPath.IsEmpty)
                    return 0;

                int count = 1;
                ReadOnlySpan<char> path = NextPath;
                while (TryGetIndexOf(path, '/', out int pathSep))
                {
                    count++;
                    path = path.Slice(pathSep + 1);
                }
                return count;
            }
        }
        public TagQueryElement Current => new(CurrentId, CurrentName, CurrentType, CurrentFilters);

        public TagQueryPathEnumerator(ReadOnlySpan<char> query)
        {
            NextPath = query;
        }

        public bool MoveNext()
        {
            if (NextPath.IsEmpty)
                return false;

            ReadOnlySpan<char> current;

            if (!TryGetIndexOf(NextPath, '/', out int pathSep))
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

            CurrentFilters = null;
            int filterStart = current.IndexOf('[');
            if (filterStart >= 0)
            {
                ReadOnlySpan<char> filters = current.Slice(filterStart + 1);
                if (!TryGetIndexOf(filters, ']', out int filterEnd))
                    throw new InvalidDataException("Query missing filter closing bracket");

                filters = filters.Slice(0, filterEnd);
                int filterCount = 1;
                ReadOnlySpan<char> nextfilters = filters;
                while (TryGetIndexOf(nextfilters, ',', out int findex))
                {
                    filterCount++;
                    nextfilters = nextfilters.Slice(findex+1);
                }

                CurrentFilters = new string[filterCount];

                int filterIndex = 0;
                nextfilters = filters;
                bool readingFilters = true;
                while (readingFilters)
                {
                    if (!TryGetIndexOf(nextfilters, ',', out int findex))
                    {
                        findex = nextfilters.Length;
                        readingFilters = false;
                    }
                    ReadOnlySpan<char> filter = nextfilters.Slice(0, findex);
                    CurrentFilters[filterIndex] = new(filter);
                    filterIndex++;
                    if (readingFilters)
                        nextfilters = nextfilters.Slice(findex + 1);
                }

            }

            int nameLength = (filterStart >= 0 ? filterStart : current.Length) - typeIdx - 1;

            CurrentId = typeIdx > 0 ? new(current.Slice(0, typeIdx))
                : LastTagId ?? throw new InvalidDataException("Cannot implicitly define tag id in query");
            CurrentName = new(current.Slice(typeIdx + 1, nameLength));

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

        bool TryGetIndexOf(ReadOnlySpan<char> chars, char chr, out int index)
        {
            int level = 0;
            index = -1;

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (chr == c && level == 0)
                {
                    index = i;
                    return true;
                }
                if (c == '[')
                    level++;
                else if (c == ']')
                {
                    if (level == 0)
                        return false;
                    level--;
                }
            }

            return false;
        }
    }
}
