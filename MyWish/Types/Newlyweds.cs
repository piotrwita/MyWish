namespace MyWish.Types;

internal sealed record Newlyweds(Person Female, Person Male)
{
    public bool Check()
    {
        if (Female is null || Male is null)
        {
            return false;
        }

        return true;
    }
}