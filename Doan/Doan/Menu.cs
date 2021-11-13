using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Doan
{
    public partial class Menu : Form
    {
        private IconButton currentButton;
        private Panel leftBorderbtn;
        public Menu()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderbtn);
        }
        private struct RNBColor
        {
            public static Color color = Color.FromArgb(197,190,29);
        }
        private void ActiveButton(object senderbtn, Color color)
        {
            if(senderbtn != null)
            {
                disableButton();

                currentButton = (IconButton)senderbtn;
                currentButton.BackColor = Color.FromArgb(33,140,44);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
            }
        }

        private void disableButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(33, 140, 44);
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButtonSP_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
        }

        private void icButtonImport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
        }

        private void iconButtonSale_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
        }

        private void icButtonInventory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
        }

        private void icButtonReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
        }

        private void icButtonProduct_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
        }

        private void img_home_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            disableButton();
            leftBorderbtn.Visible = false;
        }
    }
}
