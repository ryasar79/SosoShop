namespace SOSOShop.Entity.Concrete
{
    using SOSOShop.Entity.Abstract;
	using SOSOSHOP.Core.Entity;
    public class OrderItem : BaseEntity, IEntity
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

    }
}
