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
    public partial class MainScreenUserControl : UserControl
    {
        public MainScreenUserControl()
        {
            InitializeComponent();
        }

        private void butVisitor_Click(object sender, EventArgs e)
        {
            var parentForm = this.ParentForm as Form;
            if (parentForm != null && parentForm.Controls.Count > 0)
            {
                parentForm.Controls.Clear();
                parentForm.Controls.Add(new BackUserControl{LastScreen = ScreensEnum.MainScreen, Dock = DockStyle.Top});
                parentForm.Controls.Add(new VisitorsMenuUserControl{Dock = DockStyle.Fill});
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
