using System;
using EfCodeFirstSql.Models;

namespace EfCodeFirstSql
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
