using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDemo.Behavior.Models
{
    public static class CountryData
    {
        public static IList<Country> Countries { get; private set; }

        static CountryData()
        {
            Countries = new List<Country>();
            Countries.Add(new Country
            {
                Id = "93",
                CountryName = "Afghanistan (+93)",
                Mask = "(XXX) XXXX XXXX"
            });

            Countries.Add(new Country
            {
                Id = "335",
                CountryName = "Albania (+355)",
                Mask = "(XXX) XXXX XXX"
            });
        }
    }
}
