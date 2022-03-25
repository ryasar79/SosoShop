namespace SOSOSHOP.Entity.Concrete
{
	using SOSOSHOP.Core.Entity;
	using SOSOSHOP.Entity.Abstract;
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
        public DateTime created_at
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }

        private DateTime? dateCreated = null;
        public ICollection<Address> Addresses { get; set; }
    }
}
