using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nba.Core;

namespace Nba.UserControls
{
    public partial class VisitorsMenuUserControl : UserControl
    {
        public VisitorsMenuUserControl()
        {
            InitializeComponent();
        }

        private void butTeams_Click(object sender, EventArgs e)
        {
            var parentForm = this.ParentForm as Form;
            if (parentForm != null && parentForm.Controls.Count > 0)
            {
                parentForm.Controls.Clear();
                parentForm.Controls.Add(new BackUserControl{LastScreen = ScreensEnum.VisitorScreen, Dock = DockStyle.Top});
                parentForm.Controls.Add(new TeamsUserControl{Dock = DockStyle.Fill});
            }
        }

        private void butPlayers_Click(object sender, EventArgs e)
        {

        }

        private void butMachups_Click(object sender, EventArgs e)
        {

        }

        private void butPhotos_Click(object sender, EventArgs e)
        {

        }
    }
}
