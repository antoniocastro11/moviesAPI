using System.ComponentModel.DataAnnotations;

namespace moviesApi.Data.Dtos
{
    public class ReadMovieDto
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
    }
}
