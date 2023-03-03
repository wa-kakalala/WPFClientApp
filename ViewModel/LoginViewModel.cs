using ClientApp.Common;
using System;
using ClientApp.Common;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Model;

namespace ClientApp.ViewModel
{
    public class LoginViewModel
    {
        public CommandBase CloseWindowCommand { get; set; }
        public LoginModel LoginInfoModel { get; set; }

        public LoginViewModel() {
            this.CloseWindowCommand = new CommandBase();
            this.LoginInfoModel = new LoginModel();
            this.LoginInfoModel.UserName = "wkklalala";
            this.LoginInfoModel.ValidationCode = "abcd";

            this.CloseWindowCommand.DoExecute = new Action<object>((o) =>
            {
                (o as Window).Close();

            });

            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>((o) =>{ return true; });
        }
        
    }
}
