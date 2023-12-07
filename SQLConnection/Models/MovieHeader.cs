namespace SQLConnection.Models
{
    public class MovieHeader
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        //public MovieHeader()
        //{
        //    Movie = new Movie();
        //}
    }
}
