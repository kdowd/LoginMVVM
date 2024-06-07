using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMVVM.ViewModels
{
    public class LoggedInUser
    {
        public bool LoggedInStatus { get; set; }

        public LoggedInUser()
        {
            LoggedInStatus = true;

        }
    }
}
