using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LoginMVVM.ViewModels;

namespace LoginMVVM.Commands
{
    public class LogOutCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private LoggedInUser vm;

        public LogOutCommand(LoggedInUser vm) {
            this.vm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show("664");
            vm.LoggedInStatus = false;
            
        }
    }
}
