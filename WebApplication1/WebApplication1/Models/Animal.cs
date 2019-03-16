using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Animal
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public Animal(string nm,int w, string tp="Terrestrial")
        {
            ID = new Guid();
            Name = nm;
            Weight = w;
            Type = tp;
        }
        
    }
}