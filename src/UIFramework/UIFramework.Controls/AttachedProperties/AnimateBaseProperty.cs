using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIFramework.Controls
{
    /// <summary>
    /// A base class to run any animation method when a boolean is set to true
    /// and a reverse animation when set to false
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : AnimateBaseProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {

    }

    /// <summary>
    /// A base class to run any animation method when a boolean is set to true
    /// and a reverse animation when set to false
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent, Value> : BaseAttachedProperty<Parent, Value>
        where Parent : BaseAttachedProperty<Parent, Value>, new()
        where Value : struct
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
        protected Dictionary<DependencyObject, Value> mFirstLoadValue = new Dictionary<DependencyObject, Value>();

        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            // Get the framework element
            if (!(sender is FrameworkElement element))
                return;

            // Don't fire if the value doesn't change
            if ((double)sender.GetValue(ValueProperty) == (double)value && mAlreadyLoaded.ContainsKey(sender))
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
                    DoAnimation(element, mFirstLoadValue.ContainsKey(sender) ? mFirstLoadValue[sender] : (Value)value, true);

                    // Flat that we have finished first load
                    mAlreadyLoaded[sender] = true;
                };

                // Hook into the loaded event of the element
                element.Loaded += onLoaded;
            }
            // If we have started a first load but not fired the animation yet, update the property
            else if (mAlreadyLoaded[sender] == false)
                mFirstLoadValue[sender] = (Value)value;
            else
                // Do desired animation
                DoAnimation(element, (Value)value, false);
        }

        /// <summary>
        /// The animation method that is fired when the value changes
        /// </summary>
        /// <param name="element">The elemetn</param>
        /// <param name="value">The new value</param>
        protected virtual void DoAnimation(FrameworkElement element, Value value, bool firstLoad) { }
    }

}
