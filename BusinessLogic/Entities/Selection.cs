namespace BusinessLogic.Entities
{
    public class Selection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
