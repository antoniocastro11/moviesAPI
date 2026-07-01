using moviesApi.Data.Dtos.Session;
using System.ComponentModel.DataAnnotations;

namespace moviesApi.Data.Dtos.Movie
{
    public class ReadMovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public ICollection<ReadSessionDto> Sessions { get; set; }

    }
}
