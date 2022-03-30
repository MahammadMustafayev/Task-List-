using System;
using CustomList.Models;

namespace CustomList.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(23);
            customList.Add(54);
            customList.Add(123);

            //Console.WriteLine(customList.Count);
            //Console.WriteLine("------------------");
            customList.Exist(23);
            //customList.Show();
            //customList.Clear();
            //customList.IndexOf(1);
            //customList.Remove(1);
        }
    }
    
}
