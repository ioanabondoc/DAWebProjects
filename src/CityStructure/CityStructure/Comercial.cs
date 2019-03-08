using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStructure
{
    class Comercial
    {
        //malls,markets,supermarkets,abc,clothing store,
        //squares(piete)
        public Mall[] malls;
        public Shop[] shops;
        public ComercialSquare[] comercialSquares;
    }
    public class ComercialSquare : Location
    {
        public string Type { get; set; } //fruits,clothes,cars,etc;
        public double Area { get; set; }
    }
    public class Shop:Location
    {
        public string Type { get; set; }//abc,market,clothing store
    }
    public class Mall : Location
    {
        public Shop[] shops;
    }
}
