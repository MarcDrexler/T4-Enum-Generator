using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCodeFirstSqlVs.Models;

namespace EfCodeFirstSqlVs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new SampleContext())
            {
                var parents = db.Parents;

                foreach (var parent in parents)
                {
                    System.Console.WriteLine($"{parent.Id} - {parent.Name}");
                }
            }
        }
    }
}
