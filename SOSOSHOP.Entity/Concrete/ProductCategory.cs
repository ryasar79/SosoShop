namespace SOSOSHOP.Entity.Concrete
{
    using SOSOSHOP.Entity.Abstract;
	using SOSOSHOP.Core.Entity;
    public class ProductCategory : BaseEntity, IEntity
    {
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
    }
}
