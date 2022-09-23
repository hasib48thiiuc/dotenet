

using System.Collections;

List<string> names = new List<string> { "jalaluddin", "tareq", "hasan" };
string[] fruits = new string[] { "apple", "banana", "mango" };

foreach(string name in names)
{
    if(name.Length <= 5)
        Console.WriteLine(name);
}

var query = from name in names
            where name.Length <= 5
            select name;

var query2 = from t in query
             where t.StartsWith('a')
             select t;


List<string> query3 = names.Where(x => x.Length <= 5).ToList();
