using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {

        [Key]
        public int Id { get; set; }
        public string logo { get; set; }
        public string Name { get; set; }

        public string Decription { get; set; }


        public List<Movie> Movies { get; set; }
    }
}
