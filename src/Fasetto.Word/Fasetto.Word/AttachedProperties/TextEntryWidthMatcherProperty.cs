﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    ///  Match the label width of all text entry controls inside this panel
    /// </summary>
    public class TextEntryWidthMatcherProperty : BaseAttachedProperty<TextEntryWidthMatcherProperty, string>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the panel (grid typically)
            var panel = sender as Panel;

            // Call SetWidths initially (this also helps design time to work)
            SetWidth(panel);

            // Wait for panel to load
            RoutedEventHandler onLoaded = null;

            onLoaded = (s, ee) =>
            {
                // Unhook
                panel.Loaded -= onLoaded;

                // Set widths
                SetWidth(panel);

                // Loop each child
                foreach (var child in panel.Children)
                {
                    // Ignore any non-text entry controls
                    if (!(child is TextEntryControl) && !(child is PasswordEntryControl))
                        continue;

                    var label = child is TextEntryControl ? (child as TextEntryControl).Label : (child as PasswordEntryControl).Label;

                    // Set it's margin to the given value
                    label.SizeChanged += (ss, eee) =>
                    {
                        // Update widths
                        SetWidth(panel);
                    };
                }
            };

            // Hook into the Loaded event
            panel.Loaded += onLoaded;
        }

        /// <summary>
        /// Update all child text entry controls so their widths match the largest width of the group
        /// </summary>
        /// <param name="panel">The panel containing the text entry controls</param>
        private void SetWidth(Panel panel)
        {
            // Keep track of the maximum width
            var maxSize = 0d;

            // For each child...
            foreach (var child in panel.Children)
            {
                // Ignore any non-text entry controls
                if (!(child is TextEntryControl) && !(child is PasswordEntryControl))
                    continue;

                var label = child is TextEntryControl ? (child as TextEntryControl).Label : (child as PasswordEntryControl).Label;

                // Find if this value is larger than the other controls
                maxSize = Math.Max(maxSize, label.RenderSize.Width + label.Margin.Left + label.Margin.Right);
            }

            // Create a grid length
            var gridLength = (GridLength)new GridLengthConverter().ConvertFromString(maxSize.ToString());

            // For each child...
            foreach (var child in panel.Children)
            {
                // Ignore any non-text entry controls
                if (child is TextEntryControl text)
                    // Set each controls LabelWidth value to the max size
                    text.LabelWidth = gridLength;
                else if (child is PasswordEntryControl pass)
                    // Set each controls LabelWidth value to the max size
                    pass.LabelWidth = gridLength;
            }
        }
    }
}
