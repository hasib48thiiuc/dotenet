using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExamples
{
    public class AsyncExample
    {
        public async Task Copy(string path, string path2)
        {
            Task<string> task1 = File.ReadAllTextAsync(path);
            Task<string> task2 = File.ReadAllTextAsync(path2);

            Task.WaitAll(task1, task2);
        }

        public async Task PrintAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
    }
}
