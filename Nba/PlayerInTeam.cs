//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nba
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayerInTeam
    {
        public int PlayerInTeamId { get; set; }
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public int SeasonId { get; set; }
        public string ShirtNumber { get; set; }
        public decimal Salary { get; set; }
        public int StarterIndex { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Season Season { get; set; }
        public virtual Team Team { get; set; }
    }
}
