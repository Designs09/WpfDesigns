using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UIFramework.Controls
{
    /// <summary>
    /// Creates a clipping region from the parent <see cref="Border"/> <see cref="CornerRadius"/>
    /// </summary>
    public class ClipFromBorderProperty : BaseAttachedProperty<ClipFromBorderProperty, bool>
    {
        /// <summary>
        /// Called when the parent border first loads
        /// </summary>
        private RoutedEventHandler mBorder_Loaded;

        /// <summary>
        /// Called when the border size changes
        /// </summary>
        private SizeChangedEventHandler mBorder_SizeChanged;

        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get self
            var self = sender as FrameworkElement;

            // Check we have a parent Border
            if (!(self.Parent is Border border))
            {
                Debugger.Break();
                return;
            }

            // Setup loaded event
            mBorder_Loaded += (s1, e1) => Border_OnChanged(s1, e1, self);

            // Setup loaded event
            mBorder_SizeChanged += (s1, e1) => Border_OnChanged(s1, e1, self);

            // If true, hook into events
            if ((bool)e.NewValue)
            {
                border.Loaded += mBorder_Loaded;
                border.SizeChanged += mBorder_SizeChanged;
            }
            else
            // Otherwise, unhook
            {
                border.Loaded -= mBorder_Loaded;
                border.SizeChanged -= mBorder_SizeChanged;
            }
        }

        /// <summary>
        /// Called when the border is loaded and changed size
        /// </summary>
        /// <param name="sender">The border</param>
        /// <param name="e"></param>
        /// <param name="self">
        /// The child element (our selves)
        /// guaranty the self is passed
        /// </param>
        private void Border_OnChanged(object sender, RoutedEventArgs e, FrameworkElement child)
        {
            // Get border
            var border = (Border)sender;

            // Check we have a actual size
            if (border.ActualWidth == 0 && border.ActualHeight == 0)
                return;

            // Setup the new child clipping area
            var rect = new RectangleGeometry();

            // Match the corner radius with the borders corner radius
            rect.RadiusX = rect.RadiusY = Math.Max(0, border.CornerRadius.TopLeft - (border.BorderThickness.Left * 0.5));

            // Set ractangle size to match child's actual size
            rect.Rect = new Rect(child.RenderSize);

            // Assign clipping area to the child
            child.Clip = rect;
        }
    }
}
