using MyWish.Exceptions;

namespace MyWish.Types;

public sealed record SexType
{
    public static IReadOnlyCollection<string> AvailableSexTypes { get; } = new string[] { Male, Female };

    public string Value { get; }

    public SexType(string value)
    {
        if (!AvailableSexTypes.Contains(value))
        {
            throw new NotExistSexTypeException(value);
        }

        Value = value;
    }

    public const string Male = nameof(Male);
    public const string Female = nameof(Female);


    public static implicit operator SexType(string value) => new(value);
    public static implicit operator string(SexType value) => value.Value;
}