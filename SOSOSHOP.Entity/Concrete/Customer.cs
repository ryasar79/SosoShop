namespace SOSOShop.Entity.Concrete
{
	using SOSOSHOP.Core.Entity;
	using SOSOShop.Entity.Abstract;
	public class Customer : BaseEntity, IEntity
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
        }

        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
        public DateTime created_at { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
