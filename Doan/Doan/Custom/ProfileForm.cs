using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan.Custom
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }
        private string _name;
        private string _position;
        private string _id;
        public ProfileForm (string name, string position, string id): this()
        {
            this._name = name;
            this._position = position;
            this._id = id;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            tbid.Text = _id;
            tbName.Text = _name;
            tbPosition.Text = _position;
            tbid.Enabled = false;
            tbName.Enabled = false;
            tbPosition.Enabled = false;
            
        }
    }
}
