using FuncoGallery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FuncoGallery.ViewModels
{
    public class GameFormViewModel
    {
        public int? Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public int? Quantity { get; set; }

        [Required]
        public decimal? Price { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public GameFormViewModel()
        {
            Id = 0;
        }

        public GameFormViewModel(Game game)
        {
            Id = game.Id;
            Name = game.Name;
            ReleaseDate = game.ReleaseDate;
            Quantity = game.Quantity;
            Price = game.Price;
            GenreId = game.GenreId;

        }
    }
}