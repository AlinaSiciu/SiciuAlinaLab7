using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls; // Required for Behavior<T> and Editor
using Microsoft.Maui.Graphics;

namespace SiciuAlinaLab7
{
    public class ValidationBehavior : Behavior<Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            ((Editor)sender).BackgroundColor =
            string.IsNullOrEmpty(args.NewTextValue) ? Color.FromArgb("#AA4A44") :
            Color.FromRgba("#FFFFFF");
        }
    }
}
