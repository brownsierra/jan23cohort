public class Eruption
{
    public string Volcano { get; set; }
    public int Year { get; set; }
    public string Location { get; set; }
    public int ElevationInMeters { get; set; }
    public string Type { get; set; }
    public Eruption(string volcano, int year, string location, int elevationInMeters, string type)
    {
        Volcano = volcano;
        Year = year;
        Location = location;
        ElevationInMeters = elevationInMeters;
        Type = type;
    }
    public override string ToString()
    {
        return $@"
Name: {Volcano}
Year: {Year}
Location: {Location}
Elevation: {ElevationInMeters} meters
Type: {Type}
            ";
    }
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
}
