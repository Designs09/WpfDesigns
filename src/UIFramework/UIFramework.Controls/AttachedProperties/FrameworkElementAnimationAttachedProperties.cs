using System.Windows;
using System.Windows.Controls;

namespace UIFramework.Controls
{
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
