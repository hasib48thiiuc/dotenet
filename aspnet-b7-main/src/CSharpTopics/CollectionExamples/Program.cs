// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");

int[] ages = new int[10];
int[,] grid = new int[10, 10];

int[][] jagged = new int[10][];
jagged[0] = new int[10];

List<int> grades = new List<int>();
grades.Add(89);
grades.Add(38);
grades[2] = 1;

List<string> cities = new List<string>();
cities.Add("Dhaka");
cities.Add("Khulna");

Dictionary<string, int> scores = new Dictionary<string, int>();
scores.Add("Jalaluddin", 99);
scores["Jalaluddin"] = 39;

HashSet<string> hash = new HashSet<string>();
hash.Add("Dhaka");

Stack<int> stack = new Stack<int>();
Queue<int> queue = new Queue<int>();

SortedList<int, int> sorted = new SortedList<int, int>();
SortedDictionary<string, int> keyValues = new SortedDictionary<string, int>();
SortedSet<int> sortedKeys = new SortedSet<int>();

NameValueCollection nameValueCollection = new NameValueCollection();
nameValueCollection.Add("hello", "world");

IReadOnlyCollection<int> keyValues2 = new ReadOnlyCollection<int>(new List<int>());

LinkedList<int> linkedList = new LinkedList<int>();

ArrayList list = new ArrayList();
list.Add(5);
list.Add("Dhaka");
object[] items = list.ToArray();

SortedList sortedList = new SortedList();
Stack stack2 = new Stack();
Queue queue2 = new Queue();

byte[] myBytes = new byte[5] { 1, 2, 3, 4, 5 };
BitArray myBA3 = new BitArray(myBytes);

foreach (var x in myBA3)
{
    Console.WriteLine(x);
}








