// See https://aka.ms/new-console-template for more information
using CSharp10Features;


var person = new Person();

IEngine engine = new TurboEngine();
engine.Start();

(int x, int y) point;

point.x = 5;
point.y = 9;

using var file = new System.IO.StreamWriter("WriteLines2.txt");

string name = null;

name ??= "Hello";