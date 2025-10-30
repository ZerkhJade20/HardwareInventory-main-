using HardwareInventory_main_.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareInventory_main_.Resources
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(userControl);
            userControl.BringToFront(); 
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_Reports uc = new UC_Reports();
            addUserControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Inventory uc = new UC_Inventory();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Sales uc = new UC_Sales();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Supplier uc = new UC_Supplier();   
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_Staff uc = new UC_Staff();
            addUserControl(uc);
        }
    }
}
