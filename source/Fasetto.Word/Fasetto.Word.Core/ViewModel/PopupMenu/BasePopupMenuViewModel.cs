
namespace Fasetto.Word.Core
{ 
    /// <summary>
    /// A view model for any popup menus
    /// </summary>
    public class BasePopupMenuViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The background color of the bubble
        /// </summary>
        public string BubbleBackground { get; set; }

        /// <summary>
        /// The alighment of the bubble arrow
        /// </summary>
        public ElementHorizontalAlignment ArrowAlighment { get; set; }

        #endregion

        #region Constructor

        public BasePopupMenuViewModel()
        {
            // Set default values
            // Move colors into Core and make use of it here
            BubbleBackground = "ffffff";
            ArrowAlighment = ElementHorizontalAlignment.Left;
        }

        #endregion
    }
}
