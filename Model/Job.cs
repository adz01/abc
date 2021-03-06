﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Model
{
    [Table("Job", Schema = "HR")]
    public class Job : Entity
    {
       
        [Required]
        [MaxLength(35)]
        public virtual string JobTitle { get; set; }

        public virtual decimal? MinSalary { get; set; }

        public virtual decimal? MaxSalary { get; set; }


    }
}
