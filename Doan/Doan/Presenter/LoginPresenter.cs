using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doan.Model;
using Doan.View;

namespace Doan.Presenter
{
    public class LoginPresenter
    {
        ILogin loginview;
        public LoginPresenter(ILogin view)
        {
            loginview = view;
        }
        public bool Login()
        {
            User user = new User();

            if (user.CheckValidate(loginview.Usernametext, loginview.Passwordtext))
            {
                loginview.Message = string.Format("Login successfully!");
                return true;
            }

            else
            {
                loginview.Message = string.Format("Fail to login! Check your Username and Password again");
                return false;
            }
        }
        
    }
}
