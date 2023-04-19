using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HanControls.Command
{
    public class CommandBase : ICommand
    {
        public CommandBase() { }

        public CommandBase(Action<object> DoExecute)
        {
            this.DoExecute = DoExecute;
        }

        public CommandBase(Action<object> DoExecute, Func<object, bool> DoCanExecute)
        {
            this.DoExecute = DoExecute;
            this.DoCanExecute = DoCanExecute;
        }

        //  public event EventHandler CanExecuteChanged;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return DoCanExecute == null ? true : DoCanExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }


        public Action<object> DoExecute { get; set; }

        public Func<object, bool> DoCanExecute { get; set; }

    }
}
