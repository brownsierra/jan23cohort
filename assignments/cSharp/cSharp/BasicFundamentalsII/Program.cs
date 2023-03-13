//THREE BASIC ARRAYS//
int[] num = {0,1,2,3,4,5,6,7,8,9};
string[] names = {"Tim","Martin","Nikki","Sara"};
bool[] trufal = new bool[10];

// for (int i = 0; i < 10; i++) {
//     Console.WriteLine(num[i]);
// }

trufal[0] = true;
trufal[1] = false;
trufal[2] = true;
trufal[3] = false;
trufal[4] = true;
trufal[5] = false;
trufal[6] = true;
trufal[7] = false;
trufal[8] = true;
trufal[9] = false;
// Console.WriteLine(trufal[0]);

//LIST OF FLAVORS//
List<string> IceCream = new List<string>(5);
IceCream.Add("Vanilla");
IceCream.Add("Chocolate Chip Cookie Dough");
IceCream.Add("Chocolate");
IceCream.Add("Rocky Road");
IceCream.Add("Butter Pecan");
IceCream.Add("Orange Sherbert");
Console.WriteLine(IceCream.Count);
Console.WriteLine(IceCream[2]);
IceCream.RemoveAt(2);
Console.WriteLine(IceCream.Count);


// //USER DICTIONARY//
Dictionary<string,string> IceCreamMan = new Dictionary<string,string>();
Random rand = new Random();
IceCreamMan.Add ("Tim", IceCream[rand.Next(6)]);
IceCreamMan.Add ("Martin", IceCream[rand.Next(6)]);
IceCreamMan.Add ("Nikki", IceCream[rand.Next(6)]);
IceCreamMan.Add ("Sara", IceCream[rand.Next(6)]);


foreach(KeyValuePair<string,string> entry in IceCreamMan) {
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}

