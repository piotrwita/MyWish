using MyWish;
using MyWish.Types;

var female = new Person("Anitka", SexType.Female);
var male = new Person("Krisu", SexType.Male);
var newlyweds = new Newlyweds(female, male);

Console.WriteLine(Wishes.Make(newlyweds));


