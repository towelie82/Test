using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFirebase.Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public List<UserLocationData> userdata { get; set; }
    }
    public class UserLocationData
    {
        public string Location { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
