using System;
using EfCodeFirstSqlliteVsCode.Models;

namespace EfCodeFirstSqlliteVsCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new SampleContext() ) {
                var parents = db.Parents;
                
                foreach (var parent in parents) {
                    System.Console.WriteLine($"{parent.Id} - {parent.Name}");
                }
            }
        }
    }
}
