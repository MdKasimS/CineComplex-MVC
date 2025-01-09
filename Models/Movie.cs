﻿using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CineComplex_MVC.Models
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
        public class Movie
    {
        public int Id { get ; set ; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
    }
}
