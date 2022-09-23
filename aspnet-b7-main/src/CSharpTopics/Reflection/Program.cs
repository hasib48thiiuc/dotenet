// See https://aka.ms/new-console-template for more information
using Reflection;
using System.Reflection;

string className = Console.ReadLine();
string propertyName = Console.ReadLine();
string propertyValue = Console.ReadLine();

Assembly assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType(className);

PropertyInfo property = type.GetProperty(propertyName);
ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(int) });

object instance = constructor.Invoke(new object[] { 80 });
property.SetValue(instance, propertyValue);

foreach(var p in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine($"{p.Name}: {p.GetValue(instance)}");
}


Person person2 = new Person(23);
person2.Name = "Tareq";
person2.Address = "Dhaka";
person2.Children = new Child[2];
person2.Children[0] = new Child
{
    Name = "Rida",
    Age = 9,
    Gender = "F"
};
person2.Children[1] = new Child
{
    Name = "Ruhi",
    Age = 5,
    Gender = "F"
};

string json = ConvertToJson(person2);

string ConvertToJson(object person)
{
    throw new NotImplementedException();
}