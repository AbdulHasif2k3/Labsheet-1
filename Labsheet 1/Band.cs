using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    public abstract class Band : IComparable
    {
        //Properties
        public string BandName { get; set; }
        public int YearFormed { get; set; }

        public string Members { get; set; }

        public List <Album> AlbumList { get; set; }

        //Constructors

        public Band(string bandname, int yearFormed, string members)
        {
            BandName = bandname;
            YearFormed = yearFormed;
            Members = members;

            AlbumList = new List<Album>();
        }

        public Band() : this("Unknown", 1960, "Unknown") { }
 

        //methods
        public override string ToString()
        {
            return BandName;
        }

        public int CompareTo(object obj)
        {
            Band otherband = (Band)obj;

            if (otherband != null)
            {
                return this.BandName.CompareTo(otherband.BandName);

            }
            else return 0;

           
        }
    }

    public class RockBand :Band 
    {
        public override string ToString()
        {
            return base.ToString() + " - Rock Band";
        }
    }

    public class PopBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Pop Band";
        }
    }

    public class IndieBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Indie Band";
        }
    }

}
