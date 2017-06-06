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
    public partial class BackUserControl : UserControl
    {
        public ScreensEnum LastScreen;

        
        MainScreenUserControl _mainScreenUserControl = new MainScreenUserControl();
        VisitorsMenuUserControl _visitorsMenuUserControl = new VisitorsMenuUserControl();
        TeamsUserControl _teamsUserControl = new TeamsUserControl();
        public BackUserControl()
        {
            InitializeComponent();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            var parentForm = this.ParentForm as Form;
            if (parentForm != null && parentForm.Controls.Count > 0)
            {
                if(parentForm.Controls.Count == 1)
                    parentForm.Controls.Clear();
                else if (parentForm.Controls.Count == 2)
                    parentForm.Controls.Remove(parentForm.Controls[1]);
                if(LastScreen == ScreensEnum.MainScreen)
                    parentForm.Controls.Add(_mainScreenUserControl);
                else if (LastScreen == ScreensEnum.VisitorScreen)
                {
                    _visitorsMenuUserControl.Dock = DockStyle.Fill;
                    //parentForm.Controls.Add(this.LastScreen = ScreensEnum.MainScreen, this.Dock =DockStyle.Top);
                    //parentForm.Controls.Add(new BackUserControl {LastScreen = ScreensEnum.MainScreen, Dock = DockStyle.Top});
                    parentForm.Controls.Add(_visitorsMenuUserControl);
                }
                else if (LastScreen == ScreensEnum.TeamsMain)
                {
                    _teamsUserControl.Dock = DockStyle.Fill;
                    //parentForm.Controls.Add(new BackUserControl{LastScreen = ScreensEnum.VisitorScreen, Dock = DockStyle.Top});
                    parentForm.Controls.Add(_teamsUserControl);
                }
            }
        }
    }
}
