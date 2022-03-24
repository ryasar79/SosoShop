namespace SOSOShop.Entity.Concrete
{
	using SOSOShop.Entity.Abstract;
	using SOSOSHOP.Core.Entity;
    	public class Order : BaseEntity, IEntity
    {
        public int customer_id { get; set; }
        public int status_code_id { get; set; }
        public DateTime created_at { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
