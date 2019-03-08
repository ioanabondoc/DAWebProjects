using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStructure
{
    public class Transport
    {
        public Road[] roads;
        public Line[] transportLines;
        public Station[] transportStations;
        public Intersection[] intersections;
    }
    public class Road
    {
        public string Name { get; set; }
    }
    public class Street : Road
    {
        //Name: centura? drum express?
    }
    public class Bridge : Road
    {
        public Address Address { get; set; }
    }
    public class Line
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Street[] Streets;
        //types:internBus,tram
    }

    public class Station
    {
        public Address Address { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        //types: internBus,externBus(autogara),taxi,train,tram
    }

    public class Intersection
    {
        public string Name { get; set; }
        public string Type{ get; set; }
        public Street[] Streets;
    }
    
}
