using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicArtists
{
    public class MusicArtist
    {
        public string Name { get; set; } = String.Empty;
        public string Genre { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public string IncomePerYear { get; set; } = String.Empty;
        public string Band { get; set; } = String.Empty;
        public string Activity { get; set; } = String.Empty;

        public bool Compare(MusicArtist temp)
        {
            if(this.Name == temp.Name && this.Genre == temp.Genre && this.Country == temp.Country &&
                this.IncomePerYear == temp.IncomePerYear && this.Band == temp.Band && this.Activity == temp.Activity)
            {
                return true;
            }
            return false;
        }
    }
}
