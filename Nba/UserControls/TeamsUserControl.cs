using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nba.Models;

namespace Nba.UserControls
{
    public partial class TeamsUserControl : UserControl
    {
        public TeamsUserControl()
        {
            InitializeComponent();
            
            LoadData();
        }

        private void LoadData()
        {
            var db = new NBAContext();
            var teams = from t in db.Teams
                select new Team
                {
                    Coach = t.Coach,
                    Division = t.Division,
                    DivisionId = t.DivisionId,
                    Logo = t.Logo,
                    TeamId = t.TeamId,
                    TeamName = t.TeamName,
                };
            var conferences = from c in db.Conferences
                select new ConferenceModel()
                {
                    ConferenceId = c.ConferenceId,
                    ConferenceName = c.Name,
                    Divisions = c.Divisions.ToList()
                };
            foreach (var c in conferences)
            {
                var tabPage = new TabPage {Text = c.ConferenceName};
                var flwLayoutPanel = new FlowLayoutPanel();

                foreach (var division in c.Divisions)
                {
                    var divisionUserControl = new DivisionUserControl{DivisionName = division.Name, Teams = division.Teams};
                    divisionUserControl.LoadData();
                    flwLayoutPanel.Controls.Add(divisionUserControl);
                    
                }
                flwLayoutPanel.Dock = DockStyle.Fill;
                flwLayoutPanel.Anchor =
                    (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                tabPage.Controls.Add(flwLayoutPanel);
                tabControlConferences.TabPages.Add(tabPage);
            }
            
        }


    }
}
