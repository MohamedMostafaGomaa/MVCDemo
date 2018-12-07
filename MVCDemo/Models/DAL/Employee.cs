namespace MVCDemo.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime JoiningDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Age { get; set; }
    }
}
