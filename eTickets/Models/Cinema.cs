﻿using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema :IEntityBase
    {

        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        [Required (ErrorMessage = "Cinema Logo required")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required (ErrorMessage ="Cinema Name required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 20 chars")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema Description required")]

        public string Description { get; set; }


        public List<Movie> Movies { get; set; }
    }
}
