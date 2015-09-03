using System.ComponentModel;

namespace MVVM简单例子.ViewModles
{
    class NotificationObject:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
