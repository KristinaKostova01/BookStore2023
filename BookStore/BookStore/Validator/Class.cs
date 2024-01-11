using FluentValidation;

namespace BookStore.Validator
{
    public class SomeRequestValidator :
        AbstractValidator<SomeRequestValidator>
    {
        private object xSomeIntValue;

        public SomeRequestValidator()
        {
            RuleFor(expression: xSomeRequest => xSomeIntValue)
                .NotNull()
                .GreaterThan(valueToCompare: 0)
                .LessThan(valueToCompare: 1000)
                .WithMessage("")
}
    }
}
