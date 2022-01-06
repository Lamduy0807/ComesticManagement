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
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            //bunifuTransition1.ShowSync(this);
            icon_delay.Start();
            icon_delay.Enabled = true;
        }

        private void bunifuTransition1_AnimationCompleted(object sender, Bunifu.UI.WinForms.BunifuTransition.AnimationCompletedEventArg e)
        {
            icon_delay.Start();
            icon_delay.Enabled = true;
        }

        private void icon_delay_Tick_1(object sender, EventArgs e)
        {
            icon_delay.Enabled = false;
            icon_delay.Stop();
        }
    }
}
