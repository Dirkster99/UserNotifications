namespace UserNotification.ViewModel.Base
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    /// <summary>
    /// Implements the <seealso cref="INotifyPropertyChanged"/> interface to supply
    /// a base for viewmodel classes in an MVVM pattern like application.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Implements the property changed event of the <seealso cref="INotifyPropertyChanged"/> interface.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Tell bound controls (via WPF binding) to refresh their display.
        /// 
        /// Sample call: this.NotifyPropertyChanged(() => this.IsSelected);
        /// where 'this' is derived from <seealso cref="ViewModelBase"/>
        /// and IsSelected is a property.
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="property"></param>
        public void RaisePropertyChanged<TProperty>(Expression<Func<TProperty>> property)
        {
            var lambda = (LambdaExpression)property;
            MemberExpression memberExpression;

            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
                memberExpression = (MemberExpression)lambda.Body;

            this.RaisePropertyChanged(memberExpression.Member.Name);
        }

        /// <summary>
        /// Base function to raise a property changed event for the given named property.
        /// </summary>
        /// <param name="propertyName">Name of property to raise the event for.</param>
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
