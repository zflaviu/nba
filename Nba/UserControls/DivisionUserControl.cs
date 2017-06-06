using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nba.UserControls
{
    public partial class DivisionUserControl : UserControl
    {
        public string DivisionName;
        public ICollection<Team> Teams = new List<Team>();
        public DivisionUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            labelTitle.Text = DivisionName;
            foreach (var team in Teams)
            {
                var teamControl = new TeamUserControl {Team = team};
                teamControl.LoadData();
                flowLayoutPanel.Controls.Add(teamControl);
            }
        }
    }
}
