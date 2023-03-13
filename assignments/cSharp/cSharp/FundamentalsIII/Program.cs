// // // 1. Iterate and print values

// static void PrintList(List<string> MyList)
// {
//     for (int i = 0; i < MyList.Count; i++) {
//         Console.WriteLine(MyList[i]);
//     }
// }
// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);




// // 2. Print Sum

// static void SumOfNumbers(List<int> IntList)
// {
//     int sum = 0;
//     for( int i = 0; i < IntList.Count; i++) {
//     sum += IntList[i];
//     }
//         Console.WriteLine(sum);
// }
// List<int> TestIntList = new List<int>() {2,7,12,9,3};
// // You should get back 33 in this example
// SumOfNumbers(TestIntList);




//3. Find Max

// static int FindMax(List<int> IntList)
// {
//     int max = IntList[0];
//     for(int i = 0; i < IntList.Count; i++) {
//         if(IntList[i] > max) {
//             max = IntList[i];
//         }
//     }
//     Console.WriteLine(max);
//     return(max);
// }
// List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// // You should get back 17 in this example
// FindMax(TestIntList2);





// // 4. Square the Values

// static List<int> SquareValues(List<int> IntList)
// {
//     for(int i = 0; i < IntList.Count; i++) {
//         Console.WriteLine(IntList[i] * IntList[i]);
//     }
//     return(IntList);
// }
// List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// // You should get back [1,4,9,16,25], think about how you will show that this worked
// SquareValues(TestIntList3);




// 5. Replace Negative Numbers with 0

// static int[] NonNegatives(int[] IntArray)
// {
//     for(int i = 0; i < IntArray.Length; i++) {
//         if(IntArray[i] < 0) {
//             IntArray[i] = 0;
//         }
//         Console.WriteLine(IntArray[i]);
//     }
//     return(IntArray);
// }
// int[] TestIntArray = new int[] {-1,2,3,-4,5};
// // You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);




// 6. Print Dictionary

// static void PrintDictionary(Dictionary<string,string> MyDictionary)
// {
// // foreach(KeyValuePair<string,string> entry in MyDictionary)
// // {
// //     Console.WriteLine($"{entry.Key} - {entry.Value}");
// // }
// }
// Dictionary<string,string> TestDict = new Dictionary<string,string>();
// TestDict.Add("HeroName", "Iron Man");
// TestDict.Add("RealName", "Tony Stark");
// TestDict.Add("Powers", "Money and intelligence");
// // PrintDictionary(TestDict);




// // 7. Find Key
// static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
// {
//     bool result = false;
//     foreach(var i in MyDictionary) {
//         if( SearchTerm == i.Key) {
//             result = true;
//         }
//     }
//     return result;
// }
// // FindKey(TestDict,);
// // Use the TestDict from the earlier example or make your own
// // This should print true
// Console.WriteLine(FindKey(TestDict, "RealName"));
// // This should print false
// Console.WriteLine(FindKey(TestDict, "Name"));



// 8. Generate a Dictionary
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary <string,int> PplAndAges = new Dictionary <string,int>(); 
    string s = "";
    int n = 0;
    for(int i = 0; i < Names.Count; i++) {
        s = Names[i];
        n = Numbers[i];
        // Console.WriteLine($"This is {s} and {n}.");
        PplAndAges.Add(s,n);
    }
        foreach(KeyValuePair<string,int> entry in PplAndAges)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
    return PplAndAges;
}
List<string> names = new List<string> {"Sierra","Kierra","Jocelyn","Autumn"};
List<int> ages = new List<int>{24, 24, 21, 20};
GenerateDictionary(names, ages);

