using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.View
{
    public interface ILogin
    {
        string Usernametext { get; set; }
        string Passwordtext { get; set; }
        string Message { get; set; }
    }
}
