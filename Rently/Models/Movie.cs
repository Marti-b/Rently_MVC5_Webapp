using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rently.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreType Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreTypeId { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

    }
}