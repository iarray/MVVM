using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVM简单例子.Commands
{
    class DelegateCommand:ICommand
    {
        public bool CanExecute(object parameter)
        {
            if (CanExcuteFunc == null)
            {
                return true;
            }
            return this.CanExcuteFunc(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (ExecuteAction == null)
            {
                return;
            }
            this.ExecuteAction(parameter);
        }

        public Action<object> ExecuteAction { get; set; }
        public Func<object,bool> CanExcuteFunc { get; set; }

    }
}
