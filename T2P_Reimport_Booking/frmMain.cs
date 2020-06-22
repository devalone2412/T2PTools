using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2P_Reimport_Booking
{
    public partial class frmMain : Form
    {
        private IconButton currentButton;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Dock = DockStyle.Fill;
            pnMainContent.Controls.Add(frmDashboard);
        }

        private void ActiveButton(object sender)
        {
            if(sender != null)
            {
                DisabledButton();
                currentButton = (IconButton)sender;
                currentButton.BackColor = Color.FromArgb(205, 172, 218);
            }
        }

        private void DisabledButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(155, 89, 182);
            }
        }
    }
}
