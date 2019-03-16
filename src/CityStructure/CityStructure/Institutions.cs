using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStructure
{
    public class Institutions
    {
        //schools,churches,hospitals,banks,townhall,policecenter
        public School[] schools;
        public Church[] churches;
        public Hospital[] hospitals;
        public Bank[] banks;
        public TownHall townHall;
        public PoliceCenter policeCenter;
    }
    public class School : Location
    {
        public string Type { get; set; }
        /*
            types: baby farm(nursery,cresa),kidergarden(gradinita)
        primary sch., middle sch.,high school
        college,university
        */
        public int NrOfLearners { get; set; }
    }
    public class Church: Location
    {
        public string Religion { get; set; }
        /* religions: orthodox,prothestant,baptism,
         chatolic,etc.*/
    }
    public class Hospital:Location
    {
        //types: pedriatic,neurologic,fiziotherapy,etc
        public string Type { get; set; }
        public int HumanCapacity { get; set; }
    }
    public class Bank:Location //FinancialInstitution
    {
       public long FiscalValue { get; set; }
    }
    public class TownHall:Location //PoliticalInstitution
    {
        public string Mayor { get; set; }
        public string[] Departments;
    }
    public class PoliceCenter:Location
    {
        public int NrOfOfficers { get; set; }
        public int NrOfCars { get; set; }
    }

}
