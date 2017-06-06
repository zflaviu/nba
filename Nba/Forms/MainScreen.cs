using System;
using System.Windows.Forms;
using Nba.Core;
using Nba.UserControls;

namespace Nba.Forms
{
    public partial class MainScreen : Form
    {
        MainScreenUserControl _mainScreenUserControl = new MainScreenUserControl();
        VisitorsMenuUserControl _visitorsMenuUserControl = new VisitorsMenuUserControl();
        TeamsUserControl teamsUserControl = new TeamsUserControl();

        public MainScreen()
        {
            InitializeComponent();
            //_mainScreenUserControl.LoadScreenEvent += new MainScreenUserControl.LoadScreen(LoadControl);
        }
        
        private void MainScreen_Load(object sender, System.EventArgs e)
        {
            LoadControl(ScreensEnum.MainScreen);
            //LoadControl(ScreensEnum.TeamsMain);
        }

        public void LoadControl(ScreensEnum screenType)
        {
            if (screenType == ScreensEnum.MainScreen)
            {
                if (Controls.Count > 0)
                    this.Controls.Remove(ActiveControl);
                _mainScreenUserControl.Dock = DockStyle.Fill;
                this.Controls.Add(_mainScreenUserControl);
            }else if (screenType == ScreensEnum.VisitorScreen)
            {
                if (Controls.Count > 0)
                    this.Controls.Remove(ActiveControl);
                _visitorsMenuUserControl.Dock = DockStyle.Fill;
                this.Controls.Add(_visitorsMenuUserControl);
            }else if (screenType == ScreensEnum.TeamsMain)
            {
                if(Controls.Count > 0)
                    this.Controls.Remove(ActiveControl);
                teamsUserControl.Dock = DockStyle.Fill;
                this.Controls.Add(teamsUserControl);
                
            }
        }


    }
}