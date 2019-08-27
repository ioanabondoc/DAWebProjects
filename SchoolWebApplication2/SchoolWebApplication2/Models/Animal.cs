using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebApplication2.Models
{
    

    public class Animal
    {
        [ScaffoldColumn(false)] //i want to ignore the id when i scaffold a view
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The animal's name is required.Be creative, create a new one on the spot.")]
        public string Name { get; set; }
        
        public string Type { get; set; }
        
        public string Gender { get; set; }

        public string Breed { get; set; }

        [Display(Name = "Date arrived")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="The date when the animal arrived in the center is required.")]
        public DateTime DateArrived { get; set; }
        
        public string Age { get; set; }

        [Display(Name="Photo's URL")]
        [StringLength(1024)]
        [Url(ErrorMessage ="For now only internet links work, not local(from your computer)." +
            "You can upload the photo on a social media platform and then copy paste link in here.")]
        public string PhotoLink { get; set; }

        public Animal() { }

        //public Animal(string name,string type,string sex, DateTime arDate,string age="Unknown", string breed = "Unknown")
        //{
        //    //acest constructor nu se apeleaza in model-form binding
        //    Id = Guid.NewGuid();
        //    Type = type;
        //    Breed = breed;
        //    ArrivingDate = arDate;
        //    Age = age;
        //}


    }
}
