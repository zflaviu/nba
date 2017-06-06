using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nba.UserControls
{
    public partial class TeamUserControl : UserControl
    {
        public Team Team;
        

        public TeamUserControl()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            labelTitle.Text = Team.TeamName;
            Bitmap bmp;
            using (var ms = new MemoryStream(Team.Logo))
            {
                bmp = new Bitmap(ms);
            }
            pictureBoxTeamLogo.Image = bmp;
        }
    }
}
