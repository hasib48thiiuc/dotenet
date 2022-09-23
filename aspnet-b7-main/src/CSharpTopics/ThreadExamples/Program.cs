// See https://aka.ms/new-console-template for more information


using ThreadExamples;

Thread thread = new Thread(() => Print(100));
thread.Start();

Thread thread2 = new Thread(() => Print2(100));
thread2.Start();

//Print(100);
//Print2(100);

void Print(int n)
{
    for(int i = 0; i < n; i++)
        if(i % 2 != 0)
        Console.WriteLine(i);
}

void Print2(int n)
{
    for (int i = 0; i < n; i++)
        if(i % 2 == 0)
            Console.WriteLine(i);
}

Console.WriteLine("Finish");


AsyncExample asyncExample = new AsyncExample();
await asyncExample.Copy("abc.txt", "dkkd.txt");