using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nba.Models
{
    public class ConferenceModel
    {
        public int ConferenceId { get; set; }
        public string ConferenceName { get; set; }
        public List<Division> Divisions = new List<Division>();
    }
}
