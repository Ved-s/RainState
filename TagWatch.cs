using RainState.TagControls;
using RainState.Tags;
using System;
using System.Windows.Forms;

namespace RainState
{
    public class TagWatch
    {
        public Action<Tag>? OnTagChanged;
        public bool Enabled = true;
        public bool WatchChildren = true;

        public ParsedTagQuery WatchQuery { get; set; }
        public RecursiveTagWatchArrays? ParentArray { get; set; }

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

    public interface ITagControl
    {
        public TagWatch TagWatcher { get; }
        public TagWatchController? Controller { get; set; }

        public void RefreshTag(Tag? parent);

        public static void RefreshControls(Tag? parent, Control container, bool skipThis = false)
        {
            if (!skipThis && container is TagWatchController controller)
                RefreshControls(parent?.QueryTag(controller.WatchQuery, false), controller, true);

            else if (!skipThis && container is ITagControl tagcontrol)
                tagcontrol.RefreshTag(parent);

            else
                foreach (Control child in container.Controls)
                    RefreshControls(parent, child);
        }
    }
}
