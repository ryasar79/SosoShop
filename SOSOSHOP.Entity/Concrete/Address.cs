namespace SOSOSHOP.Entity.Concrete
{
    using SOSOSHOP.Core.Entity;
    using SOSOSHOP.Entity.Abstract;

    public class Address : BaseEntity, IEntity
    {
        public string AddressName { get; set; }
        public string AddressText { get; set; }
        public int CustomerId { get; set; }
    }
}
