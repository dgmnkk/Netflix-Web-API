namespace BusinessLogic.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserId { get; set; }
        public User? User { get; set; }
    }
}
