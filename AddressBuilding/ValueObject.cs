namespace AddressBuilding;

public abstract class ValueObject<T>
{
    protected T Type { get; set; }
    protected string Value { get; set; }

    protected ValueObject(T type, string value)
    {
        Type = type;
        Value = value;
    }
}