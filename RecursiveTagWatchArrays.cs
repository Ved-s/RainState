using RainState.Tags;
using System.Collections.Generic;

namespace RainState
{
    public class RecursiveTagWatchArrays
    {
        Dictionary<string, RecursiveTagWatchArrays> NextArrays = new();
        List<TagWatch> Watchers = new();

        public int ParentLevel { get; }

        public RecursiveTagWatchArrays(int parentLevel)
        {
            ParentLevel = parentLevel;
        }

        public void Register(TagWatch watcher)
        {
            RecursiveTagWatchArrays target = this;

            for (int i = ParentLevel; i < watcher.WatchQuery.Length; i++)
            {
                string name = watcher.WatchQuery.Elements[i].Name;
                if (!target.NextArrays.TryGetValue(name, out RecursiveTagWatchArrays? arrays))
                {
                    arrays = new(ParentLevel + 1);
                    target.NextArrays[name] = arrays;
                }
                target = arrays;
            }

            target.Watchers.Add(watcher);
            watcher.ParentArray = target;
        }

        public void TagChanged(Tag tag)
        {
            foreach (TagWatch watcher in Watchers)
                watcher.TagChanged(tag);

            Tag t = tag.GetParent(ParentLevel + 1);

            if (t.Name == "")
                foreach (RecursiveTagWatchArrays array in NextArrays.Values)
                    array.TagChanged(tag);
            else if (NextArrays.TryGetValue(t.Name, out RecursiveTagWatchArrays? arrays))
                arrays.TagChanged(tag);
        }
    }
}
