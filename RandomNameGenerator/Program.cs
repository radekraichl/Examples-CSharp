using RandomNameGenerator;

NameGenerator randomName = new();

var nameList = randomName.RandomNames(count: 10, maxMiddleNames: 1, initials: true);

foreach (var item in nameList)
{
    Console.WriteLine(item);
}
