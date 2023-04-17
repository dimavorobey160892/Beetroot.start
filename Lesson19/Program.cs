using Newtonsoft.Json;

namespace Lesson19HomeTask;

internal static class Program
{
    // todo the following tasks
    // 1. find out who is located farthest north/south/west/east using latitude/longitude data
    // 2. find max and min distance between 2 persons
    // 3. find 2 persons whos ‘about’ have the most same words
    // 4. find persons with same friends (compare by friend’s name)
    
    private static void Main()
    {
        var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json")).ToList();

        // 1. find out who is located farthest north/south/west/east using latitude/longitude data

        var northMax = persons.MaxBy(p => p.Latitude);
        var southMax = persons.MinBy(p => p.Latitude);
        var westMax = persons.MinBy(p => p.Longitude);
        var eastMax = persons.MaxBy(p => p.Longitude);

        // 2. find max and min distance between 2 persons
        List<dynamic> listOfDistances = new List<dynamic>();
        for (var i = 0; i < persons.Count - 1; i++)
        {
            for (var j = i+1; j < persons.Count; j++)
            {
                if (persons[i].Id != persons[j].Id)
                {
                    var distance = getDistance(persons[i].Latitude, persons[i].Longitude,
                        persons[j].Latitude, persons[j].Longitude);
                    listOfDistances.Add(new
                    {
                        Person1 = persons[i],
                        Person2 = persons[j],
                        Distance = distance
                    });
                }
            }
        }
        var maxDist = listOfDistances.MaxBy(d => d.Distance);
        var MinDist = listOfDistances.MinBy(d => d.Distance);

        // 3. find 2 persons whos ‘about’ have the most same words

        List<dynamic> listOfWords = new List<dynamic>();
        for (var i = 0; i < persons.Count - 1; i++)
        {
            for (var j = i+1; j < persons.Count; j++)
            {
                if (persons[i].Id != persons[j].Id)
                {
                    var sameWordsCount = SameWordsCount(persons[i].About, persons[j].About);
                    listOfWords.Add(new
                    {
                        Person1 = persons[i],
                        Person2 = persons[j],
                        SameWordsCount = sameWordsCount
                    });
                }
            }
        }

        var maxWords = listOfWords.MaxBy(w => w.SameWordsCount);
        var MinWords = listOfWords.MinBy(w => w.SameWordsCount);

        // 4. find persons with same friends (compare by friend’s name)

        List<dynamic> listOfFriends = new List<dynamic>();
        for (var i = 0; i < persons.Count - 1; i++)
        {
            for (var j = i+1; j < persons.Count; j++)
            {
                if (persons[i].Id != persons[j].Id)
                {
                    var sameFriends = IsSameFriends(persons[i].Friends, persons[j].Friends);
                    listOfFriends.Add(new
                    {
                        Person1 = persons[i],
                        Person2 = persons[j],
                        SameFriends = sameFriends
                    });
                }
            }
        }

        var peopleHaveSameFriends = listOfFriends.Where(l => l.SameFriends == true).ToList();

    }

    static double getDistance(double lat1, double lng1, double lat2, double lng2)
    {
        return Math.Acos(Math.Sin(lat1)*Math.Sin(lat2)+Math.Cos(lat1)*Math.Cos(lat2)*
            Math.Cos(lng2-lng1))*6371;
    }

    static int SameWordsCount(string personAbout1, string personAbout2)
    {
        var about1 = personAbout1.Replace("\r\n", "").Replace(",", "").
            Replace(".", "").Trim().ToLower().Split(" ").Distinct();
        var about2 = personAbout2.Replace("\r\n", "").Replace(",", "").
           Replace(".", "").Trim().ToLower().Split(" ").Distinct();
        var intersect = about1.Intersect(about2);
        return intersect.Count();
    }

    static bool IsSameFriends(Friend[] friend1, Friend[] friend2)
    {
        if (friend1.Length != friend2.Length)
        {
            return false;
        }
        var friendsName1 = friend1.Select(f => f.Name).ToList();
        var friendsName2 = friend2.Select(f => f.Name).ToList();
        var intersect = friendsName1.Intersect(friendsName2);
        if (intersect.Count() == friendsName2.Count)
        {
            return true;
        }
        return false;
    }
}