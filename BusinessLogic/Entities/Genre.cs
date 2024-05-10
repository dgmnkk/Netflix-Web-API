namespace BusinessLogic.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
