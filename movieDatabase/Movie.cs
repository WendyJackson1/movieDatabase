using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieDatabase
{
    public class Movie
    {
        private string _movieTitle;
        public string MovieTitle
        {
            get { return _movieTitle; }
            set { _movieTitle = value; }
        }
        private string _movieType;

        public string MovieType 
        { 
            get { return _movieType; }
            set { _movieType = value; }
        }

        public Movie(string movieTitle, string movieType)
        {
            this.MovieTitle = movieTitle;
            this.MovieType = movieType;
        }



    }
}

