// See https://aka.ms/new-console-template for more information
using System.Reflection;

string path = @"C:\Training\aspnet-b7\src\ReflectionLib.dll";
Assembly assembly = Assembly.LoadFile(path);

Type[] types = assembly.GetTypes();
foreach(var type in types)
{
    Type t = type.GetInterface("IModule");

    if(t != null)
    {
        Console.WriteLine(type.Name);
    }
}

string input = Console.ReadLine();
foreach(var t in types)
{
    if(t.Name == input)
    {
        MethodInfo method = t.GetMethod("Start");
        ConstructorInfo constructor = t.GetConstructor(new Type[]{ });
        object o = constructor.Invoke(new object[] { });
        method.Invoke(o, new object[] { });
    }
}
