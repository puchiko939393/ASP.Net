using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Models;
using System;
using System.Collections.Generic;


namespace MvcMovie.Models
{
  
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }

}

