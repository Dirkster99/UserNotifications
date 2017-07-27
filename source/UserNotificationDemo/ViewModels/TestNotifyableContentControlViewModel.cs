namespace UserNotificationDemo.ViewModels
{
  using System.Collections.ObjectModel;
  using System.Windows.Input;
  using UserNotification.ViewModel;
  using UserNotificationDemo.Commands;

  /// <summary>
  /// Implement a test viewmodel class for driving the
  /// <seealso cref="UserNotification.View.NotifyableContentControl"/>.
  /// </summary>
  public class TestNotifyableContentControlViewModel : Base.ViewModelBase
  {
    #region fields
    private RelayCommand<object> mShowNotificationCommand = null;

    private SendNotificationViewModel mNotification;
    #endregion fields

    /// <summary>
    /// Class constructor
    /// </summary>
    public TestNotifyableContentControlViewModel()
    {
      this.Notification = new SendNotificationViewModel();

      // Create test collection with demo data
      this.ItemCollection = new ObservableCollection<string>();

      for (int i = 0; i < 100; i++)
      {
        this.ItemCollection.Add("Demo Item " + i);
      }
    }

    #region properties
    /// <summary>
    /// Implement a test data collection for supplying data to a ListBox control.
    /// </summary>
    public ObservableCollection<string> ItemCollection { get; set; }

    /// <summary>
    /// Gets the command that toggle the property that determines
    /// whether a notification is currently visible or not.
    /// </summary>
    public ICommand ShowNotificationCommand
    {
      get
      {
        if (this.mShowNotificationCommand == null)
          this.mShowNotificationCommand = new RelayCommand<object>((p) =>
          {
            this.Notification.ShowNotification("Demo Title", "Demo Message");
          });

        return this.mShowNotificationCommand;
      }
    }

    /// <summary>
    /// Gets a property that can be bound to the Notification dependency property
    /// of the <seealso cref="UserNotification.View.NotifyableContentControl"/>.
    /// Application developers can invoke the ShowNotification method to show a
    /// short pop-up message to the user. The pop-up message is shown in the
    /// vicinity of the content control that contains the real control (eg: ListBox)
    /// to which this notfication is related to.
    /// </summary>
    public SendNotificationViewModel Notification
    {
      get
      {
        return mNotification;
      }

      set
      {
        if (this.mNotification != value)
        {
          this.mNotification = value;
          this.RaisePropertyChanged(() => this.Notification);
        }
      }
    }
    #endregion properties
  }
}
