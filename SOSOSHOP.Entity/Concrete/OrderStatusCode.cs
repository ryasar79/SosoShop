namespace SOSOShop.Entity.Concrete
{
    using SOSOShop.Entity.Abstract;
	using SOSOSHOP.Core.Entity;

	public class OrderStatusCode : BaseEntity, IEntity
    {
        public string status_code{ get; set; }
        public string description { get; set; }
    }
}
