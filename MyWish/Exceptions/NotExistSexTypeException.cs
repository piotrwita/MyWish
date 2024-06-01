namespace MyWish.Exceptions;
internal sealed class NotExistSexTypeException(string sexType) : CustomException($"SexType: '{sexType}' `not exist.")
{
    public string SexType { get; } = sexType;
}
