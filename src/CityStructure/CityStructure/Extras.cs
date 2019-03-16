using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStructure
{
    class Extras
    {
        public Factory[] factories;
        public GasStation[] gasStations;
    }

    public class Factory : Location
    {
        public string Type { get; set; }
        public float PollutionRate { get; set; }
        /*
        e.g. shoe factory,chocolate factory,car factory,etc.
        *pollution rate,nr. of employers,incasari
        */
    }

    public class GasStation:Location
    {
        public string[] TypesOfCarburants;
    }
}
