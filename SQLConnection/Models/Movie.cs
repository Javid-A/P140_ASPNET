namespace SQLConnection.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double IMDB { get; set; }
        public string Image { get; set; }
        public MovieHeader MovieHeader { get; set; }
        //public Movie()
        //{
        //    MovieHeader = new MovieHeader();
        //}
    }
}
