using MyWish.Exceptions;
using MyWish.Types;
using System.Net.NetworkInformation;

namespace MyWish;

internal static class Wishes
{
    internal static string Make(Newlyweds newlyweds)
    {
        if (newlyweds.Check() is false)
        {
            throw new MakeWishesException();
        }

        return $"Drodzy: {newlyweds.Female.Name} i {newlyweds.Male.Name}, aby wasza wspólna droga nigdy nie zwróciła '{nameof(MakeWishesException)}'! <3";
    }
}
