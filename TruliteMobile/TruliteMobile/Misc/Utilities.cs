using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruliteMobile.Misc
{
    internal class Utilities
    {
        public static IEnumerable<KeyValuePair<string, string>> GetStateList()
        {
            var list = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(  ""  ,"Select State"),
              new KeyValuePair<string, string>(  "AL"  ,"Alabama"),
new KeyValuePair<string, string>(  "AK"  ,"Alaska"),
new KeyValuePair<string, string>(  "AZ"  ,"Arizona"),
new KeyValuePair<string, string>(  "AR"  ,"Arkansas"),
new KeyValuePair<string, string>(  "CA"  ,"California"),
new KeyValuePair<string, string>(  "CO"  ,"Colorado"),
new KeyValuePair<string, string>(  "CT"  ,"Connecticut"),
new KeyValuePair<string, string>(  "DE"  ,"Delaware"),
new KeyValuePair<string, string>(  "FL"  ,"Florida"),
new KeyValuePair<string, string>(  "GA"  ,"Georgia"),
new KeyValuePair<string, string>(  "HI"  ,"Hawaii"),
new KeyValuePair<string, string>(  "ID"  ,"Idaho"),
new KeyValuePair<string, string>(  "IL"  ,"Illinois"),
new KeyValuePair<string, string>(  "IN"  ,"Indiana"),
new KeyValuePair<string, string>(  "IA"  ,"Iowa"),
new KeyValuePair<string, string>(  "KS"  ,"Kansas"),
new KeyValuePair<string, string>(  "KT"  ,"Kentucky"),
new KeyValuePair<string, string>(  "LA"  ,"Louisiana"),
new KeyValuePair<string, string>(  "ME"  ,"Maine"),
new KeyValuePair<string, string>(  "MD"  ,"Maryland"),
new KeyValuePair<string, string>(  "MA"  ,"Massachusetts"),
new KeyValuePair<string, string>(  "MI"  ,"Michigan"),
new KeyValuePair<string, string>(  "MI"  ,"Minnesota"),
new KeyValuePair<string, string>(  "MS"  ,"Mississippi"),
new KeyValuePair<string, string>(  "M0"  ,"Missouri"),
new KeyValuePair<string, string>(  "MT"  ,"Montana"),
new KeyValuePair<string, string>(  "NE"  ,"Nebraska"),
new KeyValuePair<string, string>(  "NV"  ,"Nevada"),
new KeyValuePair<string, string>(  "NH"  ,"New Hampshire"),
new KeyValuePair<string, string>(  "NJ"  ,"New Jersey"),
new KeyValuePair<string, string>(  "NM"  ,"New Mexico"),
new KeyValuePair<string, string>(  "NY"  ,"New York"),
new KeyValuePair<string, string>(  "NC"  ,"North Carolina"),
new KeyValuePair<string, string>(  "ND"  ,"North Dakota"),
new KeyValuePair<string, string>(  "OH"  ,"Ohio"),
new KeyValuePair<string, string>(  "OK"  ,"Oklahoma"),
new KeyValuePair<string, string>(  "OR"  ,"Oregon"),
new KeyValuePair<string, string>(  "PA"  ,"Pennsylvania"),
new KeyValuePair<string, string>(  "RI"  ,"Rhode Island"),
new KeyValuePair<string, string>(  "SC"  ,"South Carolina"),
new KeyValuePair<string, string>(  "SD"  ,"South Dakota"),
new KeyValuePair<string, string>(  "TN"  ,"Tennessee"),
new KeyValuePair<string, string>(  "TX"  ,"Texas"),
new KeyValuePair<string, string>(  "UT"  ,"Utah"),
new KeyValuePair<string, string>(  "VT"  ,"Vermont"),
new KeyValuePair<string, string>(  "VI"  ,"Virginia"),
new KeyValuePair<string, string>(  "WA"  ,"Washington"),
new KeyValuePair<string, string>(  "WV"  ,"West Virginia"),
new KeyValuePair<string, string>(  "WI"  ,"Wisconsin"),
new KeyValuePair<string, string>(  "WY"  ,"Wyoming")
            };
            return list;
        }

      



    }
}