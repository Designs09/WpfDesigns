﻿
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GWWorkItem.Wpf
{
    /// <summary>
    /// A base class to run any animation method when a boolean is set to true
    /// and a reverse animation when set to false
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        #region Public Properties

        /// <summary>
        /// True if this is the very first time the value has been updated
        /// Used to make sure we run the logic at least once during first load
        /// </summary>
        protected Dictionary<DependencyObject, bool> mAlreadyLoaded = new Dictionary<DependencyObject, bool>();

        /// <summary>
        /// The most recent value used if we get a value changed before we do the first load
        /// </summary>
        protected Dictionary<DependencyObject, bool> mFirstLoadValue = new Dictionary<DependencyObject, bool>();

        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            // Get the framework element
            if (!(sender is FrameworkElement element))
                return;

            // Don't fire if the value doesn't change
            if ((bool)sender.GetValue(ValueProperty) == (bool)value && mAlreadyLoaded.ContainsKey(sender))
                return;

            // On first load...
            if (!mAlreadyLoaded.ContainsKey(sender))
            {
                // Flag that we are in first load but have not finished it
                mAlreadyLoaded[sender] = false;

                // Start off the hidden before we decide how to animate
                element.Visibility = Visibility.Hidden;

                // Create a single self-unhookable event
                // for the elements Loaded event
                RoutedEventHandler onLoaded = null;
                onLoaded = async (ss, ee) =>
                {
                    // Unhook ourselves
                    element.Loaded -= onLoaded;

                    // Slight delay after load is needed for some elements to get laid out
                    // and their width/heights correctly calculated
                    await Task.Delay(5);

                    // Do desired animation
                    DoAnimation(element, mFirstLoadValue.ContainsKey(sender) ? mFirstLoadValue[sender] : (bool)value, true);

                    // Flat that we have finished first load
                    mAlreadyLoaded[sender] = true;
                };

                // Hook into the loaded event of the element
                element.Loaded += onLoaded;
            }
            // If we have started a first load but not fired the animation yet, update the property
            else if (mAlreadyLoaded[sender] == false)
                mFirstLoadValue[sender] = (bool)value;
            else
                // Do desired animation
                DoAnimation(element, (bool)value, false);
        }

        /// <summary>
        /// The animation method that is fired when the value changes
        /// </summary>
        /// <param name="element">The elemetn</param>
        /// <param name="value">The new value</param>
        protected virtual void DoAnimation(FrameworkElement element, bool value, bool firstLoad) { }
    }

    /// <summary>
    /// Fade in an image once the source changes
    /// </summary>
    public class FadeInImageOnLoadProperty : AnimateBaseProperty<FadeInImageOnLoadProperty>
    {
        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            // Make sure we have a image
            if (!(sender is Image image))
                return;

            // If we want to animate in...
            if ((bool)value)
                image.TargetUpdated += Image_TargetUpdated;
            else
                image.TargetUpdated -= Image_TargetUpdated;
        }

        private async void Image_TargetUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            await (sender as Image).FadeInAsync(false);
        }
    }

    /// <summary>
    /// Animates a framework element sliding it in from the left on show
    /// and sliding out to the left on hide
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                // Animate in
                await element.SlideAndFadeInAsync(AnimationSlideInDirection.Left, firstLoad, firstLoad ? 0 : 0.3f, false);
            }
            else
                // Animate out
                await element.SlideAndFadeOutAsync(AnimationSlideInDirection.Left, firstLoad ? 0 : 0.3f, false);
        }
    }

    /// <summary>
    /// Animates a framework element sliding it in from the right on show
    /// and sliding out to the right on hide
    /// </summary>
    public class AnimateSlideInFromRightProperty : AnimateBaseProperty<AnimateSlideInFromRightProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                // Animate in
                await element.SlideAndFadeInAsync(AnimationSlideInDirection.Right, firstLoad, firstLoad ? 0 : 0.3f, false);
            }
            else
                // Animate out
                await element.SlideAndFadeOutAsync(AnimationSlideInDirection.Right, firstLoad ? 0 : 0.3f, false);
        }
    }

    /// <summary>
    /// Animates a framework element sliding it in from the right on show
    /// and sliding out to the right on hide
    /// </summary>
    public class AnimateSlideInFromRightMarginProperty : AnimateBaseProperty<AnimateSlideInFromRightMarginProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                // Animate in
                await element.SlideAndFadeInAsync(AnimationSlideInDirection.Right, firstLoad, firstLoad ? 0 : 0.3f, keepMargin: true);
            }
            else
                // Animate out
                await element.SlideAndFadeOutAsync(AnimationSlideInDirection.Right, firstLoad ? 0 : 0.3f, keepMargin: true);
        }
    }

    /// <summary>
    /// Animates a framework element sliding up from the bottom on show
    /// and sliding out to the bottom on hide
    /// </summary>
    public class AnimateSlideInFromBottomProperty : AnimateBaseProperty<AnimateSlideInFromBottomProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                // Animate in
                await element.SlideAndFadeInAsync(AnimationSlideInDirection.Bottom, firstLoad, firstLoad ? 0 : 0.3f, false);
            }
            else
                // Animate out
                await element.SlideAndFadeOutAsync(AnimationSlideInDirection.Bottom, firstLoad ? 0 : 0.3f, false);
        }
    }

    /// <summary>
    /// Animates a framework element sliding up from the bottom on load
    /// if the value is true
    /// </summary>
    public class AnimateSlideInFromBottomOnLoadProperty : AnimateBaseProperty<AnimateSlideInFromBottomOnLoadProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            // Animate in
            await element.SlideAndFadeInAsync(AnimationSlideInDirection.Bottom, !value, !value ? 0 : 0.3f, false);
        }
    }

    /// <summary>
    /// Animates a framework element sliding up from the bottom on show
    /// and sliding out to the bottom on hide
    /// NOTE: Keeps the margin
    /// </summary>
    public class AnimateSlideInFromBottomMarginProperty : AnimateBaseProperty<AnimateSlideInFromBottomMarginProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                // Animate in
                await element.SlideAndFadeInAsync(AnimationSlideInDirection.Bottom, firstLoad, firstLoad ? 0 : 0.3f, true);
            }
            else
                // Animate out
                await element.SlideAndFadeOutAsync(AnimationSlideInDirection.Bottom, firstLoad ? 0 : 0.3f, true);
        }
    }

    /// <summary>
    /// Animates a framework element sliding up from the top on show
    /// and sliding out to the top on hide
    /// </summary>
    public class AnimateSlideInFromTopProperty : AnimateBaseProperty<AnimateSlideInFromBottomProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                // Animate in
                await element.SlideAndFadeInAsync(AnimationSlideInDirection.Top, firstLoad, firstLoad ? 0 : 0.3f, false);
            }
            else
                // Animate out
                await element.SlideAndFadeOutAsync(AnimationSlideInDirection.Top, firstLoad ? 0 : 0.3f, false);
        }
    }

    /// <summary>
    /// Animates a framework element sliding up from the top on show
    /// and sliding out to the top on hide
    /// NOTE: Keeps the margin
    /// </summary>
    public class AnimateSlideInFromTopMarginProperty : AnimateBaseProperty<AnimateSlideInFromBottomProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                // Animate in
                await element.SlideAndFadeInAsync(AnimationSlideInDirection.Top, firstLoad, firstLoad ? 0 : 0.3f, true);
            }
            else
                // Animate out
                await element.SlideAndFadeOutAsync(AnimationSlideInDirection.Top, firstLoad ? 0 : 0.3f, true);
        }
    }

    /// <summary>
    /// Animates a framework element fadding in on show
    /// and fading out on hide
    /// </summary>
    public class AnimateFadeInProperty : AnimateBaseProperty<AnimateFadeInProperty>
    {
        protected async override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
                // Animate in
                await element.FadeInAsync(firstLoad, firstLoad ? 0 : 0.3f);
            else
                // Animate out
                await element.FadeOutAsync(firstLoad ? 0 : 0.3f);
        }
    }
}