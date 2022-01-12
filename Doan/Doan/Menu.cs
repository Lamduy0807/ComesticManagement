using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Doan.Custom;
using Doan.View;
using Doan.View.Accountant;
using Doan.View.Employee;
using Doan.View.Export;
using Doan.View.Import;
using Doan.View.MenuDropdown;
using Doan.View.Product;
using Doan.View.Sale;
using Doan.View.Statistic;
using Doan.View.Suplier;
using FontAwesome.Sharp;
namespace Doan
{
    public partial class Menu : Form
    {
        private IconButton currentButton;
        private Panel leftBorderbtn;
        private Form currentChildForm;
        private string id;
        private string name;
        private string position;
        public Menu()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderbtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public Menu(string id, string name, string position) : this()
        {
            this.id = id;
            this.name = name;
            this.position = position;
        }
        private struct RNBColor
        {
            //public static Color color = Color.FromArgb(197,190,29);
            public static Color color = Color.FromArgb(201, 249, 8);
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ActiveButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                disableButton();

                currentButton = (IconButton)senderbtn;
                //currentButton.BackColor = Color.FromArgb(127, 198, 102);
                currentButton.BackColor = Color.FromArgb(33, 140, 44);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //leftBorderbtn.BackColor = color;
                //leftBorderbtn.Location = new Point(0, currentButton.Location.Y);
                //leftBorderbtn.Visible = true;
                //leftBorderbtn.BringToFront();

                icbtncurentform.IconChar = currentButton.IconChar;
            }
        }

        private void disableButton()
        {
            if (currentButton != null)
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
            OpenChildForm(new ImportForm(id, name));
            lbName.Text = "Import";
        }

        private void iconButtonSale_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
            OpenChildForm(new SaleForm(id));
            lbName.Text = "Sale";

        }

        private void icButtonInventory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
        }

        private void icButtonReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
            lbName.Text = "Report";
        }

        private void icButtonProduct_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
            OpenChildForm(new ProductForm());
            lbName.Text = "Product";
        }
        private void icButtonEmployee_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
            OpenChildForm(new EmployeeForm());
            lbName.Text = "Employees";
        }

        private void img_home_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                Reset();
                currentChildForm.Close();
            }
        }
        private void icButtonSuplier_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
            OpenChildForm(new SuplierForm());
            lbName.Text = "Supliers";
        }
        private void icButtonExport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
            OpenChildForm(new ExportForm(id,name));
            lbName.Text = "Export";
        }
        private void Reset()
        {
            disableButton();
            leftBorderbtn.Visible = false;
            icbtncurentform.IconChar = IconChar.Home;
            lbName.Text = "Home";
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTilteBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseClick_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to quit the app?", "Close Window", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void icButtonReport_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RNBColor.color);
            OpenChildForm(new StatisticsForm(name));
            lbName.Text = "Report";
        }

       /* private void icHome_Click(object sender, EventArgs e)
        {

        }*/

        private void Menu_Load(object sender, EventArgs e)
        {
            //rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu1.PrimaryColor = Color.DarkOrange;
            //label1.Text = "Welcome to store with " + position + " permission";
            if(position == "SalesMan")
            {
                iconButtonSale.Enabled = true;
                icButtonReport.Enabled = true;
            }
            else if(position == "InventoryDepartment")
            {
                icButtonImport.Enabled = true;
                icButtonExport.Enabled = true;
                icButtonProduct.Enabled = true;
            }
            else if(position == "AccountingDepartment")
            {
                icButtonAccountant.Enabled = true;
                icButtonReport.Enabled = true;
            }
            else
            {
                iconButtonSale.Enabled = true;
                icButtonProduct.Enabled = true;
                icButtonEmployee.Enabled = true;
                icButtonSuplier.Enabled = true;
                icButtonImport.Enabled = true;
                icButtonExport.Enabled = true;
                icButtonAccountant.Enabled = true;
                icButtonReport.Enabled = true;
            }
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            //rjDropdownMenu1.Show(iconButton3, iconButton3.Width, 0);
            Open_DropdownMenu(rjDropdownMenu1, sender);
        }


        private void receiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveButton(icButtonAccountant, RNBColor.color);
            OpenChildForm(new ReceiptsForm(id));
            lbName.Text = "Receipt";
        }

        private void paySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveButton(icButtonAccountant, RNBColor.color);
            OpenChildForm(new PaySlipForm(id));
            lbName.Text = "PaySlip";
        }

        private void Open_DropdownMenu( RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged+=new EventHandler((sender2, ev)
                => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if(!DesignMode)
            {
                /*if (dropdownMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(72, 52, 183);
                else ctrl.BackColor = Color.FromArgb(24, 24, 36);*/
            }    
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icButtonSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ProfileForm p = new ProfileForm(name,position,id);
            //Dialog menu = new Dialog();
            //BunifuTransition transition = new BunifuTransition();
            //transition.ShowSync(menu, false,
            //    Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            p.Show();
        }

        private void icButtonHome_Click(object sender, EventArgs e)
        {
           if(currentChildForm!=null)
            {
                Reset();
                currentChildForm.Close();
            }   
        }
    }
}
