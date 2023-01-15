using RainState.Tags;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainState
{
    public class TagWatch
    {
        public Action<Tag>? OnTagChanged;
        public bool Enabled = true;
        public bool WatchChildren = true;

        public ParsedTagQuery WatchQuery { get; set; }

        public TagWatch(string watchQuery)
        {
            WatchQuery = new(watchQuery);
        }

        public void TagChanged(Tag tag)
        {
            if (!Enabled || !tag.MatchQuery(WatchQuery.Elements, WatchChildren))
                return;
            
            OnTagChanged?.Invoke(tag);
        }
    }
}
