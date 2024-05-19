namespace DataAnnotations.Application.Dtos.User
{
    public class GetUserDto
    {
        public long Id { get; set; }
        public string User { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
