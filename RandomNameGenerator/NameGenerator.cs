using System.Text;
using System.Text.Json;

namespace RandomNameGenerator;

/// <summary>
/// NameGenerator class, used to generate a random name.
/// </summary>
internal class NameGenerator
{
    /// <summary>
    /// Class for holding the lists of names from names.json
    /// </summary>
    private struct NameList
    {
        public string[] Boys { get; set; }
        public string[] Girls { get; set; }
        public string[] Last { get; set; }
    }

    private readonly Random random = new();
    private readonly List<string> Male;
    private readonly List<string> Female;
    private readonly List<string> Last;

    /// <summary>
    /// Initialises a new instance of the RandomName class.
    /// </summary>
    /// <param name="random">A Random that is used to pick names</param>
    public NameGenerator()
    {
        string jsonString = File.ReadAllText("names.json");
        NameList nameList = JsonSerializer.Deserialize<NameList>(jsonString);

        Male = new List<string>(nameList.Boys);
        Female = new List<string>(nameList.Girls);
        Last = new List<string>(nameList.Last);
    }

    /// <summary>
    /// Returns a new random name
    /// </summary>
    /// <param name="sex">The sex of the person to be named. true for male, false for female</param>
    /// <param name="middle">How many middle names do generate</param>
    /// <param name="isInital">Should the middle names be initials or not?</param>
    /// <returns>The random name as a string</returns>
    public string Generate(Sex sex, int middle = 0, bool isInital = false)
    {
        // determines if we should select a name from male or female, and randomly picks
        string first = sex == Sex.Male ? Male[random.Next(Male.Count)] : Female[random.Next(Female.Count)];
        string last = Last[random.Next(Last.Count)]; // gets the last name

        List<string> middles = new();

        for (int i = 0; i < middle; i++)
        {
            if (isInital)
            {
                // randomly selects an uppercase letter to use as the inital and appends a dot
                middles.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ"[random.Next(0, 25)].ToString() + ".");
            }
            else
            {
                // randomly selects a name that fits with the sex of the person
                middles.Add(sex == Sex.Male ? Male[random.Next(Male.Count)] : Female[random.Next(Female.Count)]);
            }
        }

        StringBuilder stringBuilder = new();
        stringBuilder.Append(first + " ");          // put a space after our names

        foreach (string m in middles)
        {
            stringBuilder.Append(m + " ");
        }
        stringBuilder.Append(last);

        return stringBuilder.ToString();
    }

    /// <summary>
    /// Generates a list of random names
    /// </summary>
    /// <param name="count">The number of names to be generated</param>
    /// <param name="maxMiddleNames">The maximum number of middle names</param>
    /// <param name="sex">The sex of the names, if null sex is randomised</param>
    /// <param name="initials">Should the middle names have initials, if null this will be randomised</param>
    /// <returns>List of strings of names</returns>
    public List<string> RandomNames(int count, int maxMiddleNames, Sex? sex = null, bool? initials = null)
    {
        List<string> names = new();

        for (int i = 0; i < count; i++)
        {
            if (sex != null && initials != null)
            {
                names.Add(Generate((Sex)sex, random.Next(0, maxMiddleNames + 1), (bool)initials));
            }
            else if (sex != null)
            {
                bool init = random.Next(0, 2) != 0;
                names.Add(Generate((Sex)sex, random.Next(0, maxMiddleNames + 1), init));
            }
            else if (initials != null)
            {
                Sex s = (Sex)random.Next(0, 2);
                names.Add(Generate(s, random.Next(0, maxMiddleNames + 1), (bool)initials));
            }
            else
            {
                Sex s = (Sex)random.Next(0, 2);
                bool init = random.Next(0, 2) != 0;
                names.Add(Generate(s, random.Next(0, maxMiddleNames + 1), init));
            }
        }

        return names;
    }
}

public enum Sex
{
    Male,
    Female
}
