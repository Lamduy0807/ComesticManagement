using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Doan.Custom;
using Doan.Presenter;

namespace Doan.View
{
    public partial class LoginForm : Form, ILogin
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Usernametext
        { 
            get
            {
                return txtUsername.Text;
            }
            set
            {
                txtUsername.Text = value;
            }
        }
        public string Passwordtext 
        { 
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }
        private string _message;
        public string Message 
        {
            get 
            {
                return _message;
            } 
            set 
            {
                _message = value;
                //MessageBox.Show(_message);
            } 
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPresenter loginPresenter = new LoginPresenter(this);
            if (loginPresenter.Login())
            {
                string id = loginPresenter.GetId();
                string name = loginPresenter.GetName();
                string position = loginPresenter.GetPosition();
                Menu menu = new Menu(id, name, position);
                //Dialog menu = new Dialog();
                this.Hide();
                menu.Show();
            } 
            else
            {
                MessageBox.Show(_message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseClick_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to quit the app?", "Close Window", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
                this.Close();
        }
    }
}
