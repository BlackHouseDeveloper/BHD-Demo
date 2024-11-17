namespace BHD_Demo.Validations.Store;

public interface IValidationRule<T>
{
    string ValidationMessage { get; set; }

    bool Check(T value);
}