using RainState.Forms;
using RainState.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RainState.TagControls
{
    public class TagWatchController : Panel, ITagControl
    {
        public string WatchQuery
        {
            get => watchQuery;
            set
            {
                watchQuery = value; TagWatcher = new(value)
                {
                    WatchChildren = true,
                    OnTagChanged = OnTagChanged
                };
            }
        }
        [Browsable(false)]
        public TagWatch TagWatcher { get; private set; } = null!;

        [Browsable(false)]
        public RecursiveTagWatchArrays? WatchArrays { get; private set; }
        [Browsable(false)]
        public TagWatchController? Controller { get; set; }

        public bool MainController { get; set; }

        List<TagWatch> WaitingWatchers = new();
        private string watchQuery = "";

        public void BindArray(RecursiveTagWatchArrays parentArray)
        {
            parentArray.Register(TagWatcher);
            WatchArrays = new(parentArray.ParentLevel + TagWatcher.WatchQuery.Length);

            foreach (TagWatch watch in WaitingWatchers)
                if (watch.ParentArray is null)
                    WatchArrays.Register(watch);
            WaitingWatchers.Clear();
        }

        public void AddWatcher(TagWatch watch)
        {
            if (watch.ParentArray is not null)
                return;

            if (WatchArrays is not null)
            {
                WatchArrays.Register(watch);
                return;
            }
            WaitingWatchers.Add(watch);
        }
        public void RefreshTag(Tag? parent) { }

        public Tag? GetTag()
        {
            if (MainController)
                return MainForm.Instance.CurrentFile?.MainTag;

            return Controller?.GetTag()?.QueryTag(watchQuery, false);
        }

        void OnTagChanged(Tag tag)
        {
            WatchArrays?.TagChanged(tag);
        }

        public static void InitializeControllers(Control container, TagWatchController? currentController = null)
        {
            if (currentController is null)
            {
                Control cc = container;
                while (cc is not TagWatchController controller)
                    cc = cc.Parent ?? throw new InvalidOperationException("Cannot find parent controller");
                currentController = cc as TagWatchController ?? throw new Exception("Unreachable spot hit");
            }

            if (container is ITagControl tagcontrol)
            {
                TagWatch watch = tagcontrol.TagWatcher;
                if (watch.ParentArray is null)
                {
                    tagcontrol.Controller = currentController;
                    currentController.AddWatcher(watch);
                }
            }

            if (container is TagWatchController newcontroller)
            {
                if (newcontroller.WatchArrays is null && currentController.WatchArrays is not null)
                    newcontroller.BindArray(currentController.WatchArrays);
                currentController = newcontroller;
            }

            foreach (Control control in container.Controls)
                InitializeControllers(control, currentController);
        }

    }
}
