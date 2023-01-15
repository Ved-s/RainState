using RainState.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RainState
{
    //public class TagValueTextBox : TextBox
    //{
    //    protected override void OnInitialized(EventArgs e)
    //    {
    //        base.OnInitialized(e);
    //    
    //        if (Program.MainTag is not null)
    //            Text = Program.MainTag
    //                .GetTag<KeyValueTag>("progDiv", "SAVE STATE")
    //                .GetValue<ListTag>()
    //                .GetTag<KeyValueTag>("sv", "FOOD")
    //                .GetValue<ValueTag>()
    //                .Value;
    //    }
    //    
    //    protected override void OnTextChanged(TextChangedEventArgs e)
    //    {
    //        base.OnTextChanged(e);
    //        if (Program.MainTag is not null)
    //            Program.MainTag
    //                .GetTag<KeyValueTag>("progDiv", "SAVE STATE")
    //                .GetValue<ListTag>()
    //                .GetTag<KeyValueTag>("sv", "FOOD")
    //                .GetValue<ValueTag>()
    //                .Value = Text;
    //    }
    //}
}
