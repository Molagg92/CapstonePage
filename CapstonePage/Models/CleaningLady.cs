using System.Globalization;
using System.Collections.Generic;

namespace Capstone.Models
{
    public class CleaningLady
    {

        public string Name { get; set; }
        public int Phone { get; set; }
        public CleaningLady(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }

         // Static method to get all cleaning ladies (example)
        public static List<CleaningLady> GetAll()
        {
            // In a real scenario, you would probably fetch data from a database
            // For now, let's create a sample list
            List<CleaningLady> cleaningLadies = new List<CleaningLady>
            {
                new CleaningLady("Alice", 123),
                new CleaningLady("Bob", 456),
                new CleaningLady("Charlie", 789)
            };

            return cleaningLadies;
        }
    }
}