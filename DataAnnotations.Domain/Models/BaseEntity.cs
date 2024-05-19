namespace DataAnnotations.Domain.Models
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
