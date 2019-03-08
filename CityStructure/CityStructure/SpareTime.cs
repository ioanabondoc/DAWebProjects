using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStructure
{
    public class SpareTime
    {   //2 cats: natural-surface in aquare roots,etc.&&buildings
        //parks,lakes,sports ground,swimming pools,cemetery
        //gyms;
        //museums,opera,theatre,cinema,library
        //historical monuments
        public Water[] waters;
        public Park[] parks;
        public SportGround[] sportGrounds;
        public Cemetery cemetery;
        public Gym[] gyms;
        public CulturalInstitution[] culturalInstitutions;
        public CulturalSquare[] culturalSquares;
        public Monument[] monuments;
    }
    public class Surface
    {
        public float Length { get; set; }
        public float Width { get; set; }
        public string Name { get; set; }
    }
    public class Water : Surface
    {
        public string Type { get; set; }
        public float Height { get; set; }

    }
    public class Park : Surface
    {
        public int NrOfPlaygrounds { get; set; }
        public int NrOfMiniSportGrounds { get; set; }
    }

    public class SportGround : Surface
    {
        public string Material { get; set; }
        public string Purpose { get; set; }
    }

    public class SwimmingPool:Surface
    {
        public float Height { get; set; }
        public float WaterTemperature { get; set; }
    }
    public class Cemetery:Surface
    {
        public int NrOfGraves { get; set; }
    }
    public class Gym:Location
    {
        public string[] SportPrograms;
    }

    public class CulturalInstitution : Location
    {
        public string CulturalType { get; set; }
        //library,museum,cinema,etc;
    }

    public class CulturalSquare:Surface
    {
       
    }
    public class Monument
    { //e.g. statues
        public Surface place { get; set; }//a park or a CulturalSquare,overwirte it?
        public string Name { get; set; }
        public int YearOfConstruction { get; set; }
    }

}
