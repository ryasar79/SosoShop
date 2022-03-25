namespace SOSOSHOP.Business.Validators
{
    using FluentValidation;
    using SOSOSHOP.Business.DTO.Request;
    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(s => s.Id).NotEmpty().GreaterThan(0);
            RuleFor(s => s.email_address).NotEmpty().EmailAddress();
            RuleFor(s => s.first_name).Length(2, 50);
            RuleFor(s => s.last_name).NotEmpty().When(t => t.first_name != null);
        }
    }
}
