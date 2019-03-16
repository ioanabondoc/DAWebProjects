using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStructure
{
    public class Address
    {
        string StreetName;

        int[] StreetNr;
    }

    public class HumanBuildings
    {
        public PermanentLivingPlace[] permanentLivingPlaces;
        public TemporaryLivingPlace[] TemporaryLivingPlaces;
    }

    public class Location
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    public class LivingPlace : Location
    {
        public int HumanCapacity { get; set; }

    }
    public class TemporaryLivingPlace : LivingPlace
    {
        public string Type { get; set; }
        public int NrOfRooms { get; set; }
        /*types: hostel,hotel,pension,etc.*/
    }
    public class PermanentLivingPlace : LivingPlace
    {
        public string Type { get; set; }
        public int NrOfApartements { get; set; } //house=1;blocks=plentier
    }
}
