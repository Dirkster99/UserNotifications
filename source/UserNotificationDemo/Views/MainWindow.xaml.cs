namespace UserNotificationDemo.Views
{
  using System.Windows;
  using UserNotification.View;
  using UserNotification.ViewModel;
  using UserNotificationDemo.ViewModels;

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// 
  /// Note: This sample illustrates an over-simplified solution for using user notifications
  /// in WPF. A window should inherite from the <seealso cref="UserNotification.View.NotifyableWindow"/>
  /// class in order to display notifications in a more robust way. See MsgBox project demo
  /// for sample implementation of this form of integration.
  /// </summary>
  public partial class MainWindow
  {
    #region fields
    private const double topOffset = 100;
    private const double leftOffset = 100;

    // Is a window derived visual control class that shows the actual notification view
    readonly NotificationWindow notificationWindow = new NotificationWindow();

    // Is a viewmodel which keeps the command binding and event triggering to base the notifications on
    // Using this setup tests the real world scenario where notifications are triggered through
    // complex conditions in the viewmodel. These worklflows are not necessarily triggered by a button in a view.
    readonly TestViewModel mTestVM;
    #endregion fields

    #region constructor
    /// <summary>
    /// Class constructor
    /// </summary>
    public MainWindow()
    {
      this.InitializeComponent();

      this.mTestVM = new TestViewModel();
      this.mTestVM.ShowNotificationMessage += TestVM_ShowNotificationMessage;
      this.DataContext = this.mTestVM;

      this.Loaded += OnWindowLoaded;
    }
    #endregion constructor

    #region methods
    /// <summary>
    /// Method is invoked when the window is closed. It also closes the extra notification view.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnClosed(System.EventArgs e)
    {
      this.notificationWindow.Close();
      base.OnClosed(e);
    }

    /// <summary>
    /// Method is invoked when the viewmodel tells the view: Show another notification to the user.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TestVM_ShowNotificationMessage(object sender, UserNotification.Events.ShowNotificationEvent e)
    {
      this.SetNextNotificationPosition();
      this.notificationWindow.ShowNotification(new NotificationViewModel
      {
        Title = e.Title,
        ImageIcon = e.ImageIcon,
        Message = e.Message
      });
    }

    /// <summary>
    /// Method is invoked to re-position the notification view such that it is close to the owning view.
    /// </summary>
    private void SetNextNotificationPosition()
    {
      this.notificationWindow.Top = this.Top + topOffset;
      this.notificationWindow.Left = this.Left + leftOffset;

      // Re-position notifiaction window if it appears to be outside of the visual screen
      // This works on primary screen [1 screen scenario] not sure if it works on 2 or more screens (?)
      if (this.notificationWindow.Top + this.notificationWindow.Height > SystemParameters.VirtualScreenHeight)
        this.notificationWindow.Top = SystemParameters.VirtualScreenHeight - this.notificationWindow.Height;

      if (this.notificationWindow.Left + this.notificationWindow.Width > SystemParameters.VirtualScreenWidth)
        this.notificationWindow.Left = SystemParameters.VirtualScreenWidth - this.notificationWindow.Width;

      if (this.notificationWindow.Top < SystemParameters.VirtualScreenTop)
        this.notificationWindow.Top = SystemParameters.VirtualScreenTop + 10;

      if (this.notificationWindow.Left < SystemParameters.VirtualScreenLeft)
        this.notificationWindow.Left = SystemParameters.VirtualScreenLeft + 10;
    }

    /// <summary>
    /// Method is invoked when the window is Loaded to set the notification owner property.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnWindowLoaded(object sender, RoutedEventArgs e)
    {
      //this will make minimize restore of notifications too
      this.notificationWindow.Owner = GetWindow(this);
    }
    #endregion methods
  }
}
