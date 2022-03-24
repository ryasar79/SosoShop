namespace SOSOShop.Entity.Concrete
{
    using SOSOShop.Entity.Abstract;
	using SOSOSHOP.Core.Entity;
    public class Product : BaseEntity, IEntity
    {
        public string name { get; set; }
        public string sku { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int category_id{ get; set; }
    }
}
