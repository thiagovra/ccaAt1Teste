using System;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {

        List<string> MergedNames = new List<string>();

        foreach (string name in names2)
        {
            if (!names1.Contains(name))
            {
                MergedNames.Add(name);
            }
        }
        foreach (string name in names1)
        {
            if (!names2.Contains(name))
            {
                MergedNames.Add(name);
            }
            foreach (string name2 in names2)
            {
                if (name.Equals(name2))
                {
                    MergedNames.Add(name);
                    // append name to new list of equal names
                }
            }
        }

        MergedNames.Sort();
        return MergedNames.ToArray();
    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}


