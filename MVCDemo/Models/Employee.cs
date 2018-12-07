using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }

        [Range(22, 60)]
        public int Age { get; set; }




        //[Key]
        //[Column(Order = 0)]
        //public int ID { get; set; }

        //public string Name { get; set; }

        //[Key]
        //[Column(Order = 1)]
        //public DateTime JoiningDate { get; set; }

        //[Key]
        //[Column(Order = 2)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int Age { get; set; }
    }
}