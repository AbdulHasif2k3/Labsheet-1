using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    public class Album
    {
        //Properties

        public string Name { get; set; }
        public int YearOfRelease { get; set; }

        public int Sales { get; set; }
        
        //Constructors

        public Album(string name, int yearOfRelease, int sales)
        {
            Name = name;
            YearOfRelease = yearOfRelease;
            Sales = sales;
        }

        public int yearsSinceRelease;

        public int YearsSinceRelease
        {

            get
            {
               
                yearsSinceRelease = DateTime.Now.Year - YearOfRelease;
                return yearsSinceRelease;
            }

        }

        //Methods
        public override string ToString()
        {
            return string.Format($"{Name} - released in  {YearOfRelease}. Sales of {Sales}. Years since release {YearsSinceRelease}years");
        }

    }
}
