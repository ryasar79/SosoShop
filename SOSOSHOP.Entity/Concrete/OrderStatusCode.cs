namespace SOSOSHOP.Entity.Concrete
{
    using SOSOSHOP.Entity.Abstract;
	using SOSOSHOP.Core.Entity;

	public class OrderStatusCode : BaseEntity, IEntity
    {
        public string status_code{ get; set; }
        public string description { get; set; }
    }
}
