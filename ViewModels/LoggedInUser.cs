using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LoginMVVM.Commands;

namespace LoginMVVM.ViewModels
{
    public class LoggedInUser
    {
        public bool LoggedInStatus { get; set; }
        public ICommand LogOutCommand { get;  }


        public LoggedInUser()
        {
            LoggedInStatus = true;
            LogOutCommand = new LogOutCommand(this);
        }
    }
}
