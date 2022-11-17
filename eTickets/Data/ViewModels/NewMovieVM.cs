using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        /*        [Key]
                public int Id { get; set; }
        e largojme pasi nuk deshirojme te marrim te dhena nga databaza*/

        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]

        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]

        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]

        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]

        public string ImageURL { get; set; }
        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start date is required")]

        public DateTime StartDate { get; set; }
        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie Category is required")]


        public MovieCategory MovieCategory { get; set; }

        //Relationships
        /*   public List<Actor_Movie> Actors_Movies { get; set; }*/

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }
        /*   [ForeignKey("CinemaId")]
           public Cinema Cinema { get; set; }*/
        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer is required")]

        public int ProducerId { get; set; }
     /*   [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }*/


    }
}
