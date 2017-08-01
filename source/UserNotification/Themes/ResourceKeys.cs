namespace UserNotification.Themes
{
    using System.Windows;

    /// <summary>
    /// Resource key management class to keep track of all resources
    /// that can be re-styled in applications that make use of the implemented controls.
    /// </summary>
    public static class ResourceKeys
    {
        #region Accent Keys
        /// <summary>
        /// Accent Color Key - This Color key is used to accent elements in the UI
        /// (e.g.: Color of Activated Normal Window Frame, ResizeGrip, Focus or MouseOver input elements)
        /// </summary>
        public static readonly ComponentResourceKey ControlAccentColorKey = new ComponentResourceKey(typeof(ResourceKeys), "ControlAccentColorKey");

        /// <summary>
        /// Accent Brush Key - This Brush key is used to accent elements in the UI
        /// (e.g.: Color of Activated Normal Window Frame, ResizeGrip, Focus or MouseOver input elements)
        /// </summary>
        public static readonly ComponentResourceKey ControlAccentBrushKey = new ComponentResourceKey(typeof(ResourceKeys), "ControlAccentBrushKey");
        #endregion Accent Keys

        #region Brush Keys
        /// <summary>
        /// Resource key of the controls normal background brush key.
        /// </summary>
        public static readonly ComponentResourceKey ControlNormalBackgroundKey = new ComponentResourceKey(typeof(ResourceKeys), "ControlNormalBackgroundKey");
        #endregion Brush Keys

        /// <summary>
        /// Background brush key of the NotificationWindow.
        /// </summary>
        public static readonly ComponentResourceKey NotificationWindowBackground = new ComponentResourceKey(typeof(ResourceKeys), "NotificationWindowBackground");

        /// <summary>
        /// Border brush key of the border of the NotificationWindow.
        /// </summary>
        public static readonly ComponentResourceKey NotificationWindowBorder = new ComponentResourceKey(typeof(ResourceKeys), "NotificationWindowBorder");

        /// <summary>
        /// Foreground brush key the border of the NotificationWindow.
        /// </summary>
        public static readonly ComponentResourceKey NotificationWindowForeground = new ComponentResourceKey(typeof(ResourceKeys), "NotificationWindowForeground");

        // Close Button Brushes

        /// <summary>
        /// Border brush key of the focused border (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey DefaultedBorderBrush = new ComponentResourceKey(typeof(ResourceKeys), "DefaultedBorderBrush");

        /// <summary>
        /// Border brush key of the disabled border (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey DisabledForegroundBrush = new ComponentResourceKey(typeof(ResourceKeys), "DisabledForegroundBrush");

        /// <summary>
        /// Background brush key of the disabled control (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey DisabledBackgroundBrush = new ComponentResourceKey(typeof(ResourceKeys), "DisabledBackgroundBrush");

        /// <summary>
        /// Broder brush key of the disabled control (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey DisabledBorderBrush = new ComponentResourceKey(typeof(ResourceKeys), "DisabledBorderBrush");

        /// <summary>
        /// Border brush key of the border (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey NormalBorderBrush = new ComponentResourceKey(typeof(ResourceKeys), "NormalBorderBrush");

        /// <summary>
        /// Normal background brush key (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey CloseNormal = new ComponentResourceKey(typeof(ResourceKeys), "CloseNormal");

        /// <summary>
        /// Mouse over border brush key (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey CloseOver = new ComponentResourceKey(typeof(ResourceKeys), "CloseOver");

        /// <summary>
        /// Button pressed background brush key (of the close button)
        /// </summary>
        public static readonly ComponentResourceKey ClosePressed = new ComponentResourceKey(typeof(ResourceKeys), "ClosePressed");

        /// <summary>
        /// Image resource key of the close button.
        /// </summary>
        public static readonly ComponentResourceKey Image_Close_Button = new ComponentResourceKey(typeof(ResourceKeys), "Image_Close_Button");
    }
}
