List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
//My work begins below


// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption FirstChile = eruptions.First(e => e.Location == "Chile");
Console.WriteLine(FirstChile);
Console.WriteLine("----------------------------------------------------------");

// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption HawaiianIs = eruptions.FirstOrDefault( e => e.Location == "Hawaiian Is");
if(HawaiianIs is null) {
    Console.WriteLine("No Hawaiian Is Eruption found.");
}
Console.WriteLine(HawaiianIs);
Console.WriteLine("----------------------------------------------------------");


//Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption Questiontwo = eruptions.Where(e => e.Year > 1900)
                    .FirstOrDefault(e => e.Location == "New Zealand");
Console.WriteLine(Questiontwo);
Console.WriteLine("----------------------------------------------------------");


// Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> twothouele = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(twothouele, "twothouele.");
Console.WriteLine("----------------------------------------------------------");


// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> StartWithL = eruptions.Where(e => e.Volcano.StartsWith("L"))
                                            .ToList();
int StartWithLCount = eruptions.Where(e => e.Volcano.StartsWith("L"))
                                            .Count(e => e.Volcano.StartsWith("L"));
Console.WriteLine(String.Join(", ", StartWithL));
Console.WriteLine(StartWithL);
Console.WriteLine(StartWithLCount);
Console.WriteLine("----------------------------------------------------------");


// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestel = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine(highestel);
Console.WriteLine("----------------------------------------------------------");


// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
string? highestelname = eruptions.FirstOrDefault(e => e.ElevationInMeters == highestel)
                                .Volcano;
Console.WriteLine(highestelname);
Console.WriteLine("----------------------------------------------------------");


// Print all Volcano names alphabetically.
List<string>? Volcanonames = eruptions.OrderBy(e => e.Volcano)
                    .Select(e => e.Volcano)
                    .ToList();
Console.WriteLine(String.Join(", ", Volcanonames));
Console.WriteLine("----------------------------------------------------------");


// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> ErupBeforeThou = eruptions.Where(e => e.Year < 1000)
                                    .OrderBy(e => e.Volcano);
PrintEach(ErupBeforeThou);
Console.WriteLine("----------------------------------------------------------");


// BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> ErupBeforeThouNames = eruptions.Where(e => e.Year < 1000)
                                    .OrderBy(e => e.Volcano)
                                    .Select(e => e.Volcano)
                                    .ToList();
PrintEach(ErupBeforeThouNames);