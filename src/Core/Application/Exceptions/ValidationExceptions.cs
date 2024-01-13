using FluentValidation.Results;

namespace Application.Exceptions
{
    public class ValidationExceptions : Exception
    {
        public ValidationExceptions() : base("There was one or more validation errors.")
        {
            Errors = new List<string>();
        }

        public List<string> Errors {get;}

        public ValidationExceptions(IEnumerable<ValidationFailure> failures) : this(){
            foreach(var failure in failures){
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}