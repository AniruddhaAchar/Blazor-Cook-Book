using Microsoft.CodeAnalysis.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBook.Model
{
    public class Recipe_Time
    {
        public class Time_Holder
        {
            public double Time { get; set; }
            public string Unit { get; set; }
        }

        public Time_Holder Prep_Time { get; set; }
        public Time_Holder Cook_Time { get; set; }
        public Time_Holder Rest_Time { get; set; }
    }

    
}
