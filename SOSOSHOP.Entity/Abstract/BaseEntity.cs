namespace SOSOShop.Entity.Abstract
{
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
